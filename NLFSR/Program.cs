using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLFSR
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.Calculate();
        }

        private void Calculate()
        {
            StringBuilder sb = new StringBuilder();

            string initialRegister = "0010";
            string newRegister;
            int level = 9;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Starting Register: " + initialRegister);
            Console.WriteLine(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current register:\tKey\tNewBit Computation\tNewRegister");
            sb.Append("_____________________________________________________");
            sb.AppendLine();
            sb.AppendLine();          
           
            for (int j = 0; j <= level; j++)
            {
                int[] outarry = Array.ConvertAll(initialRegister.ToString().ToArray(), x => (int)x - 48);

                int bitZero = outarry[0];
                int bitOne = outarry[1];
                int bitTwo = outarry[2];
                int bitThree = outarry[3];

                //int newBit = (bitZero & bitTwo) | bitThree;                               
                //int newBit = (bitZero | bitTwo) | bitThree;

                int newBit = bitThree | bitTwo | bitOne | bitZero;

                newRegister = newBit.ToString() + bitZero.ToString() + bitOne.ToString() + bitTwo.ToString();
                string algowivem = "f(" + bitZero + " and " + bitTwo + ") or " + bitThree + " = " + newBit;
                sb.Append(initialRegister + "\t\t\t" + bitThree.ToString() + "\t" + algowivem  + "\t" + newRegister);

                initialRegister = (newRegister);
                
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());

        }
    }
}
