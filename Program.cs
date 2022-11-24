using System;

namespace MenuJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Olá seja bem-vindo ao serviço de jogos por assinatura DZATI");
            Console.WriteLine();
            Console.WriteLine("Para melhorar sua experiência selecione no menú abaixo o número correspondente ao seu console de interesse");
            Console.WriteLine();
            Console.WriteLine(" 1 - Playstation");
            Console.WriteLine(" 2 - Xbox");
            Console.WriteLine(" 3 - Nintendo");
           short res = short.Parse(Console.ReadLine());

            switch(res)
            {
                case 1: Playstation(); break;
                case 2: XBOX(); break;
                case 3: Nintendo(); break;
                default: Menu(); break;
            }

        }
       
       static void Playstation()
       {
            Console.WriteLine("_________________________________________________________________________________");
            Console.WriteLine("Esses são os jogos de playstation disponíveis em nossa plataforma!");
            Console.WriteLine("Demons Souls");
            Console.WriteLine("Ratchet & Clank: Em Uma Outra Dimensão");
            Console.WriteLine("SpiderMan");
            Console.WriteLine("God of War");
            Console.WriteLine("__________________________________________________________________________________");
       }

       static void XBOX()
       {
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("Esses são os jogos de XBOX disponíveis em nossa plataforma!");
            Console.WriteLine("Forza Horizon 5");
            Console.WriteLine("Halo Infinity");
            Console.WriteLine("Gears 5");
            Console.WriteLine("Sea of Thieves");
            Console.WriteLine("__________________________________________________________________________________");
       }

       static void Nintendo()
       {
             Console.WriteLine("__________________________________________________________________________________");
             Console.WriteLine("The legend of Zelda");
             Console.WriteLine("Pokemon Legens");
             Console.WriteLine("Captain Toad");
             Console.WriteLine("Mario Kart 8 Deluxe");
             Console.WriteLine("__________________________________________________________________________________");    


       }
            
    }

        
         

}

    