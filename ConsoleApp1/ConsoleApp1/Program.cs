namespace ConsoleApp1
{
   public class Program
   {
      static void Main(string[] args)
      {
         double cena = PobierzCene();
         int wybor = PobierzWybor();
         IRabat rabat = WybierzRabat(wybor);
         double NowaCena = rabat.Oblicz(cena);
         WyswietlWynik(NowaCena);
      }

      static double PobierzCene()
      {
         double cena;
         while (true)
         {
            Console.Write("podaj cene produktu: ");
            if (double.TryParse(Console.ReadLine(), out cena )&&cena >= 0)
            {
               return cena;
            }
            Console.WriteLine("BŁĘDNA WARTOŚĆ SPRÓBUJ PONOWNIE");
         }
      }

      static void WyswietMenu()
      {
         Console.WriteLine("\n WYBIERZ RABAT");
         Console.WriteLine("1-brak rabatu");
         Console.WriteLine("2-rabat 10%");
         Console.WriteLine("3-rabat 20 zł");
      }

      static void PobierzWybor()
      {
         int wybor;
         while (true)
         {
            WyswietMenu();
            Console.Write("Twój wybór: ");
            if (int.TryParse(Console.ReadLine(), out wybor) && wybor >= 1 && wybor <= 3)
            {
               return wybor;
               
            }
            Console.WriteLine("Błędna wartość, spróbuj ponownie");
         }
      }

      static IRabat WybierzRabat(int wybor)
      {
         switch (wybor)
         {
            case 1:
               return new BrakRabatu();
            case 2:
               return new RabatProcentowy(0.10);
            case 3:
               return new RabatStaly(20);
            default:
               return new BrakRabatu();
         }
        
      }

      static void WyswietlWynik(double wynik)
      {
         Console.WriteLine($"\n Cena po rabacie: {wynik}zł");
      }
   }
}