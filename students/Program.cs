using System;
using System.Collections.Generic;
namespace students
{
    class Program
    {
        static string topStudet(Dictionary<string,object> topDegrees){
            string f = "";
            int s=0;
            foreach (var deg in topDegrees)
            {
                if ((int)deg.Value>s){
                    s = (int)deg.Value;
                    f = deg.Key;
                }
            }
            return f;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of students");
            int n = int.Parse(Console.ReadLine());
            Dictionary<string,object> students = new Dictionary<string,object>();
            for(int i = 0;i<n;i++){
                Console.WriteLine("enter student "+(i+1)+" name");
                string name = Console.ReadLine();
                Console.WriteLine("enter his degree");
                int deg = int.Parse(Console.ReadLine());
                students.Add(name,deg);
            }
           aaa:Console.WriteLine("choose an option from the following menu\n====================================");
            Console.WriteLine("[1] Search for student name and degree\n[2] Get top student name and degree\n[3] Change a student name");
            int s = int.Parse(Console.ReadLine());
            if(s==1){
                    Console.WriteLine("please enter the student name");
                    string a = Console.ReadLine();
                    bool z= false;
                    foreach(var name in students){
                        if (a == name.Key)
                        z = true;
                    }
                    if(z==true)
                    Console.WriteLine("student name: "+a+"\nstudent degree: "+students[a]);
                    else
                    Console.WriteLine("student not found");
            }else if(s==2){
                 Console.WriteLine("top student is: "+topStudet(students));
            }else if (s==3){
                Console.WriteLine("Please enter the student name");
                string ch = Console.ReadLine();
                object v = 0;
                bool x = false;
                foreach(var deg in students){
                    if (deg.Key==ch){
                        v = deg.Value;
                        x = true;
                    }
                }
                if (x==true){
                    Console.WriteLine("Enter the new name");
                students.Add(Console.ReadLine(), v);
                }else {
                    Console.WriteLine("student not found");
                    goto aaa;
                }
            }else{
                Console.WriteLine("please enter a valid number");
            }
            goto aaa;
        }
    }
}
