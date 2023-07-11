// See https://aka.ms/new-console-template for more information



Console.WriteLine("ENTER NUMBER 1 : ");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ENTER NUMBER 2 : ");
int num2 = int.Parse(Console.ReadLine());

Calculation calculation = new Calculation();

calculation.setValues(num1, num2);

Console.WriteLine("SUMMATION : " + calculation.getSummation());
Console.WriteLine("SUBTRACTION : " + calculation.getSubtraction());
Console.WriteLine("MULTIPLICATION : " + calculation.getMultiplication());
Console.WriteLine("DIVISION : " + calculation.getDivision());




public class Calculation
{
    private double number1;
    private double number2;

    public void setValues( double num1, double num2)
    {
        number1 = num1;
        number2 = num2;
    }

    public double getSummation()
    {
        return number1 + number2;
    }
    public double getSubtraction()
    {
        return number1 - number2;
    }

    public double getMultiplication()
    {
        return number1 * number2;
    }
    public double getDivision()
    {
        return number1 / number2;
    }


}
