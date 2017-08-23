using System;
namespace RemoveDuplicatesInString
{
    class Program
    {
        public static string RemoveDuplicate(string s)
        {
            char[] ch = s.ToCharArray();
            string st = "";
            for(int i=0;i<s.Length-1;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(ch[i]==ch[j])
                    {
                        ch[j] = '*';
                    }
                }
            }
            for(int i=0;i<s.Length;i++)
            {
                if (ch[i] != '*')
                    st=st+ch[i];
            }
            return st;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string str = Console.ReadLine();
            Console.WriteLine("String without duplicate is "+ RemoveDuplicate(str));
            Console.ReadLine();

        }
    }
}
