namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelcius(72);
            var faherenheit = TempConverter.CelciusToFahrenheit(30);

            Console.WriteLine("After the conversion, temperatures are the following:");
            Console.WriteLine($"celcius: {celcius}");
            Console.WriteLine($"fahrenheit: {faherenheit}");
        }
    }
}
