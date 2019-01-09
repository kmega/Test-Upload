﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPlanes.Entities
{
    public class PassingTime
    {
        List<Plane> planes;
        List<Runway> runways;

        public PassingTime()
        {
            CurrentTurn = 0;
            planes = new List<Plane>();
            runways = new List<Runway>();
        }

        public int CurrentTurn { get; private set; }

        public void RegisterPlane(Plane plane) => planes.Add(plane);
        public void RegisterRunway(Runway runway) => runways.Add(runway);

        public void AddTurn()
        {
            CurrentTurn = CurrentTurn + 1;
            foreach(var plane in planes)
            {
                plane.OnTurnTick(runways.Where(x => x.landedPlane == plane).FirstOrDefault());
                if(plane.Location == PlaneLocation.InHangar && plane.IsHangarLeavingEngaged)
                {
                    plane.OnLeaveTick(runways.Where(x=>x.Status == RunwayStatus.Empty).FirstOrDefault());
                }
            }
        }
        
        

    }
}
