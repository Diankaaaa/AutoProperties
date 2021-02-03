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
        public double second { get; set; }//Коэфицент А
        public double first { get; set; }//Коэфицент В

        //Конструктор
        public Equation(double a, double b)
        {
            second = a;
            first = b;
        }

        public double root(double a, double b)
        {
            return -first / second;
        }
    }
}
