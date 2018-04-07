using System;

namespace DSFM
{

    public class DSFMPosition
    {
        public float X { get; }
        public float Y { get; }

        public DSFMPosition(float x, float y)
        {
            if (x < 0 || x > 1 || y < 0 || y > 1)
            {
                throw new ArgumentOutOfRangeException("The positions should be a float between 0~1. It is relative to screen resolution.");
            }
            this.X = x;
            this.Y = y;
        }
    }

}