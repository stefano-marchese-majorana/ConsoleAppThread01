// INTRODUZIONE
// Il multitasking è l'esecuzione simultanea di più attività o
// processi in un determinato intervallo di tempo.
// Il sistema operativo Windows è un esempio di multitasking
// perché è in grado di eseguire più di un processo alla volta
// come l'esecuzione di Google Chrome, Blocco note, lettore VLC,
// ecc. contemporaneamente. Il sistema operativo utilizza un
// termine noto come processo per eseguire tutte queste applicazioni
// contemporaneamente. Un processo è una parte di un sistema
// operativo responsabile dell'esecuzione di un'applicazione.
// Ogni programma che viene eseguito sul tuo sistema è un
// processo e per eseguire il codice all'interno dell'applicazione
// un processo utilizza un termine noto come thread.
// Un thread è un processo leggero, o in altre parole,
// un thread è un'unità che esegue il codice nel programma.
// Quindi ogni programma ha una logica e un thread è responsabile
// dell'esecuzione di questa logica.
// Ogni programma per impostazione predefinita esegue un thread
// per eseguire la logica del programma e il thread è noto come
// thread principale, quindi ogni programma o applicazione è per
// impostazione predefinita un modello a thread singolo.
// Questo modello a thread singolo ha uno svantaggio.
// Il singolo thread esegue tutti i metodi presenti nel programma
// in modo sincronizzato, ovvero uno dopo l'altro.
// Quindi, un secondo metodo attende fino a quando il primo
// metodo non completa la sua esecuzione, consuma più tempo
// nell'elaborazione.

// ESEMPIO
// una classe con due metodi - Method1 e Method2
// il thread principale è responsabile dell'esecuzione di questi
// due metodi eseguendoli uno dopo l'altro strettamente in sequenza


using System;
using System.Threading;

namespace ConsoleAppThread01
{
    class Program
    {
        // Main
        static void Main(string[] args)
        {
            Console.WriteLine("Main!!!");
            
            TH.Method1();
            TH.Method2();

            for (int k = 0; k <= 10; k++)
            {

                Console.WriteLine($"Main is : {k}");
            }
        }
    }

    public class TH
    {

        // Method1
        public static void Method1()
        {

            // stampa numeri da 0 a 10
            for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine($"Method1 is : {i}");

                // quando il valore di I è uguale a 5 
                // questo metodo si addormenta per 6 secondi
                // dopo 6 secondi riprende l'esecuzione
                if (i == 5)
                {
                    Thread.Sleep(6000);
                }
            }
        }

        // Method2
        public static void Method2()
        {

            // stampa i numeri da 0 a 10
            for (int j = 0; j <= 10; j++)
            {

                Console.WriteLine($"Method2 is : {j}");
            }
        }
    }
}
