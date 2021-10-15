using System;
using System.Collections.Generic;
using System.Text;

namespace Bankamatic
{
    public abstract class Giris
    {
        string kadi, sifre, sfr = "b";


        public void grs()
        {
            

            Console.Write("Kullanıcı adını giriniz: ");
            kadi = Console.ReadLine();
            Console.Write("Kullanıcı şifresini giriniz: ");
            sifre = Console.ReadLine();
            Menu m = new Menu();
            if (kadi == "a" && sifre == sfr)
            {
                Console.Write("Kullanıcı girişi başarılıdır. \n");
                m.menü();
            }
            else
            {
                Console.Write("Kullanıcı girişi başarılı değildir. ");

            }





        }

        public void sifred()
            {
            Console.WriteLine("Değiştirlcek sifre gir ");
            sfr = Console.ReadLine();

            }




    }
}
