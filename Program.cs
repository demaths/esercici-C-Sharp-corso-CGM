using System;
using System.Collections;
using System.Collections.Generic;

namespace EsercizioDizionari_anagrafica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visualizza V = new Visualizza();

            V._visualizza(Anagrafica.AddCittadino());

            Console.WriteLine("hello world");
        }

    }

    internal static class Anagrafica {


        public static Dictionary<string, Dictionary<Dipartimento, ArrayList>> AddCittadino() {

            Dictionary < string, Dictionary<Dipartimento, ArrayList >> AnagraficaItalia = new Dictionary<string, Dictionary<Dipartimento,ArrayList >>();
            AnagraficaItalia.Add("A001A",new());
            AnagraficaItalia["A001A"].Add(Dipartimento.ASL,new());
            AnagraficaItalia["A001A"][Dipartimento.ASL].Add(Medico_ASL.Annalisa);
            AnagraficaItalia["A001A"][Dipartimento.ASL].Add("esenzione E24 PER Patologia");
            AnagraficaItalia["A001A"].Add(Dipartimento.POLIZIA, new());
            AnagraficaItalia["A001A"][Dipartimento.POLIZIA].Add("ha efetuatto una denuncia per furto veicolo il 24/05/2010");
            AnagraficaItalia["A001A"][Dipartimento.POLIZIA].Add("accusato per minace dal vicino di casa il 07/11/2021");
            AnagraficaItalia["A001A"].Add(Dipartimento.SCUOLA, new());
            AnagraficaItalia["A001A"][Dipartimento.SCUOLA].Add("liceo scientifico GOLGI in 2009");
            AnagraficaItalia["A001A"][Dipartimento.SCUOLA].Add("universita di milano in 2015");
            AnagraficaItalia["A001A"][Dipartimento.SCUOLA].Add("asilo nido Rainbow 2002");
            AnagraficaItalia["A001A"].Add(Dipartimento.COMUNE, new());
            AnagraficaItalia["A001A"][Dipartimento.COMUNE].Add("NOME:Andrea, Cognome:Mantelini" );
            AnagraficaItalia["A001A"][Dipartimento.COMUNE].Add("residenza in via olevano 45,27100,pavia,PV");
            AnagraficaItalia["A001A"].Add(Dipartimento.INPS, new());
            AnagraficaItalia["A001A"][Dipartimento.INPS].Add("lavoro dipendente dal 2001 a 2020");
            AnagraficaItalia["A001A"][Dipartimento.INPS].Add("percepito la NASPI in 2014");
            AnagraficaItalia["A001A"][Dipartimento.INPS].Add("pensionato dal 2022");
        
            AnagraficaItalia.Add("B001C", new());
            AnagraficaItalia["B001C"].Add(Dipartimento.ASL, new());
            AnagraficaItalia["B001C"][Dipartimento.ASL].Add(Medico_ASL.GianPaolo);
            AnagraficaItalia["B001C"].Add(Dipartimento.SCUOLA, new());
            AnagraficaItalia["B001C"][Dipartimento.SCUOLA].Add("liceo scientifico GOLGI in 2018");
            AnagraficaItalia["B001C"].Add(Dipartimento.COMUNE, new());
            AnagraficaItalia["B001C"][Dipartimento.COMUNE].Add("NOME:Mengoni");
            AnagraficaItalia["B001C"][Dipartimento.COMUNE].Add("residenza via sostegno 18, 47100,Brescia,BS,Italia");

            return AnagraficaItalia;
        }
    }
    internal class Visualizza {

        public void _visualizza(Dictionary<string, Dictionary<Dipartimento, ArrayList>> dict) {
            int value;
            String CF;

            do {
                Console.WriteLine("inserisci il codice fiscale");
                CF = Console.ReadLine();
                if (!dict.ContainsKey(CF))
                {
                    Console.WriteLine("il codice fiscale inserito non esiste nell'anagrafica.    0 ->per uscire,   1 ->reinserire \n");
                    value = Convert.ToInt16(Console.ReadLine());
                }
                else
                {
                    value = 0;
                }

            }while (value == 0);

            Console.WriteLine("1 ->dipartimento ASL,  2 -> dipartimento COMUNE, 3 ->dipartimento POLIZIA, 4 -> dipartimento INPS, 5 -> dipartimento SCUOLA, 0 -> EXIT  \n\n");
            value = Convert.ToInt16(Console.ReadLine());

            switch (value) {
                case 1 :
                    //int i = 0;
                    foreach (var item in dict[CF][Dipartimento.ASL]) {
                        
                        Console.WriteLine(item);
                    }
                    break;
                case 2 :
                    foreach (var item in dict[CF][Dipartimento.COMUNE])
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    foreach (var item in dict[CF][Dipartimento.POLIZIA])
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 4:
                    foreach (var item in dict[CF][Dipartimento.INPS])
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 5:
                    foreach (var item in dict[CF][Dipartimento.SCUOLA])
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default :
                    {
                        Console.WriteLine("scelta errata");
                    }
                    break;

            }
        }
    }
    internal enum Dipartimento {
            ASL, COMUNE, POLIZIA, INPS, SCUOLA
    }
    internal enum Medico_ASL
    {
        ROSSI, GianPaolo, Lovati, Pietro, Annalisa
    }
     
}

  

