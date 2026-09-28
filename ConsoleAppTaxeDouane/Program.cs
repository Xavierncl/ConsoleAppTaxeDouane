namespace ConsoleAppTaxeDouane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le prix de l'article :");
            int prix = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez le numéro de la forge (1 Forges de la Capitale, 2 Ateliers des Nains des Montagnes, 3 Port des Contrebandiers, 4 Terres Sacrées du Temple):");
            int forge = Convert.ToInt32(Console.ReadLine());
            decimal taxe = 0.0m;

            if (forge == 1)
            {
                taxe = 0.2m;
            }
            else if (forge == 2)
            {
                taxe = 0.1m;
            }
            else if (forge == 3)
            {
                taxe = 0.055m;
            }
            else if (forge == 4)
            {
                taxe = 0.021m;
            }
            else
            {
                Console.WriteLine("Forge invalide");
                return;
            }
            decimal total = prix + (prix * taxe);
            Console.WriteLine("Le total est de " + total);

        }
    }
}
