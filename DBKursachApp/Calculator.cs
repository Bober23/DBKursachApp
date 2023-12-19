using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBKursachApp
{
    public static class Calculator
    {

        public static int CalculateKdInMPa(string material)
        {
            if (material == "Сталь-сталь")
                return 495;
            if (material == "Сталь-чугун")
                return 445;
            if (material == "Сталь-бронза")
                return 430;
            if (material == "Чугун-чугун")
                return 415;
            if (material == "Текстолит-сталь")
                return 200;
            if (material == "ДСП-сталь")
                return 225;
            if (material == "Полиамид-сталь")
                return 155;  
            return -1;
        }
    }
}
