
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voronin
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\version";
            Directory.CreateDirectory("Log");
            using (StreamReader sr = new StreamReader(path))
            {

                MyLog.log("Версия_программы: " + sr.ReadToEnd().Trim('\n'));
            }
            double a = 0, b = 0, c = 0;
            Console.WriteLine("Введите 3 параметра a, b и с");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            MyLog.log("Введено уравнение: " + a + "X^2+" + b + "X+" + c + "=0");
            try
            {
                QuaEquation calc = new QuaEquation();
                List<double> res = calc.solve(a, b, c);
                String s = "Корни уравнения: ";
                for(int i=0;i<res.Count;i++)
                {
                    s += res[i] + " ";
                }
                
                MyLog.log(s);
            }
            catch (VoroninException e)
            {
                MyLog.log("Ошибка: " + e.Message);
            }
            MyLog.write();
            Console.ReadKey();
        }
    }
}
