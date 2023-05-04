//START MENU

Insult("Micke");


while (true)
{



    Console.Clear();
    string choice = "";
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"

                ░█▀▀█ █▀▀▀ █▀▀▀ █▀▀█ █▀▀ █▀▀ ░▀░ ▀█░█▀ █▀▀ 　 ▒█▀▀▀ █▀▀▄ █▀▀ █▀▀█ █░░█ █▀▀▄ ▀▀█▀▀ █▀▀ █▀▀█ 
                ▒█▄▄█ █░▀█ █░▀█ █▄▄▀ █▀▀ ▀▀█ ▀█▀ ░█▄█░ █▀▀ 　 ▒█▀▀▀ █░░█ █░░ █░░█ █░░█ █░░█ ░░█░░ █▀▀ █▄▄▀ 
                ▒█░▒█ ▀▀▀▀ ▀▀▀▀ ▀░▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ░░▀░░ ▀▀▀ 　 ▒█▄▄▄ ▀░░▀ ▀▀▀ ▀▀▀▀ ░▀▀▀ ▀░░▀ ░░▀░░ ▀▀▀ ▀░▀▀ 

                                        ▀▀█▀▀ █░░█ █▀▀ 　 █▀▀▀ █▀▀█ █▀▄▀█ █▀▀ 
                                        ░░█░░ █▀▀█ █▀▀ 　 █░▀█ █▄▄█ █░▀░█ █▀▀ 
                                        ░░▀░░ ▀░░▀ ▀▀▀ 　 ▀▀▀▀ ▀░░▀ ▀░░░▀ ▀▀▀");
    Console.WriteLine();
    Console.WriteLine();
    //Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("                                          Press a key to start the game");
    Console.WriteLine("                                                        or");
    Console.WriteLine("                                            Press Q to quit the game");
    Console.ForegroundColor = ConsoleColor.White;

    AskQuit();



    //------------------------------------------------------------------------------





    Console.Clear();
    Console.WriteLine("Du råkar gå in i en person påvägen till skolan, han blir extremt arg och vill slåss, vad gör du? Försöker du prata med honom eller börjar du slåss?");
    Console.WriteLine();
    Console.WriteLine("   Alternativ:   [Slåss]   [Prata med honom]   [???]");
    choice = GetInput(new string[] { "slåss", "3", "1", "2", "prata med honom" });


    // Här under så beskrivs vad som händer om du väljer ett av alternativen som nämndes ovan
    // Om man väljer 3 så händer det här
    if (choice == "3")
    {
        Console.Clear();
        Console.WriteLine("Du gick nyss in en person och han är extremt arg, men det enda du har i tanken är ett gammalt fickur som ligger på marken framför dig.");
        Console.WriteLine("Du plockar upp den och märker att tiden på den är ställd för långt fram, du försöker därför att ändra tillbaka till den rätta tiden.");
        Console.WriteLine("Helt plötsligt så märker du hur allting runtomkring dig börjar gå bakåt och efter ett tag så börjar du få deja vu, du har åkt bak i tiden!");
        Console.WriteLine("Du kommer ihåg att du nyss hade gått in i någon, men den här gången så undviker du personen och nu hände inget från första början");
        Watch();
        Console.ReadLine();
        Secretending();
        Console.ReadLine();

    }

    // Om man väljer 1 eller slåss så händer det här
    if (choice == "slåss" || choice == "1")
    {
        Console.Clear();
        Difficulty();
        Difficultychoice();
        Console.WriteLine();
        Console.WriteLine();



        choice = GetInput(new string[] { "1", "2", "3" });
        int intchoice;
        int.TryParse(choice, out intchoice);

        if (intchoice == 1)
        {
            Console.Clear();
            Console.WriteLine(@"
        █▄█ █▀█ █░█   █░█ ▄▀█ █░█ █▀▀   █▀▀ █░█ █▀█ █▀ █▀▀ █▄░█   █▀▄ █ █▀▀ █▀▀ █ █▀▀ █░█ █░░ ▀█▀ █▄█   ▄█
        ░█░ █▄█ █▄█   █▀█ █▀█ ▀▄▀ ██▄   █▄▄ █▀█ █▄█ ▄█ ██▄ █░▀█   █▄▀ █ █▀░ █▀░ █ █▄▄ █▄█ █▄▄ ░█░ ░█░   ░█

                    █▀█ █▀█ █▀▀ █▀ █▀   ▄▀█ █▄░█ █▄█   █▄▀ █▀▀ █▄█   ▀█▀ █▀█   █▀ ▀█▀ ▄▀█ █▀█ ▀█▀
                    █▀▀ █▀▄ ██▄ ▄█ ▄█   █▀█ █░▀█ ░█░   █░█ ██▄ ░█░   ░█░ █▄█   ▄█ ░█░ █▀█ █▀▄ ░█░
        ");

            Console.ReadKey();
            int hp = 100;
            int enemyhp = 100;

            Random namegenerator = new Random();
            int i = namegenerator.Next(6);
            string[] names = { "Edvin", "Suren", "Tin", "Tommi", "John", "Samuel" };
            string player = "Du";
            string enemyname = names[i];


            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine($"                                     Din motståndares namn är {enemyname}");
            Console.ReadLine();
            Console.Clear();



            while (hp > 0 && enemyhp > 0)
            {
                Console.Clear();
                Console.WriteLine(@"
            
        ███████████████████████████████████████████████████████████
        █▄─▀█▄─▄█▄─▄▄─█▄─█▀▀▀█─▄███▄─▄▄▀█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
        ██─█▄▀─███─▄█▀██─█─█─█─█████─▄─▄█─██─██─██─███─█▄▀─███─██─█
        ▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀
        ");

                Console.WriteLine($"{player} har {hp} hp    {enemyname} har {enemyhp} hp");

                Console.ReadKey();
                int playerdmg = generator.Next(30);
                enemyhp -= playerdmg;
                enemyhp = Math.Max(0, enemyhp);
                Console.WriteLine($"{player} gjorde {playerdmg} damage på {enemyname}");

                int enemydmg = generator.Next(30);
                hp -= enemydmg;
                hp = Math.Max(0, hp);
                Console.WriteLine($"{enemyname} gör {enemydmg} damage på dig");

                Console.WriteLine("För att fortsätta, tryck på en valfri knapp");
                Console.ReadKey();

            }



            if (enemyhp == 0 && hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Både {player} och {enemyname} har 0 hp, oavgjort ");

                Console.ReadLine();


            }
            else if (hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Ditt hp är 0, {enemyname} vann");

                Console.ReadLine();

            }
            else if (enemyhp == 0)
            {
                Console.Clear();
                Console.WriteLine($"{enemyname}'s hp är 0, {player} vann");

                Console.ReadLine();

            }
            Console.ReadLine();
        }

        else if (intchoice == 2)
        {
            Console.Clear();
            Console.WriteLine(@"
        █▄█ █▀█ █░█   █░█ ▄▀█ █░█ █▀▀   █▀▀ █░█ █▀█ █▀ █▀▀ █▄░█   █▀▄ █ █▀▀ █▀▀ █ █▀▀ █░█ █░░ ▀█▀ █▄█   ▀█
        ░█░ █▄█ █▄█   █▀█ █▀█ ▀▄▀ ██▄   █▄▄ █▀█ █▄█ ▄█ ██▄ █░▀█   █▄▀ █ █▀░ █▀░ █ █▄▄ █▄█ █▄▄ ░█░ ░█░   █▄

                    █▀█ █▀█ █▀▀ █▀ █▀   ▄▀█ █▄░█ █▄█   █▄▀ █▀▀ █▄█   ▀█▀ █▀█   █▀ ▀█▀ ▄▀█ █▀█ ▀█▀
                    █▀▀ █▀▄ ██▄ ▄█ ▄█   █▀█ █░▀█ ░█░   █░█ ██▄ ░█░   ░█░ █▄█   ▄█ ░█░ █▀█ █▀▄ ░█░");

            Console.ReadKey();
            int hp = 100;
            int enemyhp = 125;

            Random namegenerator = new Random();
            int i = namegenerator.Next(6);
            string[] names = { "Edvin", "Suren", "Tin", "Tommi", "John", "Samuel" };
            string player = "Du";
            string enemyname = names[i];


            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine($"                                     Din motståndares namn är {enemyname}");
            Console.ReadLine();
            Console.Clear();



            while (hp > 0 && enemyhp > 0)
            {
                Console.Clear();
                Console.WriteLine(@"
            
        ███████████████████████████████████████████████████████████
        █▄─▀█▄─▄█▄─▄▄─█▄─█▀▀▀█─▄███▄─▄▄▀█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
        ██─█▄▀─███─▄█▀██─█─█─█─█████─▄─▄█─██─██─██─███─█▄▀─███─██─█
        ▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀
        ");

                Console.WriteLine($"{player} har {hp} hp    {enemyname} har {enemyhp} hp");

                Console.ReadKey();
                int playerdmg = generator.Next(35);
                enemyhp -= playerdmg;
                enemyhp = Math.Max(0, enemyhp);
                Console.WriteLine($"{player} gjorde {playerdmg} damage på {enemyname}");

                int fiendedmg = generator.Next(30);
                hp -= fiendedmg;
                hp = Math.Max(0, hp);
                Console.WriteLine($"{enemyname} gör {fiendedmg} damage på dig");

                Console.WriteLine("För att fortsätta, tryck på en valfri knapp");
                Console.ReadKey();

            }



            if (enemyhp == 0 && hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Både {player} och {enemyname} har 0 hp, oavgjort ");

                Console.ReadLine();


            }
            else if (hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Ditt hp är 0, {enemyname} vann");

                Console.ReadLine();

            }
            else if (enemyhp == 0)
            {
                Console.Clear();
                Console.WriteLine($"{enemyname}'s hp är 0, {player} vann");

                Console.ReadLine();

            }

            Console.ReadLine();
        }

        else if (intchoice == 3)
        {
            Console.Clear();
            Console.WriteLine(@"
          █▄█ █▀█ █░█   █░█ ▄▀█ █░█ █▀▀   █▀▀ █░█ █▀█ █▀ █▀▀ █▄░█   ▀█▀ █░█ █▀▀   █░█ ▄▀█ █▀█ █▀▄ █▀▀ █▀ ▀█▀  
          ░█░ █▄█ █▄█   █▀█ █▀█ ▀▄▀ ██▄   █▄▄ █▀█ █▄█ ▄█ ██▄ █░▀█   ░█░ █▀█ ██▄   █▀█ █▀█ █▀▄ █▄▀ ██▄ ▄█ ░█░  

  █▀▄ █ █▀▀ █▀▀ █ █▀▀ █░█ █░░ ▀█▀ █▄█   █▀█ █▀█ █▀▀ █▀ █▀   ▄▀█ █▄░█ █▄█   █▄▀ █▀▀ █▄█   ▀█▀ █▀█   █▀ ▀█▀ ▄▀█ █▀█ ▀█▀
  █▄▀ █ █▀░ █▀░ █ █▄▄ █▄█ █▄▄ ░█░ ░█░   █▀▀ █▀▄ ██▄ ▄█ ▄█   █▀█ █░▀█ ░█░   █░█ ██▄ ░█░   ░█░ █▄█   ▄█ ░█░ █▀█ █▀▄ ░█░");

            Console.ReadKey();
            int hp = 100;
            int enemyhp = 150;

            Random namegenerator = new Random();
            int i = namegenerator.Next(6);
            string[] names = { "Edvin", "Suren", "Tin", "Tommi", "John", "Samuel" };
            string player = "Du";
            string enemyname = names[i];


            Random generator = new Random();

            Console.WriteLine();
            Console.WriteLine($"                                     Din motståndares namn är {enemyname}");
            Console.ReadLine();
            Console.Clear();



            while (hp > 0 && enemyhp > 0)
            {
                Console.Clear();
                Console.WriteLine(@"
            
        ███████████████████████████████████████████████████████████
        █▄─▀█▄─▄█▄─▄▄─█▄─█▀▀▀█─▄███▄─▄▄▀█─▄▄─█▄─██─▄█▄─▀█▄─▄█▄─▄▄▀█
        ██─█▄▀─███─▄█▀██─█─█─█─█████─▄─▄█─██─██─██─███─█▄▀─███─██─█
        ▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▄▄▄▀▀▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▄▄▀▀
        ");

                Console.WriteLine($"{player} har {hp} hp    {enemyname} har {enemyhp} hp");

                Console.ReadKey();
                int playerdmg = generator.Next(40);
                enemyhp -= playerdmg;
                enemyhp = Math.Max(0, enemyhp);
                Console.WriteLine($"{player} gjorde {playerdmg} damage på {enemyname}");

                int enemydmg = generator.Next(30);
                hp -= enemydmg;
                hp = Math.Max(0, hp);
                Console.WriteLine($"{enemyname} gör {enemydmg} damage på dig");

                Console.WriteLine("För att fortsätta, tryck på en valfri knapp");
                Console.ReadKey();

            }



            if (enemyhp == 0 && hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Både {player} och {enemyname} har 0 hp, oavgjort ");

                Console.ReadLine();


            }
            else if (hp == 0)
            {
                Console.Clear();
                Console.WriteLine($"Ditt hp är 0, {enemyname} vann");

                Console.ReadLine();

            }
            else if (enemyhp == 0)
            {
                Console.Clear();
                Console.WriteLine($"{enemyname}'s hp är 0, {player} vann");

                Console.ReadLine();

            }
            Console.ReadLine();
        }

    }

    //--------------------------------------------------------------------------------------

    // Här beskrivs vad som händer om man valde 2 eller prata med honom istället för de andra alternativen första gången man fick alternativ
    else if (choice.ToLower() == "prata med honom" || choice == "2")
    {
        Console.Clear();
        Console.WriteLine("Han börjar lugna ner sig lite grann, detta är bästa chansen att göra en sneak attack, vad gör du? fortsätter du att försöka lugna ner honom eller gör du en sneak attack?");
        Console.WriteLine();
        Console.WriteLine("   Alternativ:   [Lugna ner honom]   [Sneak attack]");
        choice = GetInput(new string[] { "lugna ner honom", "1", "2", "sneak attack" });


        // Här visas vad som händer om du väljer lugna ner honom eller 1 vid alternativen ovan
        if (choice.ToLower() == "lugna ner honom" || choice == "1")
        {
            Console.Clear();
            Console.WriteLine("Personen lugnar ner sig och du kan nu berätta att det inte var meningen. Du lyckas förklara för honom och allting är nu lugnt.");
            Goodending();
            Console.ReadLine();
        }
        // Här beskrivs vad som händer om du väljer sneak attack eller 2 istället
        else if (choice.ToLower() == "sneak attack" || choice == "2")
        {
            Console.Clear();
            Console.WriteLine("Han var faktiskt inte beredd på att du skulle vara så feg och göra en sneak attack, så du lyckas slå honom rakt i kinden. Men du var så himla svag att han inte ens kände slaget, nu är han vansinnig, vad gör du? Gör du ett sista försök att prata dig ur det eller springer du där ifrån?");
            Console.WriteLine();
            Console.WriteLine("   Alternativ:   [Sista försök att prata]   [Springer därifrån]   [???]");
            choice = GetInput(new string[] { "sista försök att prata", "3", "1", "2", "springer därifrån" });

            // Här beskrivs vad som händer om du väljer 3 vid alternativen ovan
            if (choice == "3")
            {
                Luciddream();
                Specialending();
                Console.ReadLine();

            }
            // Här beskrivs vad som händer om du väljer sista försök att prata eller 1 av alternativen ovan
            if (choice.ToLower() == "sista försök att prata" || choice == "1")
            {
                Console.Clear();
                Console.WriteLine("Du är galen, han är just nu vansinnig och du ställer dig där och försöker prata med honom? Nah han one shot KO'ar dig.");
                Badending();
                Console.ReadLine();
            }
            // Här beskrivs vad som händer om du väljer springer därifrån eller 2 av alternativen
            else if (choice.ToLower() == "springer därifrån" || choice == "2")
            {
                Console.Clear();
                Console.WriteLine("Som tur var så var du inte lika långsam som du är svag, du lyckas springa ifrån honom men du har nu en fiende för livet.");
                Neutralending();
                Console.ReadLine();
            }


        }


    }

}
// Det här gör så att ifall ett av mina valda ord inte skrivs så går det inte att fortsätta
string GetInput(string[] allowedWords)
{
    bool wordFound = false;
    string input = "";
    while (!wordFound)
    {
        input = Console.ReadLine();
        if (allowedWords.Contains(input))
        {
            wordFound = true;
        }
        else
        {
            Console.WriteLine("Inte ett av alternativen, försök igen");
        }
    }
    return input;
}
// Det här visas när man gjort ett val som leder till ett dåligt slut
void Badending()
{

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(@"
    
    
██████╗░░█████╗░██████╗░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
██╔══██╗██╔══██╗██╔══██╗  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██████╦╝███████║██║░░██║  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██╔══██╗██╔══██║██║░░██║  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
██████╦╝██║░░██║██████╔╝  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝



    ");
    Console.ForegroundColor = ConsoleColor.White;


}
// Det här visas när man gjort ett val som leder till ett bra slut
void Goodending()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@"
    
    
░██████╗░░█████╗░░█████╗░██████╗░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
██╔════╝░██╔══██╗██╔══██╗██╔══██╗  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██║░░██╗░██║░░██║██║░░██║██║░░██║  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██║░░╚██╗██║░░██║██║░░██║██║░░██║  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
╚██████╔╝╚█████╔╝╚█████╔╝██████╔╝  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
░╚═════╝░░╚════╝░░╚════╝░╚═════╝░  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝
    
    ");
    Console.ForegroundColor = ConsoleColor.White;



}

// Det här visas när man gjort ett val som leder till ett neutralt slut
void Neutralending()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(@"
    

███╗░░██╗███████╗██╗░░░██╗████████╗██████╗░░█████╗░██╗░░░░░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░██╗
████╗░██║██╔════╝██║░░░██║╚══██╔══╝██╔══██╗██╔══██╗██║░░░░░  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░██║
██╔██╗██║█████╗░░██║░░░██║░░░██║░░░██████╔╝███████║██║░░░░░  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░██║
██║╚████║██╔══╝░░██║░░░██║░░░██║░░░██╔══██╗██╔══██║██║░░░░░  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗╚═╝
██║░╚███║███████╗╚██████╔╝░░░██║░░░██║░░██║██║░░██║███████╗  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝██╗
╚═╝░░╚══╝╚══════╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░╚═╝
    
    ");
    Console.ForegroundColor = ConsoleColor.White;

}


// Det här visas när man gjort ett val som leder till ett gömt slut
void Secretending()
{


    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(@"


░██████╗███████╗░█████╗░██████╗░███████╗████████╗  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░
╚█████╗░█████╗░░██║░░╚═╝██████╔╝█████╗░░░░░██║░░░  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░
░╚═══██╗██╔══╝░░██║░░██╗██╔══██╗██╔══╝░░░░░██║░░░  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗
██████╔╝███████╗╚█████╔╝██║░░██║███████╗░░░██║░░░  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝
╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░


");

}


// Det här visar en ascii bild på ett fickur
void Watch()
{


    Console.WriteLine(@"


                       .---:---:                    
        .:               =:       .:-:                 
     --:-==             .-           :-                
    --    +-..          .=            .=               
    :=. .:=-+::          =.            :-              
     .:::.   .=          .-            .=              
              -.          =-:.          =              
              .-          :=:=          =:             
               ::      .:: .=.          :-             
                ::  .::.    -:          :+:            
                 .==:      .=           :*.            
                   .:::...:-.           --             
                       ...              ==             
                                      -===-.           
                                     =..=- :-          
                                     .-+*%=-:          
                                    ..:++*=            
                                  :+*****#**+:         
                                .++-:....:=*##*-       
                                ==.  : +.-- :*#*+      
                                +:  ...  ..:..=#*=     
                                =-..-..::...::.+*+     
                                .+-...  . .:-..+*=     
                                 .==:.. :.-:..-++.     
                                   .-==-:::-==+-.      
                                      .:----:.      


");


}

// Det här visas när man gjort ett val som leder till ett speciellt slut
void Specialending()
{

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(@"


░██████╗██████╗░███████╗░█████╗░██╗░█████╗░██╗░░░░░  ███████╗███╗░░██╗██████╗░██╗███╗░░██╗░██████╗░
██╔════╝██╔══██╗██╔════╝██╔══██╗██║██╔══██╗██║░░░░░  ██╔════╝████╗░██║██╔══██╗██║████╗░██║██╔════╝░
╚█████╗░██████╔╝█████╗░░██║░░╚═╝██║███████║██║░░░░░  █████╗░░██╔██╗██║██║░░██║██║██╔██╗██║██║░░██╗░
░╚═══██╗██╔═══╝░██╔══╝░░██║░░██╗██║██╔══██║██║░░░░░  ██╔══╝░░██║╚████║██║░░██║██║██║╚████║██║░░╚██╗
██████╔╝██║░░░░░███████╗╚█████╔╝██║██║░░██║███████╗  ███████╗██║░╚███║██████╔╝██║██║░╚███║╚██████╔╝
╚═════╝░╚═╝░░░░░╚══════╝░╚════╝░╚═╝╚═╝░░╚═╝╚══════╝  ╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝╚═╝░░╚══╝░╚═════╝░


");
    Console.ForegroundColor = ConsoleColor.White;
}


// Det här visas när man väljer alternativet som leder till det lucida dröm slutet
void Luciddream()
{

    Console.Clear();
    Console.WriteLine("Av någon anledning så känner du dig inte hotad, faktum är du känner ingenting.");
    Console.WriteLine("Du börjar tänka mer och mer på vad som kan vara fel med dig, men sen så kommer du på det...");
    Console.WriteLine("DET HÄR ÄR INTE ENS VERKLIGHETEN, DU DRÖMMER!");
    Console.WriteLine("I och med att du kom på att du drömde så betyder det att du är just nu i en lucid dröm");
    Console.WriteLine("Du behöver därför inte vara rädd för personen, det spelar inte längre någon roll om han är vansinnig, för en endaste tanke och han skulle försvinna ur existens");
    Console.WriteLine("Vilket är exakt vad som hände, det gick inte ens en sekund innan personen framför dig spårlöst försvann.");
    Console.WriteLine("Du känner dig nu som en gud, men makten går till ditt huvud. Du har i din egna dröm förstört länder efter länder, det gick så långt att du förstörde hela planeten i din galenskap.");
    Console.WriteLine("På grund av detta så vaknar du upp, och precis när du vaknar så börjar ditt larm gå, det är dags att dra till skolan");
    Console.WriteLine("Men påvägen till skolan så går u in i någon...");
    Console.ReadLine();

}



void Difficulty()
{
    Console.WriteLine(@"
                                ░█████╗░██╗░░██╗░█████╗░░█████╗░░██████╗███████╗  ░█████╗░
                                ██╔══██╗██║░░██║██╔══██╗██╔══██╗██╔════╝██╔════╝  ██╔══██╗
                                ██║░░╚═╝███████║██║░░██║██║░░██║╚█████╗░█████╗░░  ███████║
                                ██║░░██╗██╔══██║██║░░██║██║░░██║░╚═══██╗██╔══╝░░  ██╔══██║
                                ╚█████╔╝██║░░██║╚█████╔╝╚█████╔╝██████╔╝███████╗  ██║░░██║
                                ░╚════╝░╚═╝░░╚═╝░╚════╝░░╚════╝░╚═════╝░╚══════╝  ╚═╝░░╚═╝

                        ██████╗░██╗███████╗███████╗██╗░█████╗░██╗░░░██╗██╗░░░░░████████╗██╗░░░██╗
                        ██╔══██╗██║██╔════╝██╔════╝██║██╔══██╗██║░░░██║██║░░░░░╚══██╔══╝╚██╗░██╔╝
                        ██║░░██║██║█████╗░░█████╗░░██║██║░░╚═╝██║░░░██║██║░░░░░░░░██║░░░░╚████╔╝░
                        ██║░░██║██║██╔══╝░░██╔══╝░░██║██║░░██╗██║░░░██║██║░░░░░░░░██║░░░░░╚██╔╝░░
                        ██████╔╝██║██║░░░░░██║░░░░░██║╚█████╔╝╚██████╔╝███████╗░░░██║░░░░░░██║░░░
                        ╚═════╝░╚═╝╚═╝░░░░░╚═╝░░░░░╚═╝░╚════╝░░╚═════╝░╚══════╝░░░╚═╝░░░░░░╚═╝░░░

");

}


void Difficultychoice()
{
    Console.WriteLine(@"
                           █▀▀▄ █▀▀ ▀▀█▀▀ █░░░█ █▀▀ █▀▀ █▀▀▄ 　 ▄█░ ░░ 　 █▀█ 　 █▀▀█ █▀▀█ 　 █▀▀█ 
                           █▀▀▄ █▀▀ ░░█░░ █▄█▄█ █▀▀ █▀▀ █░░█ 　 ░█░ ▄▄ 　 ░▄▀ 　 █░░█ █▄▄▀ 　 ░░▀▄ 
                           ▀▀▀░ ▀▀▀ ░░▀░░ ░▀░▀░ ▀▀▀ ▀▀▀ ▀░░▀ 　 ▄█▄ ░█ 　 █▄▄ 　 ▀▀▀▀ ▀░▀▀ 　 █▄▄█
");

}

static void Insult(string name)
{
    Console.WriteLine(name + " luktar som en hamster!");
}


static void AskQuit()
{
    ConsoleKeyInfo quit = Console.ReadKey();

    if (quit.KeyChar == 'q' || quit.KeyChar == 'Q')
    {
        System.Environment.Exit(0);
    }
}