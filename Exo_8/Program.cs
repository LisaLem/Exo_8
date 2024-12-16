internal class Program
{
    static void Main(string[] args)
    {
        //int taille;
        //int poids;

        Console.WriteLine("--- Quelle taille dois-je prendre ? ---\n");

        Console.Write("Entrez votre taille (en cm) : ");
        int tailleEntree = int.Parse(Console.ReadLine());

        Console.Write("Entrez votre poids (en kg) : ");
        int poidsEntre = int.Parse(Console.ReadLine());

        if (tailleEntree >= 145 && tailleEntree <= 169 && poidsEntre >= 43 && poidsEntre <= 47)
        {
            Console.WriteLine("\nPrenez la taille 1.");
        }
        else if (tailleEntree >= 145 && tailleEntree <= 166 && poidsEntre >= 48 && poidsEntre <= 53)
        {
            Console.WriteLine("\nPrenez la taille 1.");
        }
        else if (tailleEntree >= 145 && tailleEntree <= 163 && poidsEntre >= 54 && poidsEntre <= 59)
        {
            Console.WriteLine("\nPrenez la taille 1.");
        }
        else if (tailleEntree >= 145 && tailleEntree <= 160 && poidsEntre >= 60 && poidsEntre <= 65)
        {
            Console.WriteLine("\nPrenez la taille 1.");
        }
        else if (tailleEntree >= 169 && tailleEntree <= 178 && poidsEntre >= 48 && poidsEntre <= 53)
        {
            Console.WriteLine("\nPrenez la taille 2.");
        }
        else if (tailleEntree >= 166 && tailleEntree <= 175 && poidsEntre >= 54 && poidsEntre <= 59)
        {
            Console.WriteLine("\nPrenez la taille 2.");
        }
        else if (tailleEntree >= 163 && tailleEntree <= 172 && poidsEntre >= 60 && poidsEntre <= 65)
        {
            Console.WriteLine("\nPrenez la taille 2.");
        }
        else if (tailleEntree >= 160 && tailleEntree <= 169 && poidsEntre >= 66 && poidsEntre <= 71)
        {
            Console.WriteLine("\nPrenez la taille 2.");
        }
        else if (tailleEntree >= 178 && tailleEntree <= 183 && poidsEntre >= 54 && poidsEntre <= 59)
        {
            Console.WriteLine("\nPrenez la taille 3.");
        }
        else if (tailleEntree >= 175 && tailleEntree <= 183 && poidsEntre >= 60 && poidsEntre <= 65)
        {
            Console.WriteLine("\nPrenez la taille 3.");
        }
        else if (tailleEntree >= 172 && tailleEntree <= 183 && poidsEntre >= 66 && poidsEntre <= 71)
        {
            Console.WriteLine("\nPrenez la taille 3.");
        }
        else if (tailleEntree >= 163 && tailleEntree <= 183 && poidsEntre >= 72 && poidsEntre <= 77)
        {
            Console.WriteLine("\nPrenez la taille 3.");
        } else
        {
            Console.WriteLine("\nPas de taille correspondante disponible.");
        }
    }
}

