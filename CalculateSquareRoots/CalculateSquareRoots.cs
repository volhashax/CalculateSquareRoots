using System;
using System.Collections.Generic;
using System.Text;

namespace it_academy
{
    public enum RootExistanceEnum
    {
        NotDefined,
        NoRoot,
        OneRoot,
        TwoRoot
    }

    public class CalculateSquareRoots
    {
        public float x1, x2;

        public RootExistanceEnum rootExistance = RootExistanceEnum.NotDefined;

        public void Calculate(float a, float b, float c)
        {
            if (a == 0)
            {
                rootExistance = RootExistanceEnum.NoRoot;
                return;
            }

            var d = b * b - 4 * a * c;

            if (d < 0)
            {
                rootExistance = RootExistanceEnum.NoRoot;
            }
            else if (d == 0)
            {
                rootExistance = RootExistanceEnum.OneRoot;
            }
            else
            {
                rootExistance = RootExistanceEnum.TwoRoot;
            }

        }
    }
}
