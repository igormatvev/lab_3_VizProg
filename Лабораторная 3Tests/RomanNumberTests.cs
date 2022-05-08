using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumber_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanNumberException_;

namespace RomanNumber_.Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        private RomanNumber t1;

        [TestMethod()]
        public void RomanNumber_Correct()
        {
            t1 = new RomanNumber(8);
            Assert.AreEqual("VIII", t1.ToString());
        }

        [TestMethod()]
        public void RomanNumber_False()
        {
            t1 = new RomanNumber(7);
            Assert.AreNotEqual("XII", t1.ToString());
        }

        [TestMethod]
        [ExpectedException(typeof(RomanNumberException))]
        public void CreateCorrect_Null()
        {
            t1 = new RomanNumber(0);
        }

        [TestMethod]
        public void CheckAllLiterals()
        {
            short[] Values = new short[]
            { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string[] Numerals = new string[]
            { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < Values.Length; ++i)
            {
                t1 = new RomanNumber(((ushort)Values[i]));
                Assert.AreEqual(Numerals[i], t1.ToString());
            }
        }
    }

    [TestClass()]
    public class AddWork
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckAddSameNumbers()
        {
            t1 = new RomanNumber(10);
            Assert.AreEqual("XX", (t1 + t1).ToString());
        }

        [TestMethod]
        public void CheckAddDifferentТumbers()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(6);
            Assert.AreEqual("VII", (t1 + t2).ToString());
        }

    }

    [TestClass]
    public class MultWork
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckMulSameNumbers()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", (t1 * t1).ToString());
        }

        [TestMethod]
        public void CheckMulDifferentNumbers()
        {
            t1 = new RomanNumber(2);
            t2 = new RomanNumber(3);
            Assert.AreEqual("VI", (t1 * t2).ToString());
        }
    }

    [TestClass]
    public class DivWork
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckDivSameNumbers()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", (t1 / t1).ToString());
        }

        [TestMethod]
        public void CheckMulDifferentNumbers()
        {
            t1 = new RomanNumber(6);
            t2 = new RomanNumber(3);
            Assert.AreEqual("II", (t1 / t2).ToString());
        }
    }

    [TestClass]
    public class ToStringWorkCorrect
    {
        private RomanNumber t1;
        [TestMethod]
        public void CheckString_numb1()
        {
            t1 = new RomanNumber(1);
            Assert.AreEqual("I", t1.ToString());
        }

        [TestMethod]
        public void CheckString_numb2()
        {
            t1 = new RomanNumber(10);
            Assert.AreEqual("X", t1.ToString());
        }
    }

    [TestClass]
    public class ToCompareWorkCorrect
    {
        private RomanNumber t1;
        private RomanNumber t2;

        [TestMethod]
        public void CheckCompare_11()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(1);
            Assert.AreEqual(0, t1.CompareTo(t2));
        }

        [TestMethod]
        public void CheckCompare_12()
        {
            t1 = new RomanNumber(1);
            t2 = new RomanNumber(2);
            Assert.AreEqual(-1, t1.CompareTo(t2));
        }

        [TestMethod]
        public void CheckCompare_21()
        {
            t1 = new RomanNumber(2);
            t2 = new RomanNumber(1);
            Assert.AreEqual(1, t1.CompareTo(t2));
        }
    }

    [TestClass]
    public class CloneWorkCorrect
    {
        private RomanNumber t1;

        [TestMethod]
        public void CheckClone()
        {
            t1 = new RomanNumber(1);
            var t2 = t1.Clone();
            Assert.AreEqual(t1.ToString(), t2.ToString());
        }
    }
}
