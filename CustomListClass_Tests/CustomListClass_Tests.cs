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
        public void Check_If_Count_Equals_To_9()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 9;
            //Act
            list.Add(16);
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
        public void Check_If_Index_2_Is_Equal_To_18()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 18;
            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);

            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Check_If_Removing_2_Indexes_Removes_It_from_The_List_And_New_Index_Is_changed()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 29;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Add(20);
            list.Add(29);
            list.Add(39);
            list.Remove(list[0]);
            list.Remove(list[2]);

            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void Check_If_Count_Changes_After_Removing_Value()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int count = 3;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Remove(18);

            Assert.AreEqual(count, list.Count);
        }

        [TestMethod]
        public void Check_If_Index_Is_Correct_After_Removing_Value()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 10;

            //Act
            list.Add(17);
            list.Add(12);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Remove(18);

            Assert.AreEqual(expected, list[3]);
        }

        [TestMethod]
        public void Check_Capacity_Of_List()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int capacity = 8;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Add(18);
            list.Add(18);
            list.Add(18);
            list.Add(18);

            Assert.AreEqual(capacity, list.Capacity);
        }
        [TestMethod]
        public void Check_If_Index_Sequence_is_Correct_Afters()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 16;

            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Remove(17);

            Assert.AreEqual(expected, list[1]);
        }
        [TestMethod]
        public void Checking_If_index_1_Int_Is_Returned_As_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "16";

            //Act
            list.Add(15);
            list.Add(16);
            list.Add(17);
            list.Add(18);

            string result = list[1].ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Checking_If_2_Strings_Are_Added_With_Plus_Operator()
        {
            //Arrange
            CustomList<string> list = new CustomList<string>();
            CustomList<string> list1 = new CustomList<string>();
            string expected = "HelloKitty";

            //Act
            list.Add("Hello");
            list1.Add("Kitty");

            string result = list[0] + list1[0];

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Checking_If_2_Int_Are_Added_With_Plus_Operator()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            CustomList<int> list1 = new CustomList<int>();
            int expected = 5;

            //Act
            list.Add(2);
            list1.Add(3);

            int result = list[0] + list1[0];

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
