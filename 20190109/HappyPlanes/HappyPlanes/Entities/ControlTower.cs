﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPlanes.Entities
{
    public class ControlTower
    {
        #region DO NOT TOUCH THIS CODE

        public Runway[] runways;
       
        public ControlTower(Runway[] runways)
        {
            this.runways = runways;
        }

        #endregion DO NOT TOUCH THIS CODE

        #region IMPLEMENT THIS CODE

        public Runway GetAvailableRunway()
        {
            
            foreach (var item in runways)
            {
                if (item.Status == RunwayStatus.Empty)
                {
                    
                    return item;
                }
            }
           
                return null;
        }

        public void CheckRunwayStatus()
        {
            foreach(var item in runways)
            {
              bool result =  item.TrySendToHangar();
                if (result)
                {
                  
                  
                    item.landedPlane = null;
                    
                }
            }

        }

        public void SendPlaneFromHangar(PassingTime time)
        {
            foreach (var item in time.planes)
            {
                if (item.turnsOnRunwayOrHangar >= 28 &&item.Location==PlaneLocation.Hangar )
                {

                    GetAvailableRunway().AcceptPlane(item);
                }
            }
        }

        public void Scrumble(PassingTime time)
        {

            Runway runway = GetAvailableRunway();
            foreach (var item in time.planes)
            {
                item.Location = PlaneLocation.QueneOnRunway;

                runway.planesQuene.Add(item);


            }
        }





        #endregion IMPLEMENT THIS CODE
    }
}
