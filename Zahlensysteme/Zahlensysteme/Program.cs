using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            while (0 != 1)
            {
                Console.Clear();
                Console.WriteLine("Zahlensysteme Open Source Software");
                Console.WriteLine();



                Console.WriteLine("                             1    Binäreingabe");
                Console.WriteLine("                             2    Umrechnung in Basis 10");
                Console.WriteLine("                             3    Umrechnung in Basis 16");
                Console.Write("Wählen Sie in welches Zahlenformat Sie umwandeln möchten: ");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {

                    case 1:
                        Console.Write("Geben Sie eine Binärzahl ein: ");
                        string eingabe = Console.ReadLine();
                        char[] b = eingabe.ToCharArray();

                        for (int counter = 0; counter < eingabe.Length; counter++)
                        {
                            if (b[counter] != ('0'))
                            {
                            }
                            else if (b[counter] == ('0'))
                            {
                            }
                            else
                            {
                                Console.WriteLine("Das ist keine Binärzahl!");
                                break;
                            }
                            if (b[counter] == ('1'))
                            {
                            }
                            else if (b[counter] == ('0'))
                            {
                            }
                            else
                            {
                                Console.WriteLine("Das ist keine Binärzahl!");
                                break;
                            }
                        }
                        break;

                    case 2:

                        break;

                    default: Console.WriteLine("Fehler: geben Sie bitte eine gültige Zahl ein!");

                        break;
                }

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
