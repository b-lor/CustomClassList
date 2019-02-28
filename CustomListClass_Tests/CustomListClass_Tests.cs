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
        public void Check_If_Index_0_Equals_1()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 1;
            //Act
            list.Add(1);

            Assert.AreEqual(expected, list[0]);
        }
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
        public void Check_If_List_Is_Empty_After_Add_Remove()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int count = 0;
            //Act
            list.Add(18);
            list.Remove(18);

            Assert.AreEqual(count, list.Count);
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
        public void Check_If_3_Can_Be_Removed_From_List_Is_True()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //Act
            bool expected = list.Remove(3);

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void Check_If_6_Can_Be_Removed_From_List_Is_False()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //Act
            bool expected = list.Remove(6);

            Assert.IsFalse(expected);
        }

        [TestMethod]
        public void Check_If_Count_Is_50()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int count = 50;
            //Act
            for (int i = 0; i < 50; i++)
            {
                list.Add(i);
            }

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
            list.Remove(18);

            Assert.AreEqual(expected, list[2]);
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
        public void Check_If_ToString_Works_On_Entire_List()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            string expected = "16 17 18 19 20";

            //Act
            list.Add(16);
            list.Add(17);
            list.Add(18);
            list.Add(19);
            list.Add(20);
            string actual = list.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
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

        [TestMethod]
        public void Checking_If_Plus_Operator_Index_3_Is_Correct_After_Adding_3_Lists()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> list3 = new CustomList<int>();
            int expected = 4;

            //Act
            list1.Add(1);
            list1.Add(2);
            list2.Add(3);
            list2.Add(4);
            list3.Add(5);
            list3.Add(6);
            CustomList<int> result = list1 + list2 + list3;

            //Assert
            Assert.AreEqual(expected, result[3]);
        }

        [TestMethod]
        public void Checking_If_Plus_Operator_New_Index_6_Is_Correct_After_Adding_2_Lists()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();

            int expected = 6;

            //Act
            list1.Add(1);
            list1.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);
            CustomList<int> result = list1 + list2;

            //Assert
            Assert.AreEqual(expected, result[5]);
        }

        [TestMethod]
        public void Checking_If_Plus_Operator_Adds_Strings()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();

            string expected = "bye";

            //Act
            list1.Add("hello");
            list1.Add("kitty");
            list2.Add("blue");
            list2.Add("sky");

            CustomList<string> res = list1 + list2;
            string result = res.ToString();
            //Assert
            Assert.AreEqual(result, "hello kitty blue sky");
        }

        [TestMethod]
        public void Checking_If_Minus_Operator_Correctly_Removes_Matching_Int_Leaving_The_Others()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            //int expected = 2;

            //Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            list1.Add(8);
            list1.Add(9);
            list1.Add(10);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            CustomList<int> res = list1 - list2;
            string result = res.ToString();

            //Assert
            Assert.AreEqual(result, "1 7 8 9 10");
        }

        [TestMethod]
        public void Checking_If_Minus_Operator_Correctly_Removes_Duplicate_Matching_Int_Leaving_The_Others()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            //int expected = 2;

            //Act
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(1);
            list2.Add(1);

            CustomList<int> res = list1 - list2;
            string result = res.ToString();

            //Assert
            Assert.AreEqual(result, "2 3 4");
        }

        [TestMethod]
        public void Checking_If_Minus_Operator_Correctly_Removes_Matching_String_Leaving_The_Others()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            //int expected = 2;

            //Act
            list1.Add("one");
            list1.Add("two");
            list1.Add("three");
            list1.Add("four");
            list1.Add("five");
            list2.Add("one");
            list2.Add("three");

            CustomList<string> res = list1 - list2;
            string result = res.ToString();

            //Assert
            Assert.AreEqual(result, "two four five");
            //Assert.AreEqual(result, "1, 7, 8, 9, 10");

        }


        [TestMethod]
        public void Checking_If_Two_Equal_Lists_Are_Zipped_In_Order()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 000;

            //Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            CustomList<int> res = CustomList<int>.Zip(list1, list2);
            string result = res.ToString();

            //Assert
            //Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(result, "1 2 3 4 5 6");
        }

        [TestMethod]
        public void Checking_If_Two_Different_Lists_Are_Zipped_In_Order()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            int expected = 000;

            //Act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list1.Add(7);
            list1.Add(8);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            CustomList<int> res = CustomList<int>.Zip(list1, list2);
            string result = res.ToString();

            //Assert
            //Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(result, "1 2 3 4 5 6 7 8");
        }
        [TestMethod]
        public void Checking_If_GetEnumerator_List_Is_Empty()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 0;
            int result = 0;

            //Act
            foreach (int item in list)
            {
                result += item;
            }

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Checking_If_GetEnumerator_List_Is_Equal_To_3()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();
            int expected = 3;
            int result = 0;

            list.Add(1);
            list.Add(1);
            list.Add(1);

            //Act
            foreach (int item in list)
            {
                result += item;
            }

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Check_If_Index_0_Returns_ArgumentOutOfRangeException()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            int lists = list[0];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Check_If_Negative_Index_Returns_ArgumentOutOfRangeException()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            //Act
            int lists = list[-5];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Check_If_Positive_Index_Returns_ArgumentOutOfRangeException()
        {
            //Arrange
            CustomList<int> list = new CustomList<int>();

            list.Add(1);

            //Act
            int lists = list[1];
        }
    }
}
