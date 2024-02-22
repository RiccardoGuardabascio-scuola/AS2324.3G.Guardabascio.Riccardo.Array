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
    }
}
