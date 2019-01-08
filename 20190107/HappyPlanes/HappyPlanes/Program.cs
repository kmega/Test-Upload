﻿using System;

namespace HappyPlanes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create plane
            //Create runway
            //Create control tower

            //given
            PlanesMain.Planes plane_1 = new PlanesMain.Planes(1);
            ControlTower tower = new ControlTower();
            RunwayMain.Runway runway_1 = new RunwayMain.Runway(1);
            Simulation simulate = new Simulation();
            PlanesMain plane = new PlanesMain();
            RunwayMain runway = new RunwayMain();

            //List<Planes> listOfPlanes = new List<Planes>();
            //List<Runway> listOfRunways = new List<Runway>();
            //act
            simulate.Start(plane, runway, plane_1, runway_1);

            //expected
            int result = plane_1.GetPlaneState();
            bool result_2 = runway.AllRunwaysIdAndState[1];
        }
    }
}
