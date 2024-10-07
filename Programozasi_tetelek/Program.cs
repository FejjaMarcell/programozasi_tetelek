namespace Programozasi_tetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            /*Egy héten keresztül minden nap egyszer mérjük a hőmérsékletet.
             (Hőmérsékleteket random generáljuk -5 és 10 fpk között).
            Döntsük el, hogy fagyott-e a héten!*/

            /*
            Random rnd = new Random();
            int[] homerseklet = new int[7];
            for (int i = 0; i < homerseklet.Length; i++)
            {
                homerseklet[i] = rnd.Next(-5, 11);
                Console.Write($"{homerseklet[i]}°C ");
            }

            int j = 0;
            while (j < 7 && !(homerseklet[j] <= 0))
            {
                j++;
            }
            Console.WriteLine();
            Console.WriteLine(j < 7?"Fagyott a héten!":"Nem fagyott a héten!");
            */

            /*Beolvassuk egy tanúló évvégi jegyeit, összesen 8-at, csak létező jegyeket
             fogadjuk el 1 és 5 között. Bukott-e? (ha már egy tárgyból 1-se van, akkor bukott)*/

            /*
            int[] jegyek = new int[8];
            int jegy = 0;
            for (int i = 0; i < jegyek.Length; i++)
            {
                do
                {
                    Console.WriteLine("Add meg az évvégi jegyeidet!");
                    jegy = int.Parse(Console.ReadLine());
                } while (jegy < 1 || jegy > 5);
                jegyek[i] = jegy;
            }

            int j = 0;
            while (j < 8 && !(jegyek[j] == 1))
            {
                j++;
            }
            Console.WriteLine(j < 8?"Meg bukott!":"Nem bukott meg!");

            //Döntsük el, hogy kitűnő-e a tanuló (minden jegy 5-ös)

            int k = 0;
            while (k < 8 && !(jegyek[k] != 5))
            {
                k++;
            }
            Console.WriteLine(k < 8 ? "Nem kitűnő!" : "Kitűnő!");
            */

            /* Töltsünk fel egy 20 elemű listát véletlenszamokkal 0 és 100 között.
             * Van-e négyzetszám a listában?*/

            /*
            int[] szamok = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(0, 101);
                Console.WriteLine($"{szamok[i]} - {Math.Sqrt(szamok[i])}");
            }

            int j = 0;
            while (j < szamok.Length && !int.TryParse(Math.Sqrt(szamok[j]).ToString(), out int result))
            {
                j++;
            }
            Console.WriteLine(j < szamok.Length ? "Van benne!" : "Nincs benne!");
            */

            
            Random r = new Random();
            List<double> lista = new List<double>();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(0, 101));
                Console.Write($"{lista[i]} ");
            }
            int index3 = 0;
            while (index3 < lista.Count && !(int.TryParse(Math.Sqrt(lista[index3]).ToString(), out int result)))
            {
                index3++;
            }
            Console.WriteLine(index3 < lista.Count ? $"Van négyzetszám {lista[index3]}":"Nincs négyzetszám");
            
        }
    }
}
