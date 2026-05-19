namespace ConsoleApp1;

public class RabatProcentowy: IRabat
{
    private double procent;
    public RabatProcentowy(double procent)
    {this.procent = procent;}

    public double Oblicz(double kwota)
    {
        double wynik = kwota - (kwota * procent);
        if (wynik < 0) return 0;
        return wynik;
    }
}