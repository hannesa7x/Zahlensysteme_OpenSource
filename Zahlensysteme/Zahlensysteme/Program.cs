using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zahlensysteme
{
    class Program
    {
        static bool Binaer(string eingabe)
        {
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
                    return false;
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
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int menu = 0;
            while (0 != 1)
            {
                Console.Clear();
                Console.WriteLine("Zahlensysteme Open Source Software");
                Console.WriteLine();



                Console.Write("Geben Sie eine Binärzahl ein: ");
                string eingabe = Console.ReadLine();
                
                
                if (Binaer(eingabe))
                {


                    Console.WriteLine("                             1    Umrechnung in Basis 10");
                    Console.WriteLine("                             2    Umrechnung in Basis 16");
                    Console.Write("Wählen Sie in welches Zahlenformat Sie umwandeln möchten: ");
                    menu = Convert.ToInt32(Console.ReadLine());

                    switch (menu)
                    {

                        case 1:
                            Console.Write(eingabe+" --> ");
                            Console.Write(ConvertToDec(eingabe));


                            break;

                        case 2:

                            break;

                        default: Console.WriteLine("Fehler: geben Sie bitte eine gültige Zahl ein!");

                            break;
                    }

                    Console.ReadKey();
                }
                else
                Console.ReadKey();
            }

            Console.ReadKey();
        }

        static string ConvertToDec(string Eingelesen)
        {
            //string Bin = Convert.ToString(Console.ReadLine());
            int a = Convert.ToInt32(Eingelesen, 2);
            //int a = Convert.ToInt32(Eingelesen, 2);
            string b = Convert.ToString(a);
            //Console.WriteLine("Input value in base 10 = " + b);
            return b;
        }


        static string ConvertToHex(string Eingelesen)
        {
            //Eingabe der Zahl als string

            string Erg = Convert.ToInt32(Eingelesen, 2).ToString("X");

            return Erg;
        }

    }
}
