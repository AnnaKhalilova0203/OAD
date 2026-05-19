namespace ConsoleApp1;

public class RabatStaly:IRabat
{

   private double kwotaRabatu;
   public RabatStaly(double kwotaRabatu)
   {
       this.kwotaRabatu = kwotaRabatu;
   }

   public double Oblicz(double kwota)
   {
       double wynik = kwota - kwotaRabatu;
       if (wynik < 0)
       {
           return 0;
       }
       return wynik;
   }
}