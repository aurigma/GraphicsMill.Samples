using System;
using Aurigma.GraphicsMill.Codecs;

internal class XMPExample
{
    private static void Main(string[] args)
    {
        ReadXmpMetadata();
        ReadXmpProperty();
    }

    /// <summary>
    /// Reads all XMP properties
    /// </summary>
    private static void ReadXmpMetadata()
    {
        using (var reader = new JpegReader(@"../../../../_Input/Chicago.jpg"))
        {
            if (reader.Xmp != null)
            {
                var xmp = new XmpData(reader.Xmp);

                foreach (XmpNode node in xmp.Values)
                {
                    if (node.NodeType == XmpNodeType.SimpleProperty)
                    {
                        Console.WriteLine("{0}: {1}", node.Name, node);
                    }
                }
            }
        }
    }

    /// <summary>
    /// Reads specific XMP property
    /// </summary>
    private static void ReadXmpProperty()
    {
        using (var reader = new Aurigma.GraphicsMill.Codecs.JpegReader(@"../../../../_Input/Chicago.jpg"))
        {
            // Check if XMP data are present in the file
            if (reader.Xmp != null)
            {
                // Get an XML code from the reader
                var xmp = new Aurigma.GraphicsMill.Codecs.XmpData(reader.Xmp);

                // Print the value of the xmp:CreatorTool tag if it exists
                if (xmp.Contains(Aurigma.GraphicsMill.Codecs.XmpTagNames.XmpCreatorTool))
                {
                    Console.WriteLine("\n\nThis image was created using {0}",
                        xmp[Aurigma.GraphicsMill.Codecs.XmpTagNames.XmpCreatorTool]);
                }
            }
        }
    }
}