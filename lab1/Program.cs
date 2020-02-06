using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
    class A
    {
        protected double x;
        
        public double calcLinEquation(double a, double b)
        {
            if (a != 0)
            {
                return x = -b / a;
            }
            throw new MyException("Уравнение не существует");
        }
    }
    class B : A
    {
        protected double c;
        protected List<double> myList = new List<double>();


        protected double des(double a, double b, double c)
        {
            return b * b - 4 * a * c;
        }
        public List<double> solve(double a, double b, double c)
        {
            if (a == 0)
            {
                double x = this.calcLinEquation(b, c);
                myList.Add(x);
                return myList;
            }
            
            double des = this.des(a, b, c);
            //Корень один
            if (des == 0)
            {
                myList.Add((-b + Math.Sqrt(des)) / 2 * a);
                return myList;
            }
            //два корня
            if (des > 0)
            {
                myList.Add((-1 * b + Math.Sqrt(des)) / (2 * a));
                myList.Add((-1 * b - Math.Sqrt(des)) / (2 * a));
                return myList;
            }
            throw new MyException("Нет решений");
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<double> res ;
            try
            {
                B calc = new B();
                res = calc.solve(1,6,5);
                foreach(double temp in res)
                {
                    Console.WriteLine(temp);
                }    
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
