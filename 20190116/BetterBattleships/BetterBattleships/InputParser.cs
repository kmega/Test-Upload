﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BetterBattleships
{
    public class InputParser : IInput
    {
        public string GetNameForNewPlayer()
        {
            Console.Write("Podaj imie: ");
            return Console.ReadLine();
        }

        public int[] GetCoordinatesToSetShip()
        {
            Console.WriteLine();
            Console.WriteLine("Podaj punkt pcozatkowy statku: ");

            int[] coordsFromKeyboard = ParseCorrectnessOfInputCoordsFromKeyboard();

            return coordsFromKeyboard;
        }

        public int[] ParseCorrectnessOfInputCoordsFromKeyboard(bool testCondition = false, string testInput = null)
        {
            Console.WriteLine("Podaj kooordynaty w formacie (LiteraNumer): ");
            string inputFromKeyboard = testInput;

            if (testCondition == false)
                inputFromKeyboard = Console.ReadLine();

            if (inputFromKeyboard.Length > 2)
                throw new ArgumentOutOfRangeException();

            Regex regexPattern = new Regex("\\w");

            MatchCollection matches = regexPattern.Matches(inputFromKeyboard);

            int firstArrayValue = 100;
            int secondArrayValue = 100;

            switch (matches[0].ToString().ToLower())
            {
                case "a":
                    firstArrayValue = 0;
                    break;
                case "b":
                    firstArrayValue = 1;
                    break;
                case "c":
                    firstArrayValue = 2;
                    break;
                case "d":
                    firstArrayValue = 3;
                    break;
                case "e":
                    firstArrayValue = 4;
                    break;
                case "f":
                    firstArrayValue = 5;
                    break;
                case "g":
                    firstArrayValue = 6;
                    break;
                case "h":
                    firstArrayValue = 7;
                    break;
                case "i":
                    firstArrayValue = 8;
                    break;
                case "j":
                    firstArrayValue = 9;
                    break;

                default:
                    if (testCondition == true)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    Console.WriteLine("Podales zly format!");
                    Console.WriteLine("Zeby wprowadzic dane jeszcze raz, to nacisnij dowolny klawisz...");
                    Console.ReadKey();
                    Console.Clear();
                    ParseCorrectnessOfInputCoordsFromKeyboard();
                    break;
            }

            switch (matches[1].ToString())
            {
                case "1":
                    secondArrayValue = 0;
                    break;
                case "2":
                    secondArrayValue = 1;
                    break;
                case "3":
                    secondArrayValue = 2;
                    break;
                case "4":
                    secondArrayValue = 3;
                    break;
                case "5":
                    secondArrayValue = 4;
                    break;
                case "6":
                    secondArrayValue = 5;
                    break;
                case "7":
                    secondArrayValue = 6;
                    break;
                case "8":
                    secondArrayValue = 7;
                    break;
                case "9":
                    secondArrayValue = 8;
                    break;
                case "10":
                    secondArrayValue = 9;
                    break;


                default:
                    if(testCondition == true)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    Console.WriteLine("Podales zly format!");
                    Console.WriteLine("Zeby wprowadzic dane jeszcze raz, to nacisnij dowolny klawisz...");
                    Console.ReadKey();
                    Console.Clear();
                    ParseCorrectnessOfInputCoordsFromKeyboard();
                    break;
            }


            return new int[] { firstArrayValue, secondArrayValue };
        }

        public string GetDirectionsForCoordinates()
        {
            Console.WriteLine("Statki nie moga na siebie nachodzic");
            Console.Write("Wpisz kierunek: ");
            return Console.ReadLine();
        }

        public int[] GetCoordinatesToShootShip(string vicitmName, string shooter)
        {
            Console.WriteLine("Strzela gracz: {0}, jesli trafi w pole typu Deck, to moze wykonac ponowny ruch", shooter);
            Console.WriteLine();
            Console.WriteLine("Podaj punkt gdzie chcesz wykonac strzal w plansze gracza: {0}", vicitmName);

            int[] coordsFromKeyboard = ParseCorrectnessOfInputCoordsFromKeyboard();

            return coordsFromKeyboard;
        }
    }
}