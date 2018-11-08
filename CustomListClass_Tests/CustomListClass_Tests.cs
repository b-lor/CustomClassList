using CustomListClass;
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
            list.RemoveAt(1);

            Assert.AreEqual(expected, list[1]);
        }

        [TestMethod]
        public void Check_If_Removed_Index_Changes_Capacity_From_7_to_5()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int capacity = 5;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.RemoveAt(2);
            list.RemoveAt(3);

            Assert.AreEqual(capacity, list.Capacity);
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
            list.RemoveAt(0);
            list.RemoveAt(2);

            Assert.AreEqual(expected, list[3]);
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
        public void Check_If_Count_Changes_After_Removing_2_Same_Values()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            //int count = 7;
            int expected = 10;
            //int capacity = 7;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Remove(18);

            //Assert.AreEqual(capacity, list.Capacity);
            Assert.AreEqual(expected, list[2]);
            //Assert.AreEqual(count, list.Count);
        }

        [TestMethod]
        public void Adding_Int_To_List_And_Return_As_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "17";

            //Act
            list.Add(17);

            string result = list.ToString();

            //Assert
            Assert.AreEqual(expected, result);
        }


    }
}
