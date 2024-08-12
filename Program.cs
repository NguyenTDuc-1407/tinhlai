double money ;
int month;
double intersetRate;
Console.WriteLine("Enter investment amount: ");
money = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter number of months: ");
month = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter annual interest rate in percentage: ");
intersetRate =  Convert.ToDouble(Console.ReadLine());
 double totalInterset = 0;
 for(int i = 0; i < month; i++)
{
    totalInterset += money * (intersetRate/100)/12; 
}
Console.WriteLine("Total of interset: " + totalInterset);