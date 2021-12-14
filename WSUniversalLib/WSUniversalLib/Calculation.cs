using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int getQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if (count <= 0 || width <= 0 || length <= 0)
                return -1;

                float coefProdType = 0;
            float coefMatType = 0;

            switch (productType)
            {
                case 1:
                    coefProdType = 1.1f;
                    break;
                case 2:
                    coefProdType = 1.1f;
                    break;
                case 3:
                    coefProdType = 1.1f;
                    break;
                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    coefMatType = 1 - 0.3f / 100;
                    break;
                case 2:
                    coefMatType = 1 - 0.12f / 100;
                    break;
                default:
                    return -1;
            }

            return (int)Math.Ceiling(count * width * length * coefProdType / coefMatType);
        }
    }
}
