class Program
{
    static void Main()
    {
        int gamyProVyhruSetu = 6;  
        int setyProVyhruZapasu = 2;
        
        int bodyHracA = 0;
        int bodyHracB = 0;
        
        int gamyHracA = 0;
        int gamyHracB = 0;
        
        int setyHracA = 0;
        int setyHracB = 0;
        
        bool maVyhoduA = false;
        bool maVyhoduB = false;

        while (true)
        {
            Console.Clear();
            
            Console.WriteLine(" ** Tenisovy zapas ** ");
            Console.WriteLine();
            
            Console.Write("SETY: ");
            Console.Write(setyHracA);
            Console.Write(" - ");
            Console.WriteLine(setyHracB);
            
            Console.Write("GAMY: ");
            Console.Write(gamyHracA);
            Console.Write(" - ");
            Console.WriteLine(gamyHracB);
            
            Console.Write("BODY: ");
            
            if (maVyhoduA == true)
            {
                Console.Write("A"); 
            }
            else if (bodyHracA == 0)
            {
                Console.Write("0");
            }
            else if (bodyHracA == 1)
            {
                Console.Write("15");
            }
            else if (bodyHracA == 2)
            {
                Console.Write("30");
            }
            else if (bodyHracA == 3)
            {
                Console.Write("40");
            }
            
            Console.Write(" - ");
            
            if (maVyhoduB == true)
            {
                Console.Write("A"); 
            }
            else if (bodyHracB == 0)
            {
                Console.Write("0");
            }
            else if (bodyHracB == 1)
            {
                Console.Write("15");
            }
            else if (bodyHracB == 2)
            {
                Console.Write("30");
            }
            else if (bodyHracB == 3)
            {
                Console.Write("40");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            
            Console.Write("Kdo ziskal bod? (a/b): ");
            string odpoved = Console.ReadLine();
            
            if (odpoved == "a")
            {
                bodyHracA = bodyHracA + 1;
            }
            else if (odpoved == "b")
            {
                bodyHracB = bodyHracB + 1;
            }
            else
            {
                Console.WriteLine("CHYBA! Musis napsat 'a' nebo 'b'!");
                Console.WriteLine("Zmackni ENTER a zkus to znovu...");
                Console.ReadLine();
                continue; 
            }
            
            
            if (maVyhoduA == true && bodyHracA == 4)
            {
                gamyHracA = gamyHracA + 1;
                bodyHracA = 0;
                bodyHracB = 0;
                maVyhoduA = false;
                maVyhoduB = false;
            }
            else if (maVyhoduB == true && bodyHracB == 4)
            {
                gamyHracB = gamyHracB + 1;
                bodyHracA = 0;
                bodyHracB = 0;
                maVyhoduA = false;
                maVyhoduB = false;
            }
            else if (maVyhoduA == true && bodyHracB == 4)
            {
                maVyhoduA = false;
                maVyhoduB = false;
                bodyHracA = 3; 
                bodyHracB = 3; 
            }
            else if (maVyhoduB == true && bodyHracA == 4)
            {
                maVyhoduA = false;
                maVyhoduB = false;
                bodyHracA = 3; 
                bodyHracB = 3; 
            }
            else if (bodyHracA == 4 && bodyHracB == 3 && maVyhoduA == false && maVyhoduB == false)
            {
                maVyhoduA = true;
                bodyHracA = 3;
            }
            else if (bodyHracB == 4 && bodyHracA == 3 && maVyhoduA == false && maVyhoduB == false)
            {
                maVyhoduB = true;
                bodyHracB = 3; 
            }
            else if (bodyHracA >= 4 && bodyHracB < 3)
            {
                gamyHracA = gamyHracA + 1;
                bodyHracA = 0;
                bodyHracB = 0;
                maVyhoduA = false;
                maVyhoduB = false;
            }
            else if (bodyHracB >= 4 && bodyHracA < 3)
            {
                gamyHracB = gamyHracB + 1;
                bodyHracA = 0;
                bodyHracB = 0;
                maVyhoduA = false;
                maVyhoduB = false;
            }
            
            if (gamyHracA >= gamyProVyhruSetu)
            {
                setyHracA = setyHracA + 1;
                gamyHracA = 0;
                gamyHracB = 0;
            }
            else if (gamyHracB >= gamyProVyhruSetu)
            {
                setyHracB = setyHracB + 1;
                gamyHracA = 0;
                gamyHracB = 0;
            }
            
            if (setyHracA >= setyProVyhruZapasu)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("   HRAC A VYHRAL ZAPAS!");
                Console.WriteLine("================================");
                Console.WriteLine();
                Console.WriteLine("Konecne skore:");
                Console.WriteLine("SETY: " + setyHracA + " - " + setyHracB);
                Console.WriteLine("GAMY: " + gamyHracA + " - " + gamyHracB);
                Console.WriteLine();
                Console.WriteLine("Gratulujeme hraci A!");
                Console.WriteLine();
                Console.WriteLine("Zmackni ENTER pro ukonceni...");
                Console.ReadLine();
                break; 
            }
            else if (setyHracB >= setyProVyhruZapasu)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("   HRAC B VYHRAL ZAPAS!");
                Console.WriteLine("================================");
                Console.WriteLine();
                Console.WriteLine("Konecne skore:");
                Console.WriteLine("SETY: " + setyHracA + " - " + setyHracB);
                Console.WriteLine("GAMY: " + gamyHracA + " - " + gamyHracB);
                Console.WriteLine();
                Console.WriteLine("Gratulujeme hraci B!");
                Console.WriteLine();
                Console.WriteLine("Zmackni ENTER pro ukonceni...");
                Console.ReadLine();
                break; 
            }
        }
    }
}