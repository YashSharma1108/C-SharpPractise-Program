using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variable
{
    internal class Program
    {
        readonly int EmpId;
        string name;
        double salary;
        //static and const belong to company
        static string address;
        static readonly int leaveWithPayPolicy;
        const int estYear = 2001;
        public Program(int empid,string n,double s)        //constructor will be public because having parameters
        {
            this.EmpId = empid;
            this.name = n;
            this.salary = s;
        }
        static Program()
        {
            address = "noida";
            leaveWithPayPolicy = 2;
        }
        public void getDetails() {
            Console.WriteLine("EmpId\tname\tsalary\taddress\tpolicy leave");
            Console.WriteLine(EmpId+"\t"+name+"\t"+salary+"\t"+address+"\t"+leaveWithPayPolicy);
        }
        public void changeDetails(string n,double s)
        {
            this.name=n; 
            this.salary=s;
        } 

        static void Main(string[] args)
        {
            Program emp1 = new Program(101, "yash", 12000);
            Program emp2 = new Program(102, "sachin", 24000);
            emp1.getDetails();
            emp2.changeDetails("sachin kumar", 24000);
            emp2.getDetails();
            Console.ReadLine();

        }
    }
}
