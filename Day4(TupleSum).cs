using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_TupleSum_
{
   class Program
        {
            public static IEnumerable<Tuple<int, int>> FindTwoSum(List<int> li, int tarsum)
            {
                List<Tuple<int, int>> list = new List<Tuple<int, int>>();
                for (int i = 0; i < li.Count; i++)
                {
                    for (int j = 0; j < li.Count; j++)
                    {
                        if (li[i] + li[j] == tarsum)
                        {
                            list.Add(new Tuple<int, int>(li[i], li[j]));
                        }
                    }
                }
                foreach (var ele in list)
                    yield return ele;
            }
            static void Main(string[] args)
            {
                List<int> list = new List<int>();
                Console.WriteLine("Enter the size");
                int size = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the {0} elements", size);
                for (int i = 0; i < size; i++)
                {
                    list.Add(Convert.ToInt16(Console.ReadLine()));
                }

                Console.WriteLine("Enter the targetSum");
                int targetsum = Convert.ToInt16(Console.ReadLine());
                var result = FindTwoSum(list, targetsum);
                foreach (var ele in result)
                    Console.WriteLine(ele);
                Console.ReadKey();
            }
        }
    }
