# Graphics Mill Samples

Graphics Mill is an advanced image processing library. Here is a brief features highlight:

* Loads/saves JPEG, PNG, GIF, TIFF, EPS, PDF, EPS, PSD and other image formats.
* Pixels can be RGB, CMYK, Lab, grayscale, 8 and 16-bit per channel.
* Manipulate metadata such as EXIF, IPTC, XMP, Adobe Resources (including clipping path).
* Popular operations on images including crop, resize, rotate and many others.
* Other bitmap manipulation algorithms, filters, color/tone/brightness/contrasts adjustments.
* Draw bitmap and vector elements.
* Powerful text output features - single and multiline text, artistic effects, text line distortions.
* Convert colors with ICC profiles.

Graphics Mill Web Controls is a front end for Graphics Mill library. It includes:

* Bitmap Viewer - displays, zooms, crops and applies different effects on images.
* AJAX Vector Objects - powerful composite image editing tool built into a webpage.

It allows building rich image editing web application like business card or t-shirt editor.

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

### A.10. WebP Format

*/A.LoadAndSave/A.10.WebPFormat/*

Demonstrates how to convert an image to WebP format (both simple and animated).

### A.11. RAW Format

*/A.LoadAndSave/A.11.RAWFormat/*

Reads RAW image format.

### A.12. Extract TIFF Preview from EPS

*/A.LoadAndSave/A.12.ExtractTIFFPreviewFromEPS/*

Extracts TIFF preview from EPS file.

### A.13. Writing EPS and PDF

*/A.LoadAndSave/A.13.WritingEPSAndPDF/*

Saves an image and graphics as PDF and EPS file (as bitmap and as vector).

### A.14. TGA Format

*/A.LoadAndSave/A.14.TGAFormat/*

Loads and saves TARGA images.

### A.15. PNG NeuQuant

*/A.LoadAndSave/A.15.PNGNeuQuant/*

Demonstrates how to reduce 24-bit colors to 8-bit using NeuQuant algorithm and save the result to PNG. Comparing to classic color quantization algorithms, NeuQuant provides much better quality and preserves alpha channel, scarifying the performance.

### A.16. Smart Image Optimization

*/A.LoadAndSave/A.16.SmartImageOptimization/*

Automatically selects a JPEG quality to get a file of a specified size. If it is not enough (or if you are saving to an alternative file format), the algorithm resizes the image until the output file meets the specified size limit.

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

### B.05. Autorotate

*/B.FiltersAndTransforms/B.05.Autorotate/*

Automatically rotates images based on EXIF orientation field. For JPEG images it uses lossless transform to prevent quality degradation.

### B.06. Tint

*/B.FiltersAndTransforms/B.06.Tint/*

Tints image using specified color.

### B.07. Advanced Tone Correction

*/B.FiltersAndTransforms/B.07.AdvancedToneCorrection/*

Implements Levels and Curves (look up tables) functionality of Photoshop as well as Lab color space usage.

### B.08. Color Adjustment

*/B.FiltersAndTransforms/B.08.ColorAdjustment/*

Adjusts the channel balance of an image in RGB, HSL and Lab color spaces.

### B.09. Minimum, Maximum, Median

*/B.FiltersAndTransforms/B.09.MinimumMaximumMedian/*

Demonstrates how to use morphological filters on images.

### B.10. Bezier

*/B.FiltersAndTransforms/B.10.Bezier/*

Demonstrates how to warp images on an arbitrary 3D surface described with a Bezier function. 

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

### C.05. Draw Image

*/C.Drawing/C.05.DrawImage/*

Combines several images by drawing a bitmap over another one. It respects the transparency and alpha channels.

### C.06. Artistic Frame

*/C.Drawing/C.06.ArtisticFrame/*

Adds an artistic frame to the image.

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

### D.07. Formatted Text

*/D.FontAndText/D.07.FormattedText/*

Demonstrates how to draw a formatted text. It is possible to change font settings for each character.

### D.08. Paragraphs and Lists

*/D.FontAndText/D.08.ParagraphsAndLists/*

Renders formatted text with paragraphs and lists (both ordered and unordered).

### D.09. Text Flow Control

*/D.FontAndText/D.09.TextFlowControl/*

Demonstrates how to have text to flow between several blocks, as well as wrap text blocks around some objects.

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

### E.07. Converting Color Values

*/E.ColorManagement/E.07.ConvertingColorValues/*

Converts an individual color between different color spaces with color management applied.

### E.08. Lab Color Space

*/E.ColorManagement/E.08.LabColorSpace/*

Demonstrates basics of image processing in Lab color space.

### E.09. Color Proofing

*/E.ColorManagement/E.09.ColorProofing/*

Demonstrates color proofing.

### E.10. Device Link Profile

*/E.ColorManagement/E.10.DeviceLinkProfile/*

Converts pixels between two CMYK color spaces using device link color profiles - simplified color management technique which does not require converting colors to a device independent color space.

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

### I.02. Modify and Merge Layers

*/I.PSDFormat/I.02.ModifyAndMergeLayers/*

Demonstrates how to parse, modify and merge layers of PSD file.

### I.03. Curved Text

*/I.PSDFormat/I.03.CurvedText/*

Demonstrates how to parse and merge layers of PSD file with curved text.

### I.04. Render Templates

*/I.PSDFormat/I.04.RenderTemplates/*

Demonstrates how to to use PsdProcessor to load a Adobe Photoshop (PSD) file, modify the content of its text and image layers and merge the result to PDF or JPEG.

### I.05. Create 3D Preview

*/I.PSDFormat/I.05.Create3DPreview/*

Creates a personalized mug 3D preview. The mug model is extracted from a PSD file (image of a mug as a raster layer and bitmap mapping info as a SmartObject) and the image on a mug is provided by a user.

## J. Windows Forms

*/J.WinForms/*

### J.01. Image Editor

*/J.WinForms/J.01.ImageEditor/*

A sample image editing application based on Graphics Mill. It demonstrates how to apply various image transformations and display the result on the BitmapViewer control.

### J.02. Asynchronous Processing

*/J.WinForms/J.02.AsynchronousProcessing/*

Demonstrates how to apply effects and display result on a BitmapViewer in two manners - synchronously and asynchronously, using Tasks.

## K. Web

*/K.Web/*

### K.01. Graphics Mill AJAX Controls Samples

*/K.Web/K.01.AjaxControls/*

These samples show how to create a simple image editing tool to your page which can
work with images of any size without loading the entire image from the server.

#### Bitmap Viewer Demo

*/K.Web/K.01.AjaxControls/BitmapViewerDemo.aspx*

A simple viewer of a large image. A user may zoom and scroll the image and only visible part
is downloaded from a server (very quickly!)

#### Photo Crop Demo

*/K.Web/K.01.AjaxControls/PhotoCropDemo.aspx*

A cropping tool based on Bitmap Viewer. You may control the aspect ratios of the crop.

### K.02. Graphics Mill AJAX Vector Objects Samples

*/K.Web/K.02.AjaxVectorObjects/*

These samples illustrate how to do the following things:

* Add or edit images, text, artistic text and graphics.
* Manipulate objects using both JavaScript and C#.
* Automatically render result as JPEG or PDF.
* Work with PSD templates.

#### Vector Objects Editor

*/K.Web/K.02.AjaxVectorObjects/VectorObjectsEditor.aspx*

A simple vector image editor built into a page.

#### PSD Template Editor

*/K.Web/K.02.AjaxVectorObjects/PsdTemplateEditor.aspx*

Loads a multi-layer Adobe Photoshop file and edits it in a browser.

#### Upload Template Using AJAX

*/K.Web/K.02.AjaxVectorObjects/UploadTemplateAjax.aspx*

An image editor which allows uploading Adobe Photoshop based templates using AJAX.

#### Upload Image Using AJAX

*/K.Web/K.02.AjaxVectorObjects/UploadImageAjax.aspx*

An image editor which allows uploading any image to a canvas using AJAX.

#### Render Template using Postback

*/K.Web/K.02.AjaxVectorObjects/RenderTemplatePostback.aspx*

Loads an Adobe Photoshop file as a template and converts the result to PDF.

## L. Misc

*/L.Misc/*

### L.01. System.Drawing Interoperability

*/L.Misc/L.01.SystemDrawingInteroperability/*

Demonstrates how to integrate Graphics Mill with an application where System.Drawing.Bitmap is intensively used.
