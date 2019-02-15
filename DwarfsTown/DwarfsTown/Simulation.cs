﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DwarfsTown
{
    public class Simulation
    {
        public static void Run(City city)
        {
            for (int i = 1; i <= 30; i++)
            {
                City.newsPaper.Add("\nDay "+ i +"\n");
                //Get new dwarf -> 1% saboteur, 33% Father, 33% Single, 33% Lazy
                city.hospital.BirthDwarf(city.dwarfs, City.randomizer);
                //Dwarfs go to digging               
                city.mine.StartWorking(city.dwarfs);
                //Changing materials to moneys and transfer into dwarfs account 
                city.bank.ChangeRawMaterialsIntoMoneys(city.dwarfs);
                //Get taxes from dwarfs Accounts
                city.guild.GetTaxesFromDwarfsAccounts(city.dwarfs);
                //Dwarf go to bar
                city.bar.FeedDwarfs(city.dwarfs);
                //Dwarfs go shopping
                city.shop.DoShopping(city.dwarfs);
                //Display raport from one day                
            }
            EndOfSimulation();            
        }

        public static void EndOfSimulation()
        {
            City.newsPaper.Add("\nProgram: THE END OF SIMULATION");
            Displayer.DisplayInformationAfterOneDay(City.newsPaper);
            Console.WriteLine("\nClick any key to close the app");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
