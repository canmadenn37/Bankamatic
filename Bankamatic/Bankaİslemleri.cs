using System;
using System.Collections.Generic;
using System.Text;

namespace Bankamatic
{
    public  class Bankaİslemleri:Giris
    {

        int Bakiye=5000;
        int prcek;
        int prytr;

        public void paracek() 
        {
            Console.WriteLine("Çekilcek tuturı Giriniz!!!! ");
            prcek = int.Parse(Console.ReadLine());
            Bakiye = Bakiye - prcek;
            Console.WriteLine(Bakiye);


        }
        public void parayatir()
        {
            Console.WriteLine("Yatırılcak tutar giriniz !!!");
            prytr = int.Parse(Console.ReadLine());
            Bakiye = Bakiye + prytr;
            Console.WriteLine(Bakiye);


        }
        public void bakiye()
        {
            Console.WriteLine(Bakiye);


        }

       


    }
}
