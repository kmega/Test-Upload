﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chickenKitchenApp
{
    class FoodAndItsAllergicIngredients
    {
        public Dictionary<string, List<string>> foodWithItsAllergicIngredients = new Dictionary<string, List<string>>();

        public List<string> fries { get; private set; }

        public void ListOfAllDishesWithItsAlergicIngredients()
        {
            List<string> fries = new List<string>();

            fries.Add("potatoes");
        }
       
    }

    class ClientsAndTheirAllergies
    {
        public Dictionary<string, List<string>> bindedClientsAndAllergies = new Dictionary<string, List<string>>();

        public List<string> alergiesOf_AdamSmith { get; private set; }
        public List<string> alergiesOf_ElonCarousel { get; private set; }

        public void ListOfAllergiesOfClients()
        {
            List<string> alergiesOf_AdamSmith = new List<string>();
            List<string> alergiesOf_ElonCarousel = new List<string>();

            alergiesOf_ElonCarousel.Add("olives");
            alergiesOf_ElonCarousel.Add("vinegar");  //how to add in one line?
        }


        public void AddAlergiesToSpecificClients()
        {
            bindedClientsAndAllergies.Add("Adam Smith", alergiesOf_AdamSmith );
            bindedClientsAndAllergies.Add("Elon Carousel", alergiesOf_ElonCarousel);

        }
    }


    class AskingForDishAndNameOfCustomer
    {
        public void AskForDish()
        {
            Console.WriteLine("Hello! Welcome to our CHICKEN-KITCHEN restaurant. What is Your name?");
            string nameOfCustomer = Console.ReadLine();
            Console.WriteLine("It's so nice to meet You, {0}! What would You like to order?", nameOfCustomer);
            string nameOfOrderedDish = Console.ReadLine();
            CompareClientWithItsOrderAndAllergies(nameOfCustomer, nameOfOrderedDish);

        }

        public void CompareClientWithItsOrderAndAllergies(string customer_name, string dish_name)
        {
            ClientsAndTheirAllergies servedCustomer = new ClientsAndTheirAllergies();

            List<string> customerAsKey = servedCustomer.bindedClientsAndAllergies.Keys.ToList();

            foreach (string k in customerAsKey)
            {
                List<string> allergiesOf_TheCustomer = (k == customer_name) ? servedCustomer.bindedClientsAndAllergies[k] : null;
            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}