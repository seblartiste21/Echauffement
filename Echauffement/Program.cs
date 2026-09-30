using System.Runtime.InteropServices.JavaScript;

namespace Echauffement;

class Program
{
    static void Main(string[] args)

    {

        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

        Console.WriteLine("bonjour je m'appelle sebastien et j'adore god of war ");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

        Console.WriteLine("Comment tu t'appelles ?");
        string playerName = Console.ReadLine();
        Console.WriteLine("Bonjour " + playerName + " !");

        Console.WriteLine("Quel âge as-tu ?");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        {
            Console.WriteLine("Tu es majeur.");
        }
        else
        {
            Console.WriteLine("Tu es mineur.");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("Combien d'euros as-tu ?");
        double money = double.Parse(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine();
        Console.WriteLine("=== MAGASIN D'ARMES ===");
        Console.WriteLine("1 - Épée : 50 euros");
        Console.WriteLine("2 - Arc : 75 euros");
        Console.WriteLine("3 - Fusil : 100 euros");
        Console.WriteLine("4 - Lance-roquettes : 150 euros");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Choisis une arme entre 1 et 4 :");
        int choix = int.Parse(Console.ReadLine());

        string arme = "";
        double prix = 0;

        if (choix == 1)
        {
            arme = "Épée";
            prix = 50;
        }
        else if (choix == 2)
        {
            arme = "Arc";
            prix = 75;
        }
        else if (choix == 3)
        {
            arme = "Fusil";
            prix = 100;
        }
        else if (choix == 4)
        {
            arme = "Lance-roquettes";
            prix = 150;
        }
        else
        {
            Console.WriteLine("Choix incorrect.");
            return;
        }

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}