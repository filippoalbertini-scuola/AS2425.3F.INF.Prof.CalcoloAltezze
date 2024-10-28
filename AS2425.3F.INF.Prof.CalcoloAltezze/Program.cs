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
            string? s = Console.ReadLine();
            int numeroAltezze = 0;

            

            if (int.TryParse(s, out numeroAltezze) == false)
            {
                Console.WriteLine("Numero inserito non corretto");
                return;
            }

            if (numeroAltezze < 0)
            {
                Console.WriteLine("Non possono essere accettati numeri negativi");
                return;
            }


            // posiziono e dichiaro l'accumulatore (assolutamente nn dentro il ciclo !!!)
            double sommaAltezze = 0;

            for (int i = 0; i < numeroAltezze; i++)
            {

                Console.WriteLine($"Digita l'altezza n.ro {i+1} in (mt)");
                double altezza = Convert.ToDouble(Console.ReadLine());

                sommaAltezze = sommaAltezze + altezza;
                // forma contratta
                //sommaAltezze += altezza;
            }

            // Output

            Console.WriteLine($"La somma delle altezze è {sommaAltezze} di {numeroAltezze}");
            Console.WriteLine($"La media delle altezze è {sommaAltezze / numeroAltezze}");
        }
    }
}
