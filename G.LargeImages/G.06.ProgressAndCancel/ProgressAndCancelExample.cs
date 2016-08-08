using System;
using System.Threading;
using System.Threading.Tasks;
using Aurigma.GraphicsMill;
using Aurigma.GraphicsMill.Codecs;
using Aurigma.GraphicsMill.Transforms;

internal class ProgressAndCancelExample
{
    private static void Main(string[] args)
    {
        TrackProgress();
        TrackProgressAndCancel();
    }

    private static void TrackProgress()
    {
        Console.WriteLine("Progress Sample\r\n");

        // reader --->  resize  --->  progress  --->  writer
        using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
        using (var resize = new Resize(3200, 0, ResizeInterpolationMode.High))
        using (var progress = new ProgressReporter())
        using (var writer = ImageWriter.Create("../../../../_Output/TrackProgress.jpg"))
        {
            progress.Progress += (s, e) =>
            {
                Console.WriteLine("{0:F2}%", e.Progress);
            };

            Console.WriteLine("Start pipeline processing...\n");

            Pipeline.Run(reader + resize + progress + writer);

            Console.WriteLine("\nEnd pipeline processing...\n");
        }
    }

    private static void TrackProgressAndCancel()
    {
        Console.WriteLine("ProgressAndCancel Sample\n");
        Console.WriteLine("Press enter to start pipeline processing ");
        Console.WriteLine("After start press \"c\" to cancel pipeline processing.");

        Console.Read();

        var cancelTokenSource = new CancellationTokenSource();
        var cancelToken = cancelTokenSource.Token;

        var task = Task.Factory.StartNew(() =>
        {
            // reader --->  resize  --->  progress  --->  writer
            using (var reader = ImageReader.Create("../../../../_Input/Venice.jpg"))
            using (var resize = new Resize(16000, 0, ResizeInterpolationMode.High))
            using (var progress = new ProgressReporter())
            using (var writer = ImageWriter.Create("../../../../_Output/TrackProgressAndCancel.jpg"))
            {
                progress.Progress += (s, e) =>
                {
                    Console.WriteLine("{0:F2}%", e.Progress);

                    if (cancelToken.IsCancellationRequested == true)
                    {
                        Console.WriteLine("Pipeline processing was cancelled");
                        Console.WriteLine("\nPress \"x\" to quit");

                        cancelToken.ThrowIfCancellationRequested();
                    }
                };

                Console.WriteLine("Start cancellable pipeline processing...\n");

                Pipeline.Run(reader + resize + progress + writer);

                Console.WriteLine("\nEnd cancellable pipeline processing...");
                Console.WriteLine("\nPress \"x\" to quit");
            }
        }, cancelToken);

        var flag = true;

        while (flag)
        {
            switch (Console.ReadKey().KeyChar)
            {
                case 'c':
                    cancelTokenSource.Cancel();
                    Console.WriteLine("Task cancellation requested.");
                    break;

                case 'x':
                    flag = false;
                    break;
            }
        }
    }
}