using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_TextNumberInput_
{
    class TextInput
    {
        string str = "";
        public virtual void  Add( char c)
        {
           str = str + c; 
        }
        public virtual string GetValue()
        {
            return str;
        }
        
    }
    class NumericInput:TextInput
    {
        string str2 = "";
        public  override void Add(char c)
        {
            
            if (c >= 48 && c <= 57)
            {
                str2 += c;
            }
            
        }
        public override string GetValue()
        {
            return str2;
        }
        static void Main(string[] args)
        { 

          TextInput input = new NumericInput();
          char c = '\0';
          do {
              
                Console.WriteLine("Enter the inputs either character or number");
                char va = Convert.ToChar(Console.ReadLine());
                input.Add(va);
                Console.WriteLine("Do you want to add another \n\nIf yes Print y or Y");
                c = Convert.ToChar(Console.ReadLine());
             } while (c == 'y' || c == 'Y');


            Console.WriteLine("The output is " + input.GetValue());
            Console.Read();

        }
    }
}
