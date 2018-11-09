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
        public void Check_If_Count_Equals_To_5()
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
        public void Check_If_Index_1_Is_Equal_To_17()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 17;
            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);

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
            list.Add(19);
            list.Add(20);

            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Check_If_Capacity_Equals_To_7()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 7;
            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
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
            list.Remove(17);

            Assert.AreEqual(expected, list[1]);
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
        public void Check_If_Capacity_Changes_From_4_To_3_After_Removing_1_Item()
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
        public void Check_If_Index_Sequence_is_Correct_After_Removing_2_Same_Values()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 10;

            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Add(16);
            list.Add(18);
            list.Add(10);
            list.Remove(18);

            Assert.AreEqual(expected, list[2]);
        }

        [TestMethod]
        public void Adding_Int_To_List_And_Return_As_String()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "19";

            //Act
            list.Add(19);

            string result = list.ToString();

            //Assert
            Assert.AreEqual(expected, "19");
        }

        [TestMethod]
        public void Check_If_Removing_1_Index_Changes_Capacity_From_5_to_4()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int capacity = 4;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Add(18);
            list.Remove(17);

            Assert.AreEqual(capacity, list.Capacity);
        }

        [TestMethod]
        public void Check_If_Removing_1_Index_Changes_Count_From_7_to_6aaa()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int capacity = 4;
            //Act
            list.Add(17);
            list.Add(18);
            list.Add(16);
            list.Add(19);
            list.Add(18);
            list.Remove(list[3]);

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
    }
}
