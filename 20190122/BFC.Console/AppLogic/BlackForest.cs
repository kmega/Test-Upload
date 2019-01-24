﻿using System;
using System.Collections.Generic;
using System.Linq;
using BFC.Console.Animals;
using BFC.Console.Heroes;
using BFC.Console.Presentation;
using BFC.Tests.Heroes;

namespace BFC.Console.AppLogic
{
    public class BlackForest
    {       
        private IOutputWritter _presenter;
        private Person _person;
        private List<Person> _persons = new List<Person>();
        private TimeOfDay _timeOfDay;
        private List<AnimalTypes> _AnimalsOnBranch = new List<AnimalTypes>();

        public BlackForest(IOutputWritter presenter)
        {
            _presenter = presenter ?? new WindowsConsole(); //jesli lewa strona jest nullem, to wykona sie prawa
        }

        public void SetTimeOfDay(TimeOfDay timeOfDay)
        {
            _timeOfDay = timeOfDay;

            if (_timeOfDay == TimeOfDay.Fire && _AnimalsOnBranch.Count == 0)
            {
                _presenter.WriteLine("Nobody will be rescued by Romantic.");
            }

            if (_timeOfDay == TimeOfDay.Fire && _AnimalsOnBranch.Count != 0 && _persons.Count == 0)
            {
                if (_person.ToString().Contains("Fireman", StringComparison.Ordinal))
                {
                    RescueChildAndCatWhileFireByFireman();
                }
                else
                {
                    RescueOnlyChildAndRapeByRomantic();
                }
            }

            if(_persons.Count != 0 && _timeOfDay == TimeOfDay.Fire)
            {
                    _person = _persons[0];
                    RescueOnlyChildAndRapeByRomantic();
                    _person = _persons[1];
                    RescueChildAndCatWhileFireByFireman();
            }
        }

        private void RescueOnlyChildAndRapeByRomantic()
        {
            IList<Animal> ListOfAnimalToBeRescuedByPedofil = new List<Animal>();

            var temp = _AnimalsOnBranch;

            for (int i = 0; i < _AnimalsOnBranch.Count; i++)
            {
                if (temp[i] == AnimalTypes.Child)
                {
                    ListOfAnimalToBeRescuedByPedofil.Add(new Animal(temp[i].ToString(), temp[i]));
                    _AnimalsOnBranch.Remove(temp[i]);
                }
            }

            if (ListOfAnimalToBeRescuedByPedofil.Count != 0)
            {
                _person.RescuAnimals(ListOfAnimalToBeRescuedByPedofil);
                _presenter.WriteLine("Child will be rescued by Romantic.");
            }
            else
            {
                _presenter.WriteLine("Nobody will be rescued by Romantic.");
            }
        }

        private void RescueChildAndCatWhileFireByFireman()
        {
            //IList<Animal> ListOfAnimalToBeRescuedByFireman = BranchHelper.PutAnimalsOnBranch(_AnimalsOnBranch.ToArray());
            IList<Animal> ListOfAnimalToBeRescuedByFireman = new List<Animal>();

            var temp = _AnimalsOnBranch;

            for (int i = 0; i < _AnimalsOnBranch.Count; i++)
            {
                if (temp[i] != AnimalTypes.Bird)
                {
                    ListOfAnimalToBeRescuedByFireman.Add(new Animal(temp[i].ToString(), temp[i]));
                    _AnimalsOnBranch.Remove(temp[i]);
                }
            }

            if (ListOfAnimalToBeRescuedByFireman.Count != 0)
            {
                _person.RescuAnimals(ListOfAnimalToBeRescuedByFireman);
                _presenter.WriteLine("Child, Cat will be rescued by Fireman.");
            }
            else
            {
                _presenter.WriteLine("Nobody will be rescued by Fireman.");
                _presenter.WriteLine("Fireman generated alarm sound.");
            }
        }

        public void SitOnTheTree(AnimalTypes animalType)
        {
            _AnimalsOnBranch.Add(animalType);
            BranchSetter(animalType);
        }

        public void SitOnTheTree(AnimalTypes[] animalType)
        {
            if (_timeOfDay == TimeOfDay.Fire && _AnimalsOnBranch.Count == 0)
            {
                _presenter.WriteLine("Bird, Cat, Child doesn't sit on the Tree");
            }
            else
            {
                foreach (var item in animalType)
                {
                    BranchSetter(item);
                }
            }
        }

        public void ActivateFireman()
        {
            _person = new Fireman();
        }

        public void ActivateRomantic()
        {
            _person = new Romantic();
        }

        public void RandomRomanticOrFireman(IRandomizer randomizer)
        {
            _person = randomizer.ActivateFiremanOrPedofil();
        }

        public void ActivateFiremanAndRomantic(IBothHeroes bothHeros)
        {
            _persons = bothHeros.ActivateFiremanAndRomanticAtTheSameTime();
        }

        private void BranchSetter(AnimalTypes animalType)
        {
            switch (animalType)
            {
                case AnimalTypes.Child:
                    switch (_timeOfDay)
                    {
                        case TimeOfDay.Day:
                            _AnimalsOnBranch.Add(animalType);
                            _presenter.WriteLine("Child sit on the Tree.");
                            break;
                        case TimeOfDay.Night:
                            _AnimalsOnBranch.Add(animalType);
                            _presenter.WriteLine("Child sit on the Tree.");
                            break;
                        case TimeOfDay.Fire:
                            _presenter.WriteLine("Child doesn't sit on the Tree.");
                            break;
                    }
                    break;

                case AnimalTypes.Bird:
                    switch (_timeOfDay)
                    {
                        case TimeOfDay.Day:
                            _AnimalsOnBranch.Add(animalType);
                            _presenter.WriteLine("Bird sit on the Tree.");
                            break;
                        case TimeOfDay.Night:
                            _presenter.WriteLine("Bird doesn't sit on the Tree.");
                            break;
                        case TimeOfDay.Fire:
                            _presenter.WriteLine("Bird doesn't sit on the Tree.");
                            break;
                    }
                    break;
                case AnimalTypes.Cat:
                    switch (_timeOfDay)
                    {
                        case TimeOfDay.Day:
                            _presenter.WriteLine("Cat doesn't sit on the Tree.");
                            break;
                        case TimeOfDay.Night:
                            _AnimalsOnBranch.Add(animalType);
                            _presenter.WriteLine("Cat sit on the Tree.");
                            break;
                        case TimeOfDay.Fire:
                            _presenter.WriteLine("Cat doesn't sit on the Tree.");
                            break;
                    }
                    break;
            }

            }
        }
}