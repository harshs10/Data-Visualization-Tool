using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    static class Program
    {
        //class info
        public class info
        {
            float a, b, c, d, e, f, g, h, i, j, k, l, m;

            public info()
            {
            }
            public info(List<float> listA)
            {
                this.a = listA.ElementAt(0);
                this.b = listA.ElementAt(1);
                this.c = listA.ElementAt(2);
                this.d = listA.ElementAt(3);
                this.e = listA.ElementAt(4);
                this.f = listA.ElementAt(5);
                this.g = listA.ElementAt(6);
                this.h = listA.ElementAt(7);
                this.i = listA.ElementAt(8);
                this.j = listA.ElementAt(9);
                this.k = listA.ElementAt(10);
                this.l = listA.ElementAt(11);
                this.m = listA.ElementAt(12);
            }
            public float getb()
            {
                return b;
            }
            public float getc()
            {
                return c;
            }
            public float getd()
            {
                return d;
            }
            public float gete()
            {
                return e;
            }
            public float getf()
            {
                return f;
            }
            public float getg()
            {
                return g;
            }
            public float geth()
            {
                return h;
            }
            public float geti()
            {
                return i;
            }
            public float getj()
            {
                return j;
            }
            public float getk()
            {
                return k;
            }
            public float getl()
            {
                return l;
            }
            public float getm()
            {
                return m;
            }
        }
        public static List<info> l1 = new List<info>();
        public static List<info> l2 = new List<info>();
        public static info obj = new info();
        public static info obj2 = new info();
        [STAThread]
        //Main function
        public static void Main(string[] args)
        {
            //Change file path
            var reader = new StreamReader(File.OpenRead(@""));

            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                int i = 0;
                List<float> listA = new List<float>();
                while (i < 13)
                {                    
                    float x = float.Parse(values[i]);
                    listA.Add(x);
                    i++;
                }
                obj = new info(listA);
                l1.Add(obj);

                line = reader.ReadLine();
                values = line.Split(',');
                i = 0;
                List<float> listB = new List<float>();
                while (i < 13)
                {
                    float x = float.Parse(values[i]);
                    listB.Add(x);
                    i++;
                }
                info obj2 = new info(listB);
                l2.Add(obj2);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
