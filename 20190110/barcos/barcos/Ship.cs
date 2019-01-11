﻿using System;
using System.Xml.Linq;
using barcos.Enums;

namespace barcos
{ 
    public class Ship : IShip
    {
        public ShipMasts Masts { get; private set; }
        public bool Destroyed { get; private set; }
        public ShipOrientation Orientation { get; }
        public int CoordinatesX { get; }
        public int CoordinatesY { get; }

        public Ship(ShipOrientation shipOrientation, ShipMasts masts, int x, int y)
        {
            Masts = masts;
            Orientation = shipOrientation;
            CoordinatesX = x;
            CoordinatesY = y;
        }

        public int GetCurrentState()
        {
            return (int)Masts;
        }

        public void HasHit()
        {
            Masts--;
            
            if (Masts == ShipMasts.destroyed)
                Destroyed = true;
        }
    }
}
