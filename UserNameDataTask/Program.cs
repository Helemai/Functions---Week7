using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programmküsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', kuvatakse kasutaja eesnime tagurpidi;
            //Kui kasutaja valib '2', siis kuvatakse kasutaja eesnime esimest tähte;
            //kui kasutaja valib '3', siis kuvatakse kasutaja eesnime pikkust;


            Console.WriteLine("Sisesta ome eesnimi:");
            string userName = Console.ReadLine().ToUpper();

          
            Console.WriteLine("Vali number ühest kolmeni:");
            char userNumber = Convert.ToChar(Console.ReadLine());


            switch (userNumber)
            {
                case '1':
                    UserNameReversed(userName);
                    break;
                case '2':
                    UserNameFirstLetter(userName);
                    break;
                case '3':
                    UserNameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva");
                    break;
            }

        }

        public static void UserNameReversed(string UserInput)
        {
            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.Write(UserInput[i]);
            }

        }

        public static void UserNameFirstLetter(string UserInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {UserInput[0]}");
        }

        public static void UserNameLength(string UserInput)
        {

            Console.WriteLine($"Sinu nimi on {UserInput.Length} sümbolit pikk.");
        }


    }
}
