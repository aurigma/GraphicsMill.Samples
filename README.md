# Graphics Mill Samples

Graphics Mill is an advanced image processing library. It allows loading/saving images (JPEG, PNG, GIF, TIFF, EPS, PDF, EPS, PSD and others) in various bitmap formats (RGB, CMYK, 8 and 16-bit per channel), managing metadata (EXIF, IPTC, XMP, Adobe Resources), manipulating image channels and pixels, applying operations on images (crop, resize, rotate, flip), drawing bitmap and vector elements, single and multiline text (including artistic effects and text line distortions),  converting colors with ICC profiles, adjust color/tone/brightness/contrasts and apply image filters. 

Graphics Mill Windows Controls is a set of Windows Forms controls which helps you creating image processing user interface in desktop applications. Bitmap Viewer control displays a bitmap on the screen with zoom, scroll and crop functionality. Vector Objects module allows working with composite images consisting of multiple elements such as bitmaps, texts and vector data. Thumbnail List View control display a collection of images no matter if they are stored in a file system or memory.

Website: http://www.graphicsmill.com/

Support: http://www.graphicsmill.com/support

## A. Load and Save

*/A.LoadAndSave/*

### A.01. Loading and Saving Images

*/A.LoadAndSave/A.01.LoadingAndSavingImages/*

Demonstrates various methods how to use Graphics Mill to load and save images. Both simple syntax to load a single image and more advanced techniques (to load multi-image files) are presented.

### A.02. JPEG Format

*/A.LoadAndSave/A.02.JPEGFormat/*

Loads and saves JPEG images.

### A.03. Lossless JPEG Transforms

*/A.LoadAndSave/A.03.LosslessJPEGTransforms/*

Demonstrates how to apply lossless operations (rotate, flip, crop, update region and metadata) on JPEG files, without decoding/encoding JPEG data (therefore, avoiding image quality degradation).

### A.04. TIFF Format

*/A.LoadAndSave/A.04.TIFFFormat/*

Loads and saves TIFF images (both single and multiple pages).

### A.05. TIFF Extra Channels

*/A.LoadAndSave/A.05.TIFFExtraChannels/*

Reads and writes extra channel to a TIFF image (such as spot colors or additional alpha channels).

### A.06. PNG Format

*/A.LoadAndSave/A.06.PNGFormat/*

Loads and saves PNG images. Converts a bitmap to a palette-based image optimized for web.

### A.07. BMP Format

*/A.LoadAndSave/A.07.BMPFormat/*

Loads and saves BMP images.

### A.08. GIF Format

*/A.LoadAndSave/A.08.GIFFormat/*

Loads and saves GIF images. Converts a bitmap to a palette-based image optimized for web.

### A.09. Animated GIF

*/A.LoadAndSave/A.09.AnimatedGIF/*

Creates an animated GIF. Extracts all frames of animated GIF and resizes GIF without loosing the animation.

## B. Filters and Transforms

*/B.FiltersAndTransforms/*

### B.01. Resize

*/B.FiltersAndTransforms/B.01.Resize/*

Demonstrates how to resize images and generate thumbnails.

###  B.02 Rotate, Flip

*/B.FiltersAndTransforms/B.02.RotateFlip/*

Rotates and flips images. You can rotate both 90/180 degrees clockwise and counterclockwise as well as an arbitrary angle.

### B.03. Crop

*/B.FiltersAndTransforms/B.03.Crop/*

Demonstrates how to crop a portion of an image.

### B.04. Brightness, Contrast

*/B.FiltersAndTransforms/B.04.BrightnessContrast/*

Adjusts a brightness/contrast of an image.

## C. Drawing

*/C.Drawing/*

### C.01. Line, Rectangle, Ellipse

*/C.Drawing/C.01.LineRectangleEllipse/*

Draws graphics primitives (line, rectangle, ellipse, polygon, curves) on RGB, CMYK, Grayscale images.

### C.02. Matrix Transform

*/C.Drawing/C.02.MatrixTransform/*

Applies an affine transformation (translate, rotate, resize, shear and their combinations) to a drawn graphics using a matrix.

### C.03. Graphics Path

*/C.Drawing/C.03.GraphicsPath/*

Demonstrates how to draw complicated graphics using Graphics Paths.

### C.04. Clipping Path

*/C.Drawing/C.04.ClippingPath/*

Demonstrates drawing inside a region (also known as Clipping Path). Only those portions of graphics which are located inside a Clipping Path are visible.

### C.05. Combine Images

*/C.Drawing/C.05.CombineImages/*

Combines several images by drawing a bitmap over another one. It respects the transparency and alpha channels.

## D. Font and Text

*/D.FontAndText/*

### D.01. Plain and Bounded (Multiline) Text

*/D.FontAndText/D.01.PlainAndBoundedText/*

Draws text strings and text areas on an image. Includes: horizontal and vertical single line text (with optional effects), multiline text bounded with a specified rectangle.

### D.02. Font Loading and Text Measuring

*/D.FontAndText/D.02.FontLoadingAndTextMeasuring/*

Calculates width and height of a rectangle occupied by a text string with specified font settings as well as other font metrics. Includes: receiving text size and string ascender/descender, calculating “black box” of a regular string and artistic text (written on a circle), loads a font dynamically.

### D.03. Art Text

*/D.FontAndText/D.03.ArtText/*

Draws a text line with various artistic effects and distortions. Includes: various artistic text types (text on circle, bended text, etc) with variable bend level, text effects (glow, shadow).

### D.04. Double Path Text

*/D.FontAndText/D.04.DoublePathText/*

Distorts a text string using two custom Bezier curves (on the top and bottom of the string). Includes: drawing curved text based on two Beziers with variable font size.

### D.05. Watermark

*/D.FontAndText/D.05.Watermark/*

Fills a JPEG image with a text watermark. Includes: two types of watermark (simple diagonal watermark and two-string watermark with a grid).

### D.06. PDF and EPS Output

*/D.FontAndText/D.06.PDFAndEPSOutput/*

Generates two vector images and saves them as a PDF or EPS. Includes: drawing an image, vector and text data on a PDF/EPS, multipage PDF file support.

## E. Color Management

*/E.ColorManagement/*

### E.01. Converting Pixel Formats

*/E.ColorManagement/E.01.ConvertingPixelFormats/*

Demonstrates how to convert an image between different pixel formats (RGB, CMYK, indexed, black-white, extended precision per channel). Creates indexed PNG images optimized for web. Adds alpha channel to a bitmap.

### E.02. CMYK, Grayscale to RGB

*/E.ColorManagement/E.02.CMYKGrayscaleToRGB/*

Сonverts a non-RGB image (such as CMYK or grayscale) to a standard 8 bit per-channel RGB pixel format.

### E.03. RGB to CMYK

*/E.ColorManagement/E.03.RGBToCMYK/*

Illustrates how to convert an RGB image to CMYK with or without color management. Generates an RGB preview of this color conversion to display it on the screen.

### E.04. Color Profile

*/E.ColorManagement/E.04.ColorProfile/*

Demonstrates how to work with color profile files, i.e. load them from images and separate files, append them to bitmaps, extract info from them.

### E.05. Color Management Engines

*/E.ColorManagement/E.05.ColorManagementEngines/*

Demonstrates how to convert CMYK/RGB images using different color management engines. LittleCMS and Adobe Color Management Module (CMM) are supported.

### E.06. Channels

*/E.ColorManagement/E.06.Channels/*

Explains how to work with image channels - split, combine or swap them. Find here how to add/remove alpha channel or make pixels of a given color transparent.

## F. Metadata

*/F.Metadata/*

### F.01. EXIF and IPTC

*/F.Metadata/F.01.EXIFAndIPTC/*

Reads and writes EXIF and IPTC metadata of image files (such as JPEG, TIFF).

### F.02. Thumbnail from EXIF

*/F.Metadata/F.02.ThumbnailFromEXIF/*

Demonstrates very efficient technique to receive thumbnails for JPEG files - it extracts them from EXIF and if it doesn't exist, it resizes the JPEG file in a classic manner.

### F.03. XMP

*/F.Metadata/F.03.XMP/*

Reads and writes XMP metadata.

### F.04. Adobe Image Resource Blocks

*/F.Metadata/F.04.AdobeImageResourceBlocks/*

Reads and writes Adobe Resource metatada.

### F.05. Clipping Path

*/F.Metadata/F.05.ClippingPath/*

Demonstrates how to work with a clipping path added to an image in Adobe Photoshop. It is a part of in Adobe Resource metatada.

### F.06. Preserving Metadata

*/F.Metadata/F.06.PreservingMetadata/*

Shows how to preserve metadata (EXIF, IPTC, XMP, Adobe Resources) while you process images.

## G. Large Images (Memory-Friendly Pipeline API)

*/G.LargeImages/*

### G.01. Resize, Rotate, Crop

*/G.LargeImages/G.01.ResizeRotateCrop/*

Demonstrates how to use memory-friendly Pipeline API to apply basic image processing operations such as resizing, rotation, cropping, combine and other effects. Strongly recommended for large images.

### G.02. Drawing

*/G.LargeImages/G.02.Drawing/*

Draws rectangles, ellipses, etc on large images using a memory-friendly Pipeline API.

### G.03. Pipeline API Syntax

*/G.LargeImages/G.03.PipelineAPISyntax/*

Shows how to use Pipeline API in various ways. See alternative syntaxes illustrating how to build a pipeline of readers, writers, and transforms for memory-friendly image processing.

### G.04. Multiple Receivers

*/G.LargeImages/G.04.MultipleReceivers/*

Explains how to apply several image transformations to a single image in one run (e.g. generate thumbnails of several sizes). It allows processing an image in the most efficient way avoiding unnecessary file reading operations.

### G.05. Multiple Sources

*/G.LargeImages/G.05.MultipleSources/*

Explains how to use several images in one image transformation (i.e. build a pipeline which accepts several sources). In this example, a RGB bitmap is constructed from 3 grayscale images.

### G.06. Progress and Cancel

*/G.LargeImages/G.06.ProgressAndCancel/*

Demonstrates how to track a progress event (e.g. to display a progress indicator) and cancel the effect if the user press a hotkey.

### G.07. Split Image into Tiles

*/G.LargeImages/G.07.SplitImageIntoTiles/*

Illustrates an example of a complicated pipeline which cuts a very large image into a big amount of smaller tiles at a single run.

## H. Green Screen Removal

*/H.GreenScreenRemoval/*

### H.01. Green Screen Removal

Demonstrates how to apply green screen matting (chroma keying) technique, i.e. removes green background from an image.

*/H.GreenScreenRemoval/H.01.GreenScreenRemoval/*

## I. PSD Format (Adobe Photoshop)

*/I.PSDFormat/*

### I.01. Merge and Resize

*/I.PSDFormat/I.01.MergeAndResize/*

Reads PSD images (including multilayered ones). Loads each layer, combines them together and creates a thumbnail.

## J. Windows Forms

*/J.WinForms/*

### J.01. Image Editor

*/J.WinForms/J.01.ImageEditor/*

A sample image editing application based on Graphics Mill. It demonstrates how to apply various image transformations and display the result on the BitmapViewer control.

### J.02. Asynchronous Processing

*/J.WinForms/J.02.AsynchronousProcessing/*

Demonstrates how to apply effects and display result on a BitmapViewer in two manners - synchronously and asynchronously, using Tasks.
