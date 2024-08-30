using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOn40
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<inimine> inimesed = new List<inimine>();
            inimine inimine1 = new inimine();
            inimine1.Nimi = "Pjotr 1";
            inimine1.Vanus = 130;
            inimine inimine2 = new inimine("Jelisaveta");
            inimine2.Vanus = 98;
            inimine inimine3 = new inimine("Roman");
            inimine3.Vanus = 19;
            inimesed.Add(inimine1);
            inimesed.Add(inimine2);
            inimesed.Add(inimine3);
            inimesed.Add(new inimine("Lesha", 18));
            foreach (inimine inimine in inimesed)
            {
                Console.WriteLine(inimine.Nimi + " on" + inimine.Vanus + "aasta vana");
            }
                  



            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Esimene");
            //arrayList.Add("Teine");
            //arrayList.Add("Kolmas");
            //Console.WriteLine("Osting: ")
            //string vas=Console.ReadLine();
            //if (vas !=null && arrayList.Contains(vas))
            //{
            //    Console.WriteLine("Otsistav element asub " + arrayList.IndexOf(vas) + "kohal";
            //}
            //else
            //{
            //    Console.WriteLine("Kokku oli " + arrayList.Count + " elemente, vaid otsitav puudub");
            //}

            //arrayList.Clear();



            //1

            //listid ja sõnastikud

            List<string> ABC = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\ABC.txt"))
                {
                    ABC.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fail, ei sa");
            }
            foreach (string e in ABC)
            {
                Console.WriteLine(e);
            }



        }
    }
}