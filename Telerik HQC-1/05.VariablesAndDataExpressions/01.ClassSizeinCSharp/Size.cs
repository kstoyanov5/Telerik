using System;

/// <summary>
/// This class to calculates the dimensions of a bounding
/// box surrounding a rectangle which is rotated by given angle (alpha).
/// </summary>
public class Size
{
    private double width;
    private double height;

    public Size(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double Width
    {
        get
        {
            return this.width;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Can't assign negative width.");
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }

        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Can't assign negative height.");
            }

            this.height = value;
        }
    }

    /// <summary>
    /// Returns the size (width, height) of the bounding box.
    /// </summary>
    /// <param name="size">The size of the rectangle.</param>
    /// <param name="alpha">The angle of rotation.</param>
    /// <returns>The dimensions of the bounding box.</returns>
    public static Size GetRotatedSize(Size size, double alpha)
    {
        var sinAlpha = Math.Sin(alpha);
        var cosAlpha = Math.Cos(alpha);

        var absSinAlpha = Math.Abs(sinAlpha);
        var absCosAlpha = Math.Abs(cosAlpha);

        var originalWidth = size.Width;
        var originalHeight = size.Height;

        var rotatedWidth = (absSinAlpha * originalWidth) + (absCosAlpha * originalHeight);
        var rotatedHeight = (absCosAlpha * originalWidth) + (absSinAlpha * originalHeight);

        var rotatedSize = new Size(rotatedWidth, rotatedHeight);
        return rotatedSize;
    }
}
