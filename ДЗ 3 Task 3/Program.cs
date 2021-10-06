using System;

class Converter {
    public Converter(double dollar, double euro) {
        this.dollar = dollar;
        this.euro = euro;
    }
    double dollar, euro;

    public double dollar2hrv(double d) {
        return d * dollar;
    }
    public double euro2hrv(double e) {
        return e * euro;
    }
    public double hrv2dollar(double h) {
        return h / dollar;
    }
    public double hrv2euro(double h) {
        return h / euro;
    }

}
namespace ДЗ_2__Task_3_
{

    class Program
    {
        static void Main(string[] args)
        {
            Converter C = new Converter(28, 32.5);
            Console.WriteLine(C.dollar2hrv(5));
            Console.WriteLine(C.euro2hrv(7));
            Console.WriteLine(C.hrv2euro(137));
        }
    }
}
