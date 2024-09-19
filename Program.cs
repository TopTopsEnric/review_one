using System;

class Program
{
    static void Main(string[] args)
    {
        int nota1;
        int nota2;
        int nota3;
        int resp;
        string[] ciutats;
        string[] codiPostal;
        int exit = 1;

        Console.WriteLine("Introdueix la primera qualificació: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la segona qualificació: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introdueix la tercera qualificació: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        float promig = (nota1 + nota2 + nota3) / 3;

        Console.WriteLine("El promig de les notes es: " + promig);

        if (promig > 6)
        {
            Console.WriteLine("Aprovat");
        }
        else
        {
            Console.WriteLine("Suspès");
        }

        //Ex8
        Console.WriteLine("Quantes ciutats vols introduir?");
        int numCiutats = Convert.ToInt32(Console.ReadLine());
        ciutats = new string[numCiutats];
        codiPostal = new string[numCiutats];

        while (exit != 0)
        {
            Console.WriteLine("Vols introduir les dades de una ciutat y el seu codi postal? si es Si pulsa 1 si es No Pulsa 0 ");
            resp = Convert.ToInt32(Console.ReadLine());

            if (resp == 0)
            {
                for (int i = 0; i < ciutats.Length; i++)
                {
                    Console.WriteLine("Ciutat: " + ciutats[i] + " Codi Postal: " + codiPostal[i]);
                }
                exit = 0;
            }
            else if (resp == 1)
            {
                
                for (int i = 0; i < ciutats.Length; i++)
                {
                    Console.WriteLine("Introdueix la ciutat " + (i + 1) + ":");
                    ciutats[i] = Console.ReadLine();

                    Console.WriteLine("Introdueix el codi postal per la ciutat " + (i + 1) + ":");
                    codiPostal[i] = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Resposta invalida, torna ha provar");
            }
        }
        }
}


