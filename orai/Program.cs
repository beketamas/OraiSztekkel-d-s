namespace orai
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> zaroJelek = [.. File.ReadAllLines("input.txt")];

            //Console.WriteLine($"1. feladat: {zaroJelek.Count(x => (!x.StartsWith(')') && !x.EndsWith('(')) && x.Count(y => y == '(') == x.Count(y => y == ')'))}");


            int l = 0;
            zaroJelek.ForEach(z =>
            {
                if (Valami(z))
                    l++;
            });
            Console.WriteLine($"1. feladat: {l}");

            Console.WriteLine($"2. feladat: {"))((".isValid()}");
            

            List<People> emberek = File.ReadLines("people.csv").Select(x => new People(x)).ToList();
            Console.WriteLine($"Legfiatalabb személy: \n" +
                $"{emberek.MinBy(x => x.GetEletkor).FirstName} {emberek.MinBy(x => x.GetEletkor).LastName}, {emberek.MinBy(x => x.GetEletkor).GetEletkor} éves\n");
            Console.WriteLine($"Legidősebb személy: \n" +
                $"{emberek.MaxBy(x => x.GetEletkor).FirstName} {emberek.MaxBy(x => x.GetEletkor).LastName}, {emberek.MaxBy(x => x.GetEletkor).GetEletkor} éves\n");
            Console.WriteLine($"A fájlban szereplő személyek átlagos életkora {String.Format("{0:F2}", (double)emberek.Sum(x => x.GetEletkor) / (double)emberek.Count).Replace(',','.')}");

            List<Dogs> kutyak = File.ReadLines("dogs.csv").Select(x => new Dogs(x)).ToList();

            emberek.ForEach(x =>
            {
                kutyak.Where(kutya => kutya.Owner_id == x.Id).ToList().ForEach(m => x.listaTolt(m));
            });
            Console.WriteLine();
            Console.WriteLine($"4. feladat: {emberek.MaxBy(x => x.ListaKutyak.Count).FirstName} {emberek.MaxBy(x => x.ListaKutyak.Count).LastName} has " +
                $"{emberek.MaxBy(x => x.ListaKutyak.Count).ListaKutyak.Count} dogs");
        }

        public static bool Valami(string z)
        {
            var stack = new Stack<string>();
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] == '(')
                    stack.Push(z[i].ToString());
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception)
                    {

                       return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;

            return false;


        }

    }
}
