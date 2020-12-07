using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_december1_
{
    class Class1
    {
        double a, b, c = 0;
        public Class1(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        double Ploshad(double a, double b, double c)
        {
            double poluPerimetr = (a + b + c) / 2;
            return Math.Sqrt(poluPerimetr * (poluPerimetr - a) * (poluPerimetr - b) * (poluPerimetr - c));
        }

        double Perimetr(double a, double b, double c)
        {
            return a + b + c;
        }

        string Type(double a, double b, double c)
        {
            if (Math.Pow(c, 2) != Math.Pow(a, 2) + Math.Pow(b, 2)) return (Math.Pow(c, 2) < Math.Pow(a, 2) + Math.Pow(b, 2)) ? "Острый" : "Тупой";
            else return "Прямоугольный";
        }

        public void trianglesCount(List<Class1> list)
        {
            int ostr = 0;
            int pryam = 0;
            int tup = 0;
            string res = "";
            foreach (Class1 triangle in list)
            {
                string type = Type(triangle.a, triangle.b, triangle.c);
                switch (type)
                {
                    case "Прямоугольный":
                        {
                            pryam++;
                            break;
                        }
                    case "Острый":
                        {
                            ostr++;
                            break;
                        }
                    case "Тупой":
                        {
                            tup++;
                            break;
                        }
                }
            }
            System.Windows.MessageBox.Show($"Острых {ostr}, прямоугольных {pryam}, тупых {tup}");
        }
    }
}
