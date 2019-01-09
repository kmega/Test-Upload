﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HappyPlanes.Entities
{
    public class Runway
    {
        #region DO NOT TOUCH THIS CODE

        private string name;
        private RunwayStatus status;
        private Plane landedPlane;

        public Runway(string name, RunwayStatus status = RunwayStatus.Empty)
        {
            this.name = name;
            this.status = status;
            this.landedPlane = null;
        }

        public RunwayStatus Status { get => status; set => status = value; }
        public string Name { get => name; }

        #endregion DO NOT TOUCH THIS CODE

        #region IMPLEMENT THIS CODE

        public void AcceptPlane(Plane plane)
        {
            if (!(plane.Location == PlaneLocation.OnRunway||plane.Location==PlaneLocation.Unknown))
            {
                landedPlane = plane;
                plane.Location = PlaneLocation.OnRunway;
                Status = RunwayStatus.Full;
                
            }
            
        }

        public Plane LaunchPlane()
        {
            if (landedPlane.Fuel == landedPlane.MaxFuel && landedPlane.Damage != PlaneDamage.Damaged)
            {
                status = RunwayStatus.Empty;
                return landedPlane;
            }
           else
            {
                return null;
            }

        }

        public void TrySendToHangar()
        {
            if (!(landedPlane==null)&&landedPlane.turnsOnRunway >= 25)
            {
                landedPlane.Location = PlaneLocation.Hangar;
                Status = RunwayStatus.Empty;
                landedPlane = null;
            }
        }

        #endregion IMPLEMENT THIS CODE
    }

}
