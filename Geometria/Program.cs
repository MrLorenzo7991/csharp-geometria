using Geometria;

//variabli
int baseRettangolo = 0;
int altezzaRettangolo = 0;


void ChiediRettangolo()
{
    Console.WriteLine("Inserici la base del rettangolo in cm: ");
    bool flag = false;
    do
    {
        if (int.TryParse(Console.ReadLine(), out int output))
        {
            baseRettangolo = output;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci solo numeri interi!");
        }
    } while (!flag);
    flag = false;

    Console.WriteLine("Inserisci L'altezza del rettangolo in cm: ");
    do
    {
        if (int.TryParse(Console.ReadLine(), out int output))
        {
            altezzaRettangolo = output;
            flag = true;
        }
        else
        {
            Console.WriteLine("Inserisci solo numeri interi!");
        }
    } while (!flag);
}

//INPUT UTENTE
Console.WriteLine("Benventuto nel programma per il calcolo di perimetro ed area di un rettangolo! \n");
Console.WriteLine("Per prima cosa scegli le dimensioni del tuo rettangolo. \n");
ChiediRettangolo();

//Istanza oggetto
Rettangolo rettangolo = new Rettangolo(baseRettangolo, altezzaRettangolo);

//programma
while (true)
{
    Console.WriteLine("Cosa vuoi fare adesso? (scegli il numero dell'operazione)");
    Console.WriteLine();
    Console.WriteLine("[1] -Conoscere l'area del rettangolo");
    Console.WriteLine("[2] -Conoscere il perimetro del rettangolo");
    Console.WriteLine("[3] -Stampare tutte le informazioni del rettangolo");
    Console.WriteLine("[4] -Disegnare il rettangolo");
    Console.WriteLine("[5] -Cambiare le dimensioni del tuo rettangolo");
    string scelta = Console.ReadLine();

    switch (scelta)
    {
        case "1":
            Console.WriteLine("L'area del tuo rettangolo è di: " + rettangolo.CalcolaArea() + "cm \n");
            Console.WriteLine("premi un tasto per andare avanti");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("Il perimetro del tuo rettangolo è di: " + rettangolo.CalcolaPerimetro() + "cm \n");
            Console.WriteLine("premi un tasto per andare avanti");
            Console.ReadKey();
            break ;
        case "3":
            rettangolo.StampaRettangolo();
            Console.WriteLine("premi un tasto per andare avanti");
            Console.ReadKey();
            break;
        case "4":
            rettangolo.Disegna();
            Console.WriteLine("premi un tasto per andare avanti");
            Console.ReadKey();
            break;
        case "5":
            ChiediRettangolo();
            Console.WriteLine("premi un tasto per andare avanti");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Seleziona un numero da 1 a 5");
            break;
    }
}














