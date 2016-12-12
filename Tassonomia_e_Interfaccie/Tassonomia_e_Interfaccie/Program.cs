using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Tassonomia_e_Interfaccie
{
    class Program
    {
        static void Main(string[] args)
        {
            Salmone salm = new Salmone();
            Tonno ton = new Tonno();
            Balena bal = new Balena();
            Pinguino pingu = new Pinguino();
            Corvo cr = new Corvo();
            Ippopotamo ipp = new Ippopotamo();
            Uomo um = new Uomo();
            Cavallo cav = new Cavallo();

            int cont = 0;
            while (cont != 9)
            {
                Console.WriteLine("Di quale animale vorresti visualizzare le sue caratteristiche?(Inserire numero corrispondente)");               
                Thread.Sleep(2500);
                Console.WriteLine("1.Salmone");
                Console.WriteLine("2.Tonno");
                Console.WriteLine("3.Balena");
                Console.WriteLine("4.Pinguino");
                Console.WriteLine("5.Corvo");
                Console.WriteLine("6.Ippopotamo");
                Console.WriteLine("7.Uomo");
                Console.WriteLine("8.Cavallo");
                Console.WriteLine("9.ESCI");                
                string risp = Console.ReadLine();
                cont = int.Parse(risp);

                switch (cont)
                {
                    case 1:
                        salm.Riepilogo();
                        salm.DescrizioneSquame();
                        Console.WriteLine(" ");
                        break;

                    case 2:
                        ton.Riepilogo();
                        salm.DescrizioneSquame();
                        Console.WriteLine(" ");
                        break;

                    case 3:
                        bal.Riepilogo();
                        Console.WriteLine(" ");
                        break;

                    case 4:
                        pingu.Riepilogo();
                        pingu.DescrizionePiume();
                        Console.WriteLine(" ");
                        break;

                    case 5:
                        cr.Riepilogo();
                        cr.DescrizionePiume();
                        Console.WriteLine(" ");
                        break;

                    case 6:
                        ipp.Riepilogo();
                        ipp.DescrizioneZampe();
                        Console.WriteLine(" ");
                        break;

                    case 7:
                        um.Riepilogo();
                        um.DescrizioneAbilità();
                        um.Pelo();
                        Console.WriteLine(" ");
                        break;

                    case 8:
                        cav.Riepilogo();
                        cav.DescrizioneZampe();
                        cav.Pelo();
                        Console.WriteLine(" ");
                        break;

                    case 9:
                        //Esci dal programma
                    break;
                }
            }
        }
                
            

            

            








            
        }
    }

