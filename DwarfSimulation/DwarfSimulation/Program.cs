﻿using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("DwarfSimulationTests")]

namespace DwarfSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrepareSimulation.CreateDwarfs => List<dwarfs> dwarfs
            // PrepareSimulation.PrepareShafts => List<Shaft> shafts
            // PrepareSimulation.CreateRaport -> raportObject
            // Simulation(shafty, dwarfy,raportObject) => Start

            //forech tura:
             // Hospital(lista krasnali, raportObject) -> //     => RETURN list of DwarVes
             // Mines(shafty, lista krasnali,raportObject) -> updated list of dwarfs, updated backpacks       => RETURN list of DwarVes
             // Guild(lista krasnali ,raportObject) -> update backpacks - zerowanie + wallets update   => RETURN list of DwarVes
             // Graveyard(lista krasnali,raportObject) -> update dwarfs                                      => RETURN list of DwarVes
             // diningRoom(lista krasnali,raportObject) -> count foodEaten                                   
             // shop(lista krasnali,raportObject) -> update products + wallet update                      => RETURN list of DwarVes
             // bank? (lista krasnali) => update konta,zerowanie wallet                         => RETURN list of DwarVes





            Console.ReadKey();
        }

        //static void BetterMain()
        //{
        //    Report r = new Report();

        //    PrepareSimulation();

        //    City1(r)
        //        Building2(r)
        //}
    }
}