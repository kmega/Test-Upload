﻿namespace FoodTracks.Model
{
    public class Cook
    {




        public Burger Create(IBurgerMaker burgerMaker)
        {
            if (burgerMaker == null)
            {
                Burger burger = new Burger();
                return burger;
            }
            else
            {
                var burger = burgerMaker.Make();
                return burger;
            }
        }


    }


}