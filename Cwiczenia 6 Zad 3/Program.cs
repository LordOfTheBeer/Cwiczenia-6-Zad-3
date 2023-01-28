namespace Cwiczenia_6_Zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "mars";
            string tekst2 = "";

            for (int i = tekst.Length - 1; i >= 0; i--)
                tekst2 += tekst[i];

            Console.WriteLine(tekst2);


        }
    }
}