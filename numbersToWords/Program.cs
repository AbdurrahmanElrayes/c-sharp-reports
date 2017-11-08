using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace New_folder
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[] singleNumbers = {"zero","one", "two","three","four","five","six","seven","eight","nine"};
            string[] teenNumbers = {"ten","eleven", "twilve","thirteen","forteen","fifteen","sixteen","seventeen","eighteen","nineteen"};
            string[] decimalNumbers = {"twinty", "thirty","forty","fifty","sixty","seventy","eighty","ninty"};
            aaa:Console.Write("enter the number ");
            string s_num = Console.ReadLine();
            int num = int.Parse(s_num);

            if(s_num.Length==1){
                Console.WriteLine(singleNumbers[num]);
                goto aaa;
            }else if(s_num.Length==2&&s_num[0]!='0'){
                int firstNumber = (num/10)%10;
                int secondNumber = num%10;
                if (num<20)
                Console.WriteLine(teenNumbers[num-10]);
                else if(num>=20&&secondNumber==0)
                    Console.WriteLine(decimalNumbers[firstNumber-2]);   
                else
                    Console.WriteLine(decimalNumbers[firstNumber-2] +" "+ singleNumbers[secondNumber]);
                    goto aaa;
            }else if(s_num.Length==3&&s_num[0]!='0'){
                int firstNumber = (num/100)%10;
                int secondNumber = (num/10)%10;
                int thirdNumber = num%10;
                if(secondNumber==1)
                    Console.WriteLine(singleNumbers[firstNumber]+" hundred "+teenNumbers[thirdNumber]);
                else if(secondNumber>=2&&thirdNumber==0)
                    Console.WriteLine(singleNumbers[firstNumber]+" hundred and "+decimalNumbers[secondNumber-2]);
                else if(secondNumber==0&&thirdNumber!=0)
                    Console.WriteLine(singleNumbers[firstNumber]+" hundred and "+singleNumbers[thirdNumber]);
                else if(secondNumber==0&&thirdNumber==0)
                    Console.WriteLine(singleNumbers[firstNumber]+" hundred");
                
                else
                    Console.WriteLine(singleNumbers[firstNumber]+" hundred "+decimalNumbers[secondNumber-2] +" "+ singleNumbers[thirdNumber]);
                goto aaa;   
                    
            }
            else{
                Console.WriteLine("can't convert this number");
                goto aaa;
            }

        }
    }
}
