using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDT.Prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace SDT.Prime.Tests
{
    [TestClass()]
    public class PrimeTests
    {
        [TestMethod()]
        public void IsPrimeTest()
        {
            Assert.AreEqual(Prime.IsPrime(1), false);
            Assert.AreEqual(Prime.IsPrime(4), false);
            Assert.AreEqual(Prime.IsPrime(9), false);
            Assert.AreEqual(Prime.IsPrime(1001), false);
            Assert.AreEqual(Prime.IsPrime(2), true);
            Assert.AreEqual(Prime.IsPrime(3), true);
            Assert.AreEqual(Prime.IsPrime(97), true);
        }

        [TestMethod()]
        public void PrimeResolveTest()
        {
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(1),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(1,1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(2),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(2,1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(3),
               new List<Tuple<ulong, uint>>
               {
                    new Tuple<ulong, uint>(3,1)
               }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(4),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(2,2)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(6),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(2, 1),
                    new Tuple<ulong, uint>(3, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(97),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(97, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(100),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(2, 2),
                    new Tuple<ulong, uint>(5, 2)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(1001),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(7, 1),
                    new Tuple<ulong, uint>(11, 1),
                    new Tuple<ulong, uint>(13, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(7 * 7 * 11 * 11 * 97 * 197),
                new List<Tuple<ulong, uint>>
                {
                    new Tuple<ulong, uint>(7, 2),
                    new Tuple<ulong, uint>(11, 2),
                    new Tuple<ulong, uint>(97, 1),
                    new Tuple<ulong, uint>(197, 1)
                }));
        }

        private bool ListTupleEqual(List<Tuple<ulong, uint>> list1,
            List<Tuple<ulong, uint>> list2)
        {
            if (list1.Count != list2.Count) return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Item1 != list2[i].Item1
                    || list1[i].Item2 != list2[i].Item2)
                {
                    return false;
                }
            }
            return true;
        }

        private bool ListTupleEqual(List<Tuple<BigInteger, BigInteger>> list1,
            List<Tuple<BigInteger, BigInteger>> list2)
        {
            if (list1.Count != list2.Count) return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i].Item1 != list2[i].Item1
                    || list1[i].Item2 != list2[i].Item2)
                {
                    return false;
                }
            }
            return true;
        }


        [TestMethod()]
        public void IsPrimeTest1()
        {
            Assert.AreEqual(Prime.IsPrime(new BigInteger(1)), false);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(4)), false);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(9)), false);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(1001)), false);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(2)), true);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(3)), true);
            Assert.AreEqual(Prime.IsPrime(new BigInteger(97)), true);
        }

        [TestMethod()]
        public void PrimeResolveTest1()
        {
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(1)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(1,1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(2)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(2,1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(3)),
               new List<Tuple<BigInteger, BigInteger>>
               {
                    new Tuple<BigInteger, BigInteger>(3,1)
               }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(4)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(2,2)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(6)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(2, 1),
                    new Tuple<BigInteger, BigInteger>(3, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(97)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(97, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(100)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(2, 2),
                    new Tuple<BigInteger, BigInteger>(5, 2)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(1001)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(7, 1),
                    new Tuple<BigInteger, BigInteger>(11, 1),
                    new Tuple<BigInteger, BigInteger>(13, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(new BigInteger(7 * 7 * 11 * 11 * 97 * 197)),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(7, 2),
                    new Tuple<BigInteger, BigInteger>(11, 2),
                    new Tuple<BigInteger, BigInteger>(97, 1),
                    new Tuple<BigInteger, BigInteger>(197, 1)
                }));
            Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(BigInteger.Parse("10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")),
                new List<Tuple<BigInteger, BigInteger>>
                {
                    new Tuple<BigInteger, BigInteger>(2, 100),
                    new Tuple<BigInteger, BigInteger>(5, 100)
                }));
            //Assert.IsTrue(ListTupleEqual(Prime.PrimeResolve(BigInteger.Multiply(489133282872437279, BigInteger.Parse("19175002942688032928599"))),
            //    new List<Tuple<BigInteger, BigInteger>>
            //    {
            //        new Tuple<BigInteger, BigInteger>(489133282872437279, 1),
            //        new Tuple<BigInteger, BigInteger>(BigInteger.Parse("19175002942688032928599"), 1)
            //    }));
        }
    }
}