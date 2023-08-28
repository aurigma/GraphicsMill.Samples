using System;

using Aurigma.GraphicsMill;

/// <summary>
/// This sample is excluded from solution build because it needs a specific Desktop Application license to be installed in the registry.
/// In order to work with X64, you need to replace Graphics Mill package with X64 version.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // We need to initiate license checking.
        var bitmap = new Bitmap();

        // Some delay may happen.
        while (Configuration.License == null)
        {
            System.Threading.Thread.Sleep(500);
        }

        // The source field should be "EmbeddedIntoAssembly".
        // To make sure that the application will run on other PCs, you may remove/rename 
        // license entry in the registry, and run the app once again.
        Console.WriteLine(Configuration.License.Source.ToString());
        Console.WriteLine(Configuration.License.MaintenanceExpirationDate.ToString());
        Console.WriteLine(Configuration.License.LicenseKey.ToString());
    }
}