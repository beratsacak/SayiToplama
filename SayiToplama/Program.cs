using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiToplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İslem islem = new İslem();
            double sonuc =islem.Topla(45,45,85,54,785,485,485);
            Console.WriteLine(sonuc);
        }
    }
    public class İslem
    {
        public double Topla(params double[] sayilar)
        {
            double toplam = 0;
            foreach (var t in sayilar)
            {
                toplam += t;
            }
            return toplam;
        }
    }
}
