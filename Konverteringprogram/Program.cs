
class Program
{
    static void Main()
    {
        Console.WriteLine("Velg en operasjon: ");
        while (true)
        {
        Console.WriteLine("1. Currency");
        Console.WriteLine("2. Temperatur");
        Console.WriteLine("3. Weight");

        string valg = Console.ReadLine();

        switch (valg)
        {
            case "1":
                convertCurrency();
                break;
            case "2":
                convertTemperatur();
                break;
            case "3":
                convertWeight();
                break;
            default:
                Console.WriteLine("Ugyldig tegn!");
                break;
        }
        }
    }

    static void convertCurrency()
    {
        Console.WriteLine("1. Konverter fra NOK til USD");
        Console.WriteLine("2. Konverter fra USD til NOK");

        string Valutaalternativ = Console.ReadLine(); 

        double valuta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Beløp: ");
        
        switch (Valutaalternativ)
        {
            case "1":
                double NOK = valuta * 0.093;
                Console.WriteLine ($"{valuta} Nok til USD er {NOK}" );
                break;
            case "2":
                double USD = valuta * 10.75; 
                Console.WriteLine ($"{valuta} USD til NOK er {USD}");  
                break;
            default:
                Console.WriteLine("Ugyldig beløp!");
                break;
        }
    }

    static void convertTemperatur()
    {
        Console.WriteLine("1. Konverter fra Celsius til Fahrenheit");
        Console.WriteLine("2. Konverter fra Fahrenheit til Celsius");

        string tempreaturalternativ = Console.ReadLine();

        double temperatur = Convert.ToDouble(Console.ReadLine());

        switch (tempreaturalternativ)
        {
            case "1":
                double celsius = (temperatur * 1.8000) + 32;
                Console.WriteLine($"{temperatur} fahrenheit er {celsius} celsius");
                break;
            case "2":
                double fahrenheit = (temperatur / 1.8000) -32;
                Console.WriteLine($"{temperatur} celsius er {fahrenheit} fahrenheit");
                break;
            default:
                Console.WriteLine("Ugyldig temperatur!");
                break;
        }
    }

    static void convertWeight()
    {
        Console.WriteLine("1. Konverter fra KG til pound");
        Console.WriteLine("2. Konverter fra pound til KG");

        string vektalternativ = Console.ReadLine();

        double vekt = Convert.ToDouble(Console.ReadLine());

        switch (vektalternativ)
        {
            case "1":
                double Pounds = vekt * 2.2046;
                Console.WriteLine($"{vekt} Pounds er {Pounds} Pounds");
                break;
            case "2":
                double KG = vekt / 2.2046;
                Console.WriteLine($"{vekt} KG er {KG} Pounds");
                break;
            default:
                Console.WriteLine("Ugyldig vekt!");
                break;
        }
    }
}