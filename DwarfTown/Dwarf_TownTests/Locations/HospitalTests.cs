﻿using Dwarf_Town;
using Dwarf_Town.Enums;
using Dwarf_Town.Interfaces;
using Dwarf_Town.Locations;
using Moq;
using NUnit.Framework;

namespace Dwarf_TownTests.Locations
{
    [TestFixture]
    public class HospitalTests
    {
        [Test]
        public void ShouldGenerateSuicideDwarfWhenGenerateChanceIs1()
        {
            //given
            var mock = new Mock<IChance>();
            mock.Setup(e => e.GenerateChance(1, 100)).Returns(100);
            Hospital hospital = new Hospital();
            var expected = new Dwarf(DwarfType.SUICIDE);
            //when
            var result = hospital.Generate();
            //then
            Assert.AreEqual(expected.DwarfType, result.DwarfType);
        }

        [Test]
        public void ShouldGenerateFatherDwarfWhenGenerateChanceIs15()
        {
            //given
            var mock = new Mock<IChance>();
            mock.Setup(e => e.GenerateChance(1, 100)).Returns(15);
            Hospital hospital = new Hospital();
            var expected = new Dwarf(DwarfType.FATHER);
            //when
            var result = hospital.Generate();
            //then
            Assert.AreEqual(expected.DwarfType, result.DwarfType);
        }

        [Test]
        public void ShouldGenerateIdlerDwarfWhenGenerateChanceIs45()
        {
            //given
            var mock = new Mock<IChance>();
            mock.Setup(e => e.GenerateChance(1, 100)).Returns(15);
            Hospital hospital = new Hospital();
            var expected = new Dwarf(DwarfType.IDLER);
            //when
            var result = hospital.Generate();
            //then
            Assert.AreEqual(expected.DwarfType, result.DwarfType);
        }

        [Test]
        public void ShouldGenerateSingleDwarfWhenGenerateChanceIs99()
        {
            //given
            var mock = new Mock<IChance>();
            mock.Setup(e => e.GenerateChance(1, 100)).Returns(99);
            Hospital hospital = new Hospital();
            var expected = new Dwarf(DwarfType.SINGLE);
            //when
            var result = hospital.Generate();
            //then
            Assert.AreEqual(expected.DwarfType, result.DwarfType);
        }
    }
}