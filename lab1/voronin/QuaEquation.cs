using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voronin
{
    class QuaEquation : LinEquation, Core.EquationInterface
    {
        protected List<double> xs = new List<double>();

        protected double descr(double a, double b, double c)
        {
            return  b * b - 4 * a * c;
        }
        public List<double> solve(double a, double b, double c)
        {
            if (a == 0)
            {
                double x = this.calcLinEquation(b, c);
                xs.Add(x);
                return xs;
            }
            MyLog.log("Определено, что это квадратное уравнение");
            double des = this.descr(a,b,c);
            //Корень один
            if (des == 0)
            {
                xs.Add((-b + Math.Sqrt(des)) / 2 * a);
                return xs;
            }
            //два корня
            if (des > 0)
            {
                xs.Add((-1 * b + Math.Sqrt(des)) / (2 * a));
                xs.Add((-1 * b - Math.Sqrt(des)) / (2 * a));
                return xs;
            }              
            throw new VoroninException("Нет решений");
        }
    }
}
