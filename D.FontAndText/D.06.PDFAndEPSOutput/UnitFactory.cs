using Aurigma.GraphicsMill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UnitFactory
{
    public UnitFactory(float dpi)
    {
        if (dpi <= 0)
            throw new System.ArgumentOutOfRangeException("dpi must be positive.");

        this.Dpi = dpi;
    }

    public float Dpi { private set; get; }

    public int Inch(float inches)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, inches, Unit.Inch);
    }

    public int Mm(float mm)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, mm, Unit.Mm);
    }

    public int Cm(float cm)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, cm, Unit.Cm);
    }

    public int Meter(float m)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, m, Unit.M);
    }

    public int Point(float point)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, point, Unit.Point);
    }

    public int Pica(float pica)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, pica, Unit.Pica);
    }

    public int Column(float column)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, column, Unit.Column);
    }

    public int Twip(float twip)
    {
        return UnitConverter.ConvertUnitsToPixels(this.Dpi, twip, Unit.Twip);
    }
}

