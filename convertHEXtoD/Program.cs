using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertHEXtoD
{
    class Program
    {
        static void Main(string[] args)
        {
            aaa:Console.WriteLine("Please enter the HEX number to convert to decimal");
            string hex = Console.ReadLine();
            char[] ltrz ={'A','B','C','D','E','F'};
            char[] ltrzsm ={'a','b','c','d','e','f'};
            int[] eqNumbers ={10,11,12,13,14,15};
            long decimalEq =0;
            bool chr = false;
            for(int i=hex.Length-1;i>=0;i--){
                for(int j =0;j<6;j++){
                    if(hex[i]==ltrz[j]||hex[i]==ltrzsm[j]){
                        decimalEq+=eqNumbers[j]*(long)Math.Pow(16,hex.Length-1-i);
                        chr=true;
                    }
                }
                if(chr==false){
                    decimalEq+=(hex[i]-'0')*(long)Math.Pow(16,hex.Length-1-i);
                }else{
                    chr=false;
                }
                
                    
            }
            Console.WriteLine(decimalEq);
            goto aaa;

        }
    }
}
