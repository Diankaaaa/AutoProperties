using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    //Класс уравнения
    class Equation
    {
        public double A { get; set; }//Коэфицент А
        public double B { get; set; }//Коэфицент В
        public double X { get; set; }//Результирующее поле класса
        public Equation(double a, double b)
        {
            A = a;
            B = b;
        }

        public double root(double a, double b)
        {
            return X = -B / A;
        }
    }
}
