﻿using Geometria;

//INPUT UTENTE
Console.WriteLine("Inserici la base del rettangolo: ");
int baseRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci L'altezza del rettangolo");
int altezzaRettangolo = int.Parse(Console.ReadLine());
Console.WriteLine();

//Istanza oggetto
Rettangolo rettangolo1 = new Rettangolo(baseRettangolo, altezzaRettangolo);

//Display
Console.WriteLine("L'area del tuo rettangolo è: " + rettangolo1.CalcolaArea());
Console.WriteLine("Il perimetro del tuo rettangolo è: " + rettangolo1.CalcolaPerimetro());

