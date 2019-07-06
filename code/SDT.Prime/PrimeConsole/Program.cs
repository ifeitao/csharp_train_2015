using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using SDT.Prime;

namespace PrimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("按任意键开始测试，或者按Control+Q键退出");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Q && info.Modifiers == ConsoleModifiers.Control)
                {
                    break;
                }
                Console.Write("请输入待分解的正整数：");
                string input = Console.ReadLine();
                ulong number;
                if (ulong.TryParse(input, out number))
                {
                    List<Tuple<ulong, uint>> answer = Prime.PrimeResolve(number);
                    Console.Write("分解的结果为：");
                    StringBuilder sb = new StringBuilder();
                    foreach (var tuple in answer)
                    {
                        sb.Append(tuple.Item1 + "^" + tuple.Item2 + "*");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    Console.WriteLine(sb.ToString());
                }
                else
                {
                    BigInteger bigNumber;
                    if (BigInteger.TryParse(input, out bigNumber))
                    {
                        List<Tuple<BigInteger,BigInteger>> answer = Prime.PrimeResolve(bigNumber);
                        Console.Write("分解的结果为：");
                        StringBuilder sb = new StringBuilder();
                        foreach (var tuple in answer)
                        {
                            sb.Append(tuple.Item1 + "^" + tuple.Item2 + "*");
                        }
                        sb.Remove(sb.Length - 1, 1);
                        Console.WriteLine(sb.ToString());
                    }
                    else
                    {
                        Console.WriteLine("无法解析您的输入！");
                    }
                }
            }

        }
    }
}
