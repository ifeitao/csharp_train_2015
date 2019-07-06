using System;
using System.Collections.Generic;
using System.Numerics;

namespace SDT.Prime
{
    /// <summary>
    /// 质数处理类
    /// </summary>
    public static class Prime
    {
        /// <summary>
        /// 判断一个正整数是否是质数
        /// </summary>
        /// <param name="number">整数</param>
        /// <returns>是否为质数</returns>
        public static bool IsPrime(ulong number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number%2 == 0) return false;
            for (uint i = 3; i <= Math.Sqrt(number)+1; i=i+2)
            {
                if (number%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 判断一个大整数是否是质数
        /// </summary>
        /// <param name="number">整数</param>
        /// <returns>是否为质数</returns>
        public static bool IsPrime(BigInteger number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            BigInteger limit = new BigInteger(Math.Pow(Math.E, 0.5*BigInteger.Log(number)));
            for (BigInteger i = 3; i <= limit; i = i + 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 将一个整数分解质因素
        /// </summary>
        /// <param name="number">正整数</param>
        /// <returns>质因素分解元组列表，元组第一项为质数，第二项为幂次</returns>
        public static List<Tuple<ulong, uint>> PrimeResolve(ulong number)
        {
            if (number == 1)
            {
                return new List<Tuple<ulong, uint>> {new Tuple<ulong, uint>(1, 1)};
            }
            List<Tuple<ulong, uint>> list = new List<Tuple<ulong, uint>>();
            for (uint i = 2; i <= Math.Sqrt(number)+1; i++)
            {
                //if (IsPrime(i))
                {
                    uint power = 0;
                    while (number%i == 0)
                    {
                        power++;
                        number /= i;
                    }
                    if (power > 0)
                    {
                        Tuple<ulong, uint> tuple = new Tuple<ulong, uint>(i, power);
                        list.Add(tuple);
                    }
                }
            }
            if (number != 1)
            {
                list.Add(new Tuple<ulong, uint>(number, 1));
            }
            return list;
        }
        /// <summary>
        /// 将一个大整数分解质因素
        /// </summary>
        /// <param name="number">正整数</param>
        /// <returns>质因素分解元组列表，元组第一项为质数，第二项为幂次</returns>
        public static List<Tuple<BigInteger, BigInteger>> PrimeResolve(BigInteger number)
        {
            if (number == 1)
            {
                return new List<Tuple<BigInteger, BigInteger>> { new Tuple<BigInteger, BigInteger>(1, 1) };
            }
            List<Tuple<BigInteger, BigInteger>> list = new List<Tuple<BigInteger, BigInteger>>();

            for (BigInteger i = 2; i <= new BigInteger(Math.Pow(Math.E, 0.5 * BigInteger.Log(number)))+1; i++)
            {
                BigInteger power = 0;
                while (number % i == 0)
                {
                    power++;
                    number /= i;
                }
                if (power > 0)
                {
                    Tuple<BigInteger, BigInteger> tuple = new Tuple<BigInteger, BigInteger>(i, power);
                    list.Add(tuple);
                }
            }
            if (number != 1)
            {
                list.Add(new Tuple<BigInteger, BigInteger>(number, 1));
            }
            return list;
        }
    }
}
