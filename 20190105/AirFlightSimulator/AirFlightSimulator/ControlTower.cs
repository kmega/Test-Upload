﻿using System;

namespace AirFlightSimulator
{
    public class ControlTower : LandingLanesManagementSystem
    {
        public LandingLane TryGetLandigPermission(Planes plane)
        {
            return GetDataOfAvailableLaneForLandig(plane); 
        }

        private LandingLane GetDataOfAvailableLaneForLandig(Planes plane)
        {
            return new LandingLanesManagementSystem().GetLandingLane(plane);
        }
    }

}



