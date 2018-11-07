﻿using CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass_Tests
{
    [TestClass]

    public class CustomListClass_Tests
    {
        [TestMethod]
        public void Check_If_Count_Equals_To_1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            //Act
            list.Add(16);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Check_If_Index_1_Is_Equal_To_17()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;
            //Act
            list.Add(16);
            list.Add(17);

            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Check_If_Index_2_Is_Equal_To_18()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 18;
            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);

            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Check_If_Count_Equals_To_8()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 8;
            //Act
            list.Add(16);
            list.Add(16);
            list.Add(16);
            list.Add(16);
            list.Add(16);
            list.Add(16);
            list.Add(16);
            list.Add(16);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Check_If_Capacity_Equals_To_1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            //Act
            list.Add(16);

            Assert.AreEqual(expected, list.Capacity);
        }

        [TestMethod]
        public void Check_If_Capacity_Equals_To_5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 5;
            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);

            Assert.AreEqual(expected, list.Capacity);
        }

        [TestMethod]
        public void Check_If_Removed_Index_Changes_to_Next_Index()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Remove(list[1]);

            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Check_If_Removed_Value_Changes_to_Next_Index()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Remove(18);

            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Check_If_Capacity_Changes_After_Removing_Value()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int capacity = 3;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Remove(18);

            Assert.AreEqual(capacity, list.Capacity);
        }
    }
}
