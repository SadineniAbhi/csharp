namespace employee;
using System;

class Employee
{
    string name;
    string jobName;
    int salary;
    public Employee(string name, string jobName, int salary)
    {
        this.name = name;
        this.jobName = jobName;
        this.salary = salary;
    }

    public void display()
    {
        Console.WriteLine(this.name + " " + this.jobName + " " + this.salary);
    }

}


class Test
{
    public static void Main(string[] args)
    {
        Employee e = new Employee("abhi", "enginner", 100000000);
        e.display();
    }
}
