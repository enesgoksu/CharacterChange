namespace CharacterChange.CharacterChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime veya cümle yazınız: ");
            string ifade = Console.ReadLine();
            string[] kelime = ifade.Split(' ');
            string[] kelimeler = new string[kelime.Length];
            
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i].Length <= 1)
                {
                    kelimeler[i] = kelime[i];
                }
                else
                {
                    char ilkharf = kelime[i][0];
                    char sonharf = kelime[i][kelime[i].Length - 1];
                    string yenikelimeler = sonharf + kelime[i].Substring(1,kelime[i].Length - 2) + ilkharf; kelimeler[i] = yenikelimeler;
                }

            }
                string output = string.Join(" ",kelimeler);
                Console.WriteLine(output);



        }
    }
}