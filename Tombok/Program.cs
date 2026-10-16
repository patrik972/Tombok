namespace Tombok
{
    internal class Program
    {
        static string[] Torpok = new string[7];
        static void Torpok_letrehozasa()
        {
            Torpok[0] = "Szundi";
            Torpok[1] = "Szende";
            Torpok[2] = "Hapci";
            Torpok[3] = "Morgo";
            Torpok[4] = "Tudor";
            Torpok[5] = "Vidor";
            Torpok[6] = "Kuka";
        }
        static void Torpok_kiirasa()
        {
            Console.WriteLine($"A torpok lista elemeinek szama: {Torpok.Length}");
            for (int i = 0; i < Torpok.Length; i++)
            {
                Console.WriteLine(Torpok[i]);
            }
        }
        static void Csere()
        {
            Console.WriteLine("Melyik törpöt cseréljük le");
            string nev = Console.ReadLine();
            int index = 0;
            while(index < Torpok.Length && Torpok[index] != nev)
            {
                index++;
            }
            if(index < Torpok.Length)
            {
                Torpok[index] = nev;
                Console.WriteLine("Melyik törpre cseréljük le");
                string ujNev = Console.ReadLine();
                Console.WriteLine($"A {nev} nevű törpöt lecseréltük");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Nincs ilyen nevű törp");
            }
        }

        static void Main(string[] args)
        {
            Torpok_letrehozasa();
            Torpok_kiirasa();
            Csere();
        }
    }
}
