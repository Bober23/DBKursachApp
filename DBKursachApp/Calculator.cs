using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBKursachApp
{
    public static class Calculator
    {
        public static double CalculateD(int t, int n, string material, string type, double u, double fi, double T1)
        {
            int Kd = CalculateKdInMPa(type);
            double sigma = CalculateSigmaNPInMPa(t,n,material);
            return Kd * Math.Pow(T1*1/(u*fi*Math.Pow(sigma,2)), 0.33333333333);
        }
        public static double CalculateSigmaNPInMPa(int t, int n, string material)
        {
            return CalculateSigmaInMPa(material)*CalculateKnl(t, n, material);
        }
        public static long CalculateNHE(int t, int n)
        {
            return 60* t * n;
        }
        public static double CalculateKnl(int t, int n, string material) 
        {
            return Math.Pow(CalculateNHo(material)/CalculateNHE(t,n), 0.1666666666);
        }
        public static double CalculateNHo(string material)
        {
            if (material == "Сталь 45")
                return 1.5;
            if (material == "Сталь 50Г")
                return 6;
            if (material == "Сталь 40Х")
                return 2.5;
            if (material == "Сталь 40ХН")
                return 10;
            if (material == "Сталь 20Х")
                return 12;
            if (material == "Сталь 30ХГТ")
                return 12;
            if (material == "Чугун ВЧ")
                return 1;
            if (material == "Текстолит")
                return 0.06;
            if (material == "ДСП")
                return 0.06;
            if (material == "Полиамид")
                return 0.06;
            return -1;
        }
        public static int CalculateSigmaInMPa(string material)
        {
            if (material == "Сталь 45")
                return 600;
            if (material == "Сталь 50Г")
                return 800;
            if (material == "Сталь 40Х")
                return 650;
            if (material == "Сталь 40ХН")
                return 1000;
            if (material == "Сталь 20Х")
                return 1100;
            if (material == "Сталь 30ХГТ")
                return 1100;
            if (material == "Чугун ВЧ")
                return 600;
            if (material == "Текстолит")
                return 50;
            if (material == "ДСП")
                return 50;
            if (material == "Полиамид")
                return 40;
            return -1;
        }
        public static int CalculateKdInMPa(string type)
        {
            if (type == "Сталь-сталь")
                return 495;
            if (type == "Сталь-чугун")
                return 445;
            if (type == "Сталь-бронза")
                return 430;
            if (type == "Чугун-чугун")
                return 415;
            if (type == "Текстолит-сталь")
                return 200;
            if (type == "ДСП-сталь")
                return 225;
            if (type == "Полиамид-сталь")
                return 155;  
            return -1;
        }
    }
}
