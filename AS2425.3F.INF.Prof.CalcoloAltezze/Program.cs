namespace AS2425._3F.INF.Prof.CalcoloAltezze
{
    internal class Program
    {
        /// <summary>
        /// Date una serie di altezze indicate dall'utente farne la somma e la media
        /// INPUT : n.ro di altezze, serie di altezze
        /// OUTPUT : Somma altezze e media altezze
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;28/10/24;Calcolo altezze con somma e media");

            Console.WriteLine("Digita il numero di altezze da inserire");
            int numeroAltezze = Convert.ToInt32(Console.ReadLine());

            // posiziono e dichiaro l'accumulatore (assolutamente nn dentro il ciclo !!!)
            double sommaAltezze = 0;

            for (int i = 0; i < numeroAltezze; i++)
            {

                Console.WriteLine($"Digita la {i+1} altezza  (mt)");
                double altezza = Convert.ToDouble(Console.ReadLine());

                sommaAltezze = sommaAltezze + altezza;
                // forma contratta
                //sommaAltezze += altezza;
            }

            // Output
            Console.WriteLine($"La somma delle altezze è {sommaAltezze} di {numeroAltezze}");
        }
    }
}
