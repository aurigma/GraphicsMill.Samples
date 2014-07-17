# Graphics Mill Samples

Graphics Mill is and an advanced image processing library. It  allows loading/saving images (JPEG, PNG, GIF, TIFF, EPS, PDF, EPS, PSD and others) in different formats (RGB, CMYK, 8 and 16-bit), manipulating metadata (EXIF, IPTC, XMP, Adobe Resources), manipulating image channels, image operations (crop, resize, rotate, flip), drawing images, primitives, simple and artistic text,  color management operations, color and tone adjustment and image filtering. 

Website: http://www.graphicsmill.com/

Support: http://www.graphicsmill.com/support

## Font and Text

*/FontAndText/*

### Plain and Bounded (Multiline) Text

*/FontAndText/PlainAndBoundedText/*

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
