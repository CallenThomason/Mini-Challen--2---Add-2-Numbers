/* 
Callen Thomason
Mini Challenge Two Add 2 Numbers
I used ReadLine to get data from the user as a string, and Convert.ToInt32 to make it an int. Then I found the sum and used interpolation to print the data.
Peer Review name: 
Review: 
include a png of flowchart
*/


Console.Clear(); 
Console.Write("Input a number: ");
String num1 = Console.ReadLine();
Console.Write("Input another number: ");
String num2 = Console.ReadLine(); 
int realNum1 = Convert.ToInt32(num1); //converts the strings to int 
int realNum2 = Convert.ToInt32(num2);
int sum = realNum1 + realNum2; //adds the two new integers
Console.WriteLine($"The sum of your two numbers is: {sum}"); //prints everything
