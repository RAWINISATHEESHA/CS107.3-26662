// See https://aka.ms/new-console-template for more information



Console.WriteLine("Enter Employee ID:");
string ID = Console.ReadLine();

Console.WriteLine("Enter Employee Name:");
string Name = Console.ReadLine();

Console.WriteLine("Enter Employee Destination:");
string Destination = Console.ReadLine();

Employee employee = new Employee();

employee.setEmpID(ID);
employee.setEmpName(Name);
employee.setEmpDestination(Destination);

Console.WriteLine(" HEY" + employee.getEmpName() + " YOUR EMPLOYEE ID IS " + employee.getEmpID() + " AND YOU'RE A" + employee.getEmpDestination() );



public class Employee
{
    private string empID;
    private string empName;
    private string empDestination;

    public void setEmpID(string input)
    {
        empID = input;
    }
    public void setEmpName(string input)
    {
        empName = input;
    }
    public void setEmpDestination(string input)
    {
        empDestination = input;
    }
    public string getEmpID()
    {
        return empID;
    }

    public string getEmpName()
    {
        return empName;
    }

    public string getEmpDestination()
    {
        return empDestination;
    }

}
