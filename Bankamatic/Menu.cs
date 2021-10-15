using System;
using System.Collections.Generic;
using System.Text;

namespace Bankamatic
{
    public class Menu:Bankaİslemleri
    {
        public void bosluk()
        {

            Console.WriteLine("------------------");


        }




        public void menü()
        {
            Bankaİslemleri bnk = new Bankaİslemleri();
            bosluk();
            Console.WriteLine(" 1 - Para çekme");
            Console.WriteLine(" 2 - Para Yatırma");
            Console.WriteLine(" 3 - Bakiye Sorgulama");
            Console.WriteLine(" 4 - Hesap Bilgileri Değiştir");
            Console.WriteLine(" 5 - Kart İade");
            bosluk();

            int menusecim;

            menusecim = int.Parse(Console.ReadLine());

            switch (menusecim)
            {
                case 1:
                    bnk.paracek();
                    break;
                case 2:
                    bnk.parayatir();
                    break;
                case 3:
                    
                    bnk.bakiye();
                    break;
                case 4:
                    sifred();
                    break;
                case 5:
                    Console.WriteLine("çıkış yapılıyo");
                    break;
                default:
                    Console.WriteLine("Değerler arası gir");
                    break;
            }
            while (menusecim=5)
            {

            }




        }
    }
}
