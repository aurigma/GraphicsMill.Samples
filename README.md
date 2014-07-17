# Graphics Mill Samples

Graphics Mill is an advanced image processing library. It allows loading/saving images (JPEG, PNG, GIF, TIFF, EPS, PDF, EPS, PSD and others) in various bitmap formats (RGB, CMYK, 8 and 16-bit per channel), managing metadata (EXIF, IPTC, XMP, Adobe Resources), manipulating image channels and pixels, applying operations on images (crop, resize, rotate, flip), drawing bitmap and vector elements, single and multiline text (including artistic effects and text line distortions),  converting colors with ICC profiles, adjust color/tone/brightness/contrasts and apply image filters. 

Graphics Mill Web Controls is a front end for Graphics Mill image processing library. Set of web controls allow viewing and editing graphics. Use Bitmap Viewer allows to display, zoom, crop and apply different effects on bitmap images. AJAX Vector Objects allows viewing and editing composite images consisting of multiple elements such as bitmaps, texts and vector data which can be used to build rich image editing application like business card or t-shirt editor.

Website: http://www.graphicsmill.com/

Support: http://www.graphicsmill.com/support

## Font and Text

*/FontAndText/*

### Plain and Bounded (Multiline) Text

[https://github.com/aurigma/GraphicsMill.Samples/tree/master/FontAndText/ArtText](/FontAndText/PlainAndBoundedText/)

Draws text strings and text areas on an image. Includes: horizontal and vertical single line text (with optional effects), multiline text bounded with a specified rectangle.

### Font Loading and Text Measuring

*/FontAndText/FontLoadingAndTextMeasuring/*

Calculates width and height of a rectangle occupied by a text string with specified font settings as well as other font metrics. Includes: receiving text size and string ascender/descender, calculating “black box” of a regular string and artistic text (written on a circle), loads a font dynamically.

### Art Text

*/FontAndText/ArtText/*

Draws a text line with various artistic effects and distortions. Includes: various artistic text types (text on circle, bended text, etc) with variable bend level, text effects (glow, shadow).

### Double Path Text

*/FontAndText/DoublePathText/*

Distorts a text string using two custom Bezier curves (on the top and bottom of the string). Includes: drawing curved text based on two Beziers with variable font size.

### Watermark

*/FontAndText/Watermark/*

Fills a JPEG image with a text watermark. Includes: two types of watermark (simple diagonal watermark and two-string watermark with a grid).

### PDF and EPS Output

*/FontAndText/PDFAndEPSOutput/*

Generates two vector images and saves them as a PDF or EPS. Includes: drawing an image, vector and text data on a PDF/EPS, multipage PDF file support.
