namespace AS2324._3G.Guardabascio.Riccardo.Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire il numero di persone");
            int persone=Convert.ToInt32(Console.ReadLine());
            int[] eta=new int[persone];
            double[] pesi=new double[persone];
            CaricaVettori(ref pesi, ref eta);
            double media = 0, min = pesi[0], max = pesi[0], accumulatore = 0;
            Statistiche(ref pesi, ref media, ref min, ref max, ref accumulatore);
            Console.WriteLine($"La media dei pesi è: {media}, il peso minimo è: {min}, ed il peso massimo è: {max}");
        }

        static void CaricaVettori(ref double[] pesi, ref int[] eta)
        {
            Random random = new Random();
            for(int i=0; i<pesi.Length; i++)
            {
                pesi[i] = random.Next(50, 101);
                eta[i] = random.Next(18, 100);
            }
        }

        static void Statistiche(ref double[] pesi, ref double media, ref double min, ref double max, ref double accumulatore)
        {
            int i;
            for (i = 1; i < pesi.Length; i++)
            {
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                accumulatore += pesi[i];
            }
            media = accumulatore / i;
        }
    }
}
