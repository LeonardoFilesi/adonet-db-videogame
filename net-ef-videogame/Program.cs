namespace net_ef_videogame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto nel nostro sistema di gestione del catalogo videogiochi");
            Console.WriteLine("Seleziona l'opzione desiderata:");
            Console.WriteLine(@"
            - 1: inserire un nuovo videogioco
            - 2: ricercare un videogioco per id
            - 3: ricercare tutti i videogiochi aventi il nome contenente una determinata stringa inserita in input
            - 4: cancellare un videogioco
            - 5: chiudere il programma
            ");

            int selectedOption = int.Parse(Console.ReadLine());

            switch (selectedOption)
            {
                case 1:
            }
        }
    }
}