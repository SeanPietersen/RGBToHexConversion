using System;
using System.Drawing;
using System.Linq;

namespace RGBToHexConversion.App
{
    public class ConvertFromRGBToHex : IConvertFromRGBToHex
    {
        public string RGBToHexConverter(int r, int g, int b)
        {
            if(!(Enumerable.Range(0,255).Contains(r)))
            {
                if(r < 0)
                {
                    r = 0;
                }
                if(r > 255)
                {
                    r = 255;
                }
                
            }
            if (!(Enumerable.Range(0, 255).Contains(g)))
            {
                if (g < 0)
                {
                    g = 0;
                }
                if (g > 255)
                {
                    g = 255;
                }
            }
            if (!(Enumerable.Range(0, 255).Contains(b)))
            {
                if (b < 0)
                {
                    b = 0;
                }
                if (b > 255)
                {
                    b = 255;
                }
                
            }

            Color myColorValue = Color.FromArgb(r, g, b);

            String hexidecimal = myColorValue.R.ToString("X2") + myColorValue.G.ToString("X2") + myColorValue.B.ToString("X2");

            return hexidecimal;
        }
    }
}
