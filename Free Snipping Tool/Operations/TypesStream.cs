using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Windows.Forms;

class TypesConvertor
{

    public static Font ConvertStringToFont(string font)
    {
        FontConverter fontconvert = new FontConverter();
        return (Font)fontconvert.ConvertFromString(font);
    }


    public static Color ConvertStringToColor(string color)
    {
        ColorConverter colorconvert = new ColorConverter();
        return (Color)colorconvert.ConvertFromString(color);
    }

    public static Point ConvertStringToPoint(string point)
    {
        PointConverter pointconvert = new PointConverter();
        return (Point)pointconvert.ConvertFromString(point);
    }

    public static Size ConvertStringToSize(string size)
    {
        SizeConverter sizeconvertor = new SizeConverter();
        return (Size)sizeconvertor.ConvertFromString(size);
    }

    public static Keys ConvertStringToKey(string key)
    {
        KeysConverter keyconvertor = new KeysConverter();
        return (Keys)keyconvertor.ConvertFromString(key);
    }

}

