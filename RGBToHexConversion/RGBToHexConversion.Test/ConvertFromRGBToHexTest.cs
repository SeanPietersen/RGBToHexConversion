using RGBToHexConversion.App;
using System;
using Xunit;

namespace RGBToHexConversion.Test
{
    public class ConvertFromRGBToHexTest
    {
        [Theory]
        [InlineData(255, 255, 255, "FFFFFF")]
        [InlineData(255, 255, 300, "FFFFFF")]
        [InlineData(0, 0, 0, "000000")]
        [InlineData(148, 0, 211, "9400D3")]
        [InlineData(148, -20, 211, "9400D3")]
        [InlineData(144, 195, 212, "90C3D4")]
        [InlineData(212, 53, 12, "D4350C")]

        public void RGBToHexConverterTest_successful(int r, int g, int b, string expected)
        {
            //Arrange
            IConvertFromRGBToHex convertFromRGBToHex = new ConvertFromRGBToHex();

            //Act
            var actual = convertFromRGBToHex.RGBToHexConverter(r, g, b);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
