﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace BrightIdeasSoftware
{
    /// <summary>
    /// An adorment is the common base for overlays and decorations.
    /// </summary>
    public class GraphicAdornment
    {
        #region Public properties

        /// <summary>
        /// Gets or sets location within the reference rectange where the adornment will be drawn
        /// </summary>
        /// <remarks>This is a simplied interface to ReferenceCorner && AdornmentCorner </remarks>
        [Category("Appearance - ObjectListView"),
         Description("How will the adornment be aligned"),
         DefaultValue(ContentAlignment.BottomRight),
         NotifyParentProperty(true)]
        public ContentAlignment Alignment {
            get { return this.alignment; }
            set { 
                this.alignment = value;
                this.ReferenceCorner = value;
                this.AdornmentCorner = value;
            }
        }
        private ContentAlignment alignment = ContentAlignment.BottomRight;

        /// <summary>
        /// Gets or sets the point of the reference rectangle to which the adornment will be aligned.
        /// </summary>
        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ContentAlignment ReferenceCorner {
            get { return this.referenceCorner; }
            set { this.referenceCorner = value; }
        }
        private ContentAlignment referenceCorner = ContentAlignment.MiddleCenter;

        /// <summary>
        /// Gets or sets the corner of the adornment that will be positioned at the reference corner
        /// </summary>
        [Browsable(false),
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ContentAlignment AdornmentCorner {
            get { return this.adornmentCorner; }
            set { this.adornmentCorner = value; }
        }
        private ContentAlignment adornmentCorner = ContentAlignment.MiddleCenter;

        /// <summary>
        /// Gets or sets the offset by which the position of the adornment will be adjusted
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The offset by which the position of the adornment will be adjusted")]
        public Size Offset {
            get { return this.offset; }
            set { this.offset = value; }
        }
        private Size offset = new Size();

        /// <summary>
        /// Gets or sets the degree of rotation by which the adornment will be transformed.
        /// The centre of rotation will be the center point of the adornment.
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The degree of rotation that will be applied to the adornment."),
         DefaultValue(0),
         NotifyParentProperty(true)]
        public int Rotation {
            get { return this.rotation; }
            set { this.rotation = value; }
        }
        private int rotation;

        /// <summary>
        /// Gets or sets the transparency of the adornment. 
        /// 0 is completely transparent, 255 is completely opaque.
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("How transparent should adornment be? 0 is completely transparent, 255 is completely opaque"),
         DefaultValue(128)]
        public int Transparency {
            get { return this.transparency; }
            set {
                this.transparency = Math.Min(255, Math.Max(0, value));
            }
        }
        private int transparency = 128;

        #endregion

        #region Calculations

        /// <summary>
        /// Calculate a rectangle that has the given size which is positioned so that
        /// its alignment point is at the reference location of the given rect.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="sz"></param>
        /// <returns></returns>
        public Rectangle CreateAlignedRectangle(Rectangle r, Size sz) {
            return this.CreateAlignedRectangle(r, sz, this.ReferenceCorner, this.AdornmentCorner, this.Offset);
        }

        /// <summary>
        /// Create a rectangle of the given size which is positioned so that
        /// its indicated corner is at the indicated corner of the reference rect.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="sz"></param>
        /// <param name="reference"></param>
        /// <param name="alignment"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        /// <remarks>
        /// <para>Creates a rectangle so that its bottom left is at the centre of the reference:
        /// corner=BottomLeft, referenceCorner=MiddleCenter</para>
        /// <para>This is a powerful concept that takes some getting used to, but is
        /// very neat once you understand it.</para>
        /// </remarks>
        public Rectangle CreateAlignedRectangle(Rectangle r, Size sz,
            ContentAlignment corner, ContentAlignment referenceCorner, Size offset) {
            Point referencePt = this.CalculateCorner(r, referenceCorner);
            Point topLeft = this.CalculateAlignedPosition(referencePt, sz, corner);
            return new Rectangle(topLeft + offset, sz);
        }

        /// <summary>
        /// Calculate the location of rectangle of the given size,
        /// so that it's indicated corner would be at the given point.
        /// </summary>
        /// <param name="pt">The point</param>
        /// <param name="size"></param>
        /// <param name="corner">Which corner will be positioned at the reference point</param>
        /// <returns></returns>
        /// <example>CalculateAlignedPosition(new Point(50, 100), new Size(10, 20), ContentAlignment.TopLeft) -> Point(50, 100)</example>
        /// <example>CalculateAlignedPosition(new Point(50, 100), new Size(10, 20), ContentAlignment.MiddleCenter) -> Point(45, 90)</example>
        /// <example>CalculateAlignedPosition(new Point(50, 100), new Size(10, 20), ContentAlignment.BottomRight) -> Point(40, 80)</example>
        public Point CalculateAlignedPosition(Point pt, Size size, ContentAlignment corner) {
            switch (corner) {
                case ContentAlignment.TopLeft:
                    return pt;
                case ContentAlignment.TopCenter:
                    return new Point(pt.X - (size.Width / 2), pt.Y);
                case ContentAlignment.TopRight:
                    return new Point(pt.X - size.Width, pt.Y);
                case ContentAlignment.MiddleLeft:
                    return new Point(pt.X, pt.Y - (size.Height / 2));
                case ContentAlignment.MiddleCenter:
                    return new Point(pt.X - (size.Width / 2), pt.Y - (size.Height / 2));
                case ContentAlignment.MiddleRight:
                    return new Point(pt.X - (size.Width / 2), pt.Y);
                case ContentAlignment.BottomLeft:
                    return new Point(pt.X, pt.Y - size.Height);
                case ContentAlignment.BottomCenter:
                    return new Point(pt.X - (size.Width / 2), pt.Y - size.Height);
                case ContentAlignment.BottomRight:
                    return new Point(pt.X - size.Width, pt.Y - size.Height);
            }

            // Should never reach here
            return pt;
        }

        /// <summary>
        /// Return the point at the indicated corner of the given rectangle (it doesn't
        /// have to be a corner, but a named location)
        /// </summary>
        /// <param name="bounds">The reference rectangle</param>
        /// <param name="location">Which point of the rectangle should be returned?</param>
        /// <returns>A point</returns>
        /// <example>CalculateReferenceLocation(new Rectangle(0, 0, 50, 100), ContentAlignment.TopLeft) -> Point(0, 0)</example>
        /// <example>CalculateReferenceLocation(new Rectangle(0, 0, 50, 100), ContentAlignment.MiddleCenter) -> Point(25, 50)</example>
        /// <example>CalculateReferenceLocation(new Rectangle(0, 0, 50, 100), ContentAlignment.BottomRight) -> Point(50, 100)</example>
        public Point CalculateCorner(Rectangle r, ContentAlignment corner) {
            switch (corner) {
                case ContentAlignment.TopLeft:
                    return new Point(r.Left, r.Top);
                case ContentAlignment.TopCenter:
                    return new Point(r.X + (r.Width / 2), r.Top);
                case ContentAlignment.TopRight:
                    return new Point(r.Right, r.Top);
                case ContentAlignment.MiddleLeft:
                    return new Point(r.Left, r.Top + (r.Height / 2));
                case ContentAlignment.MiddleCenter:
                    return new Point(r.X + (r.Width / 2), r.Top + (r.Height  / 2));
                case ContentAlignment.MiddleRight:
                    return new Point(r.Right, r.Top + (r.Height / 2));
                case ContentAlignment.BottomLeft:
                    return new Point(r.Left, r.Bottom);
                case ContentAlignment.BottomCenter:
                    return new Point(r.X + (r.Width / 2), r.Bottom);
                case ContentAlignment.BottomRight:
                    return new Point(r.Right, r.Bottom);
            }
            
            // Should never reach here
            return r.Location;
        }

        #endregion

        #region Commands

        /// <summary>
        /// Apply any specified rotation to the Graphic content.
        /// </summary>
        /// <param name="g">The Graphics to be transformed</param>
        /// <param name="r">The rotation will be around the centre of this rect</param>
        protected void ApplyRotation(Graphics g, Rectangle r) {
            if (this.Rotation == 0)
                return;

            // THINK: Do we want to reset the transform? I think we want to push a new transform
            g.ResetTransform();
            Matrix m = new Matrix();
            m.RotateAt(this.Rotation, new Point(r.Left + r.Width / 2, r.Top + r.Height / 2));
            g.Transform = m;
        }

        /// <summary>
        /// Reverse the rotation created by ApplyRotation()
        /// </summary>
        /// <param name="g"></param>
        protected void UnapplyRotation(Graphics g) {
            if (this.Rotation != 0)
                g.ResetTransform();
        }

        #endregion
    }

    /// <summary>
    /// An overlay that will draw an image over the top of the ObjectListView
    /// </summary>
    public class ImageAdornment : GraphicAdornment
    {
        #region Public properties

        /// <summary>
        /// Gets or sets the image that will be drawn
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The image that will be drawn"),
         DefaultValue(null),
         NotifyParentProperty(true)]
        public Image Image {
            get { return this.image; }
            set { this.image = value; }
        }
        private Image image;

        #endregion

        #region Commands

        /// <summary>
        /// Draw the image in its specified location
        /// </summary>
        /// <param name="g">The Graphics used for drawing</param>
        /// <param name="r">The bounds of the rendering</param>
        public void DrawImage(Graphics g, Rectangle r) {
            this.DrawImage(g, r, this.Image, this.Transparency); 
        }

        /// <summary>
        /// Draw the image in its specified location
        /// </summary>
        /// <param name="image">The image to be drawn</param>
        /// <param name="g">The Graphics used for drawing</param>
        /// <param name="r">The bounds of the rendering</param>
        public void DrawImage(Graphics g, Rectangle r, Image image, int transparency) {
            if (image == null)
                return;

            Rectangle adornmentBounds = this.CreateAlignedRectangle(r, image.Size);
            try {
                this.ApplyRotation(g, adornmentBounds);
                this.DrawTransparentBitmap(g, adornmentBounds.Location, image, transparency);
            }
            finally {
                this.UnapplyRotation(g);
            }
        }

        private void DrawTransparentBitmap(Graphics g, Point pt, Image image, int transparency) {
            ImageAttributes imageAttributes = new ImageAttributes();
            if (transparency != 255) {
                float a = (float)transparency / 255.0f;
                float[][] colorMatrixElements = {
                    new float[] {1,  0,  0,  0, 0},
                    new float[] {0,  1,  0,  0, 0},
                    new float[] {0,  0,  1,  0, 0},
                    new float[] {0,  0,  0,  a, 0},
                    new float[] {0,  0,  0,  0, 1}};

                imageAttributes.SetColorMatrix(new ColorMatrix(colorMatrixElements));
            }

            g.DrawImage(image,
               new Rectangle(pt, image.Size),              // destination rectangle
               0, 0, image.Size.Width, image.Size.Height,  // source rectangle
               GraphicsUnit.Pixel,
               imageAttributes);
        }

        #endregion
    }

    /// <summary>
    /// An adornment that will draw text
    /// </summary>
    public class TextAdornment : GraphicAdornment
    {
        #region Public properties

        /// <summary>
        /// Gets or sets the font that will be used to draw the text
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The font that will be used to draw the text"),
         DefaultValue(null),
         NotifyParentProperty(true)]
        public Font Font {
            get { return this.font; }
            set { this.font = value; }
        }
        private Font font;

        /// <summary>
        /// Gets the font that will be used to draw the text or a reasonable default
        /// </summary>
        [Browsable(false)]
        public Font FontOrDefault {
            get {
                return this.Font ?? new Font("Tahoma", 16);
            }
        }

        /// <summary>
        /// How rounded should the corners of the border be? 0 means no rounding.
        /// </summary>
        /// <remarks>If this value is too large, the edges of the border will appear odd.</remarks>
        public float CornerRounding {
            get { return this.cornerRounding; }
            set { this.cornerRounding = value; }
        }
        private float cornerRounding = 16.0f;

        /// <summary>
        /// Gets or sets the color of the text
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The color of the text"),
         DefaultValue(typeof(Color), "DarkBlue"),
         NotifyParentProperty(true)]
        public Color TextColor {
            get { return this.textColor; }
            set { this.textColor = value; }
        }
        private Color textColor = Color.DarkBlue;

        /// <summary>
        /// Gets the brush that will be used to paint the text
        /// </summary>
        [Browsable(false)]
        public Brush TextBrush {
            get {
                return new SolidBrush(Color.FromArgb(this.Transparency, this.TextColor));
            }
        }

        /// <summary>
        /// Gets or sets the text that will be drawn
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The text that will be drawn over the top of the ListView"),
         DefaultValue(null),
         NotifyParentProperty(true),
         Localizable(true)]
        public string Text {
            get { return this.text; }
            set { this.text = value; }
        }
        private string text;

        /// <summary>
        /// Gets or sets the background color of the text
        /// Set this to Color.Empty to not draw a background
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The background color of the text"),
         DefaultValue(typeof(Color), "")]
        public Color BackColor {
            get { return this.backColor; }
            set { this.backColor = value; }
        }
        private Color backColor = Color.Empty;

        /// <summary>
        /// Does this text have a background?
        /// </summary>
        [Browsable(false)]
        public bool HasBackground {
            get {
                return this.BackColor != Color.Empty;
            }
        }

        /// <summary>
        /// Gets or sets the color of the border around the billboard.
        /// Set this to Color.Empty to remove the border
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The color of the border around the text"),
         DefaultValue(typeof(Color), "")]
        public Color BorderColor {
            get { return this.borderColor; }
            set { this.borderColor = value; }
        }
        private Color borderColor = Color.Empty;

        /// <summary>
        /// Gets or sets the width of the border around the text
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The width of the border around the text"),
         DefaultValue(0.0f)]
        public float BorderWidth {
            get { return this.borderWidth; }
            set { this.borderWidth = value; }
        }
        private float borderWidth;

        /// <summary>
        /// Gets or sets the maximum width of the text
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The maximum width the text"),
         DefaultValue(0)]
        public int MaximumTextWidth {
            get { return this.maximumTextWidth; }
            set { this.maximumTextWidth = value; }
        }
        private int maximumTextWidth;

        /// <summary>
        /// Gets or sets the formatting that should be used on the text
        /// </summary>
        [Category("Appearance - ObjectListView"),
         Description("The width of the border around the text"),
         DefaultValue(0.0f)]
        public StringFormat StringFormat {
            get {
                if (this.stringFormat == null) {
                    this.stringFormat = new StringFormat();
                    this.stringFormat.Alignment = StringAlignment.Center;
                    this.stringFormat.LineAlignment = StringAlignment.Center;
                    this.stringFormat.Trimming = StringTrimming.EllipsisCharacter;
                }
                return this.stringFormat; 
            }
            set { this.stringFormat = value; }
        }
        private StringFormat stringFormat;

        /// <summary>
        /// Gets the brush that will be used to paint the text
        /// </summary>
        [Browsable(false)]
        public Pen BorderPen {
            get {
                return new Pen(Color.FromArgb(this.Transparency, this.BorderColor), this.BorderWidth);
            }
        }

        /// <summary>
        /// Does this overlay have a border?
        /// </summary>
        [Browsable(false)]
        public bool HasBorder {
            get {
                return this.BorderColor != Color.Empty && this.BorderWidth > 0;
            }
        }

        /// <summary>
        /// Gets the brush that will be used to paint the text
        /// </summary>
        [Browsable(false)]
        public Brush BackgroundBrush {
            get {
                return new SolidBrush(Color.FromArgb(this.Transparency, this.BackColor));
            }
        }

        #endregion

        #region Implementation

        /// <summary>
        /// Draw our text with our stored configuration
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        public void DrawText(Graphics g, Rectangle r) {
            this.DrawText(g, r, this.Text);
        }

        /// <summary>
        /// Draw the given text with our stored configuration
        /// </summary>
        /// <param name="g">The Graphics used for drawing</param>
        /// <param name="r">The bounds of the rendering</param>
        /// <param name="text">The text to draw</param>
        public void DrawText(Graphics g, Rectangle r, string text) {
            if (String.IsNullOrEmpty(text))
                return;

            Rectangle textRect = this.CalculateTextBounds(g, r, text);
            this.DrawBorderedText(g, textRect, text);
        }

        /// <summary>
        /// Draw the text with a border
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <param name="text">The text to draw</param>
        protected void DrawBorderedText(Graphics g, Rectangle textRect, string text) {
            Rectangle borderRect = textRect;
            borderRect.Inflate((int)this.BorderWidth / 2, (int)this.BorderWidth / 2);
            borderRect.Y -= 1; // Looker better a little higher

            try {
                this.ApplyRotation(g, textRect);
                using (GraphicsPath path = this.GetRoundedRect(borderRect, this.CornerRounding)) {
                    if (this.HasBackground)
                        g.FillPath(this.BackgroundBrush, path);

                    g.DrawString(text, this.FontOrDefault, this.TextBrush, textRect, this.StringFormat);

                    if (this.HasBorder)
                        g.DrawPath(this.BorderPen, path);
                }
            }
            finally {
                this.UnapplyRotation(g);
            }
        }

        /// <summary>
        /// Return the rectangle that will be the precise bounds of the displayed text
        /// </summary>
        /// <param name="g"></param>
        /// <param name="r"></param>
        /// <returns>The bounds of the text</returns>
        protected Rectangle CalculateTextBounds(Graphics g, Rectangle r, string text) {
            int maxWidth = this.MaximumTextWidth <= 0 ? r.Width : this.MaximumTextWidth;
            SizeF sizeF = g.MeasureString(text, this.FontOrDefault, maxWidth, this.StringFormat);
            Size size = new Size(1 + (int)sizeF.Width, 1 + (int)sizeF.Height);
            return this.CreateAlignedRectangle(r, size);
        }

        /// <summary>
        /// Return a GraphicPath that is a round cornered rectangle
        /// </summary>
        /// <param name="rect">The rectangle</param>
        /// <param name="diameter">The diameter of the corners</param>
        /// <returns>A round cornered rectagle path</returns>
        /// <remarks>If I could rely on people using C# 3.0+, this should be
        /// an extension method of GraphicsPath.</remarks>
        protected GraphicsPath GetRoundedRect(Rectangle rect, float diameter) {
            GraphicsPath path = new GraphicsPath();

            if (diameter > 0) {
                RectangleF arc = new RectangleF(rect.X, rect.Y, diameter, diameter);
                path.AddArc(arc, 180, 90);
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);
                path.CloseFigure();
            } else {
                path.AddRectangle(rect);
            }

            return path;
        }

        #endregion
    }
}
