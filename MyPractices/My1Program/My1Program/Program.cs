decimal firstNumberInput;
decimal secondNumberInput;
decimal total;
decimal grade;
int operationInput;

bool exit = false;

while (!exit)
{
Console.WriteLine("CALCULATOR");
Console.WriteLine("Add");
Console.WriteLine("ubtract");
Console.WriteLine("Multiply");
Console.WriteLine("ivide");
Console.WriteLine("Student Result");
Console.WriteLine("Exit");
Console.Write("Choose an option: ");

try{
operationInput = Convert.ToInt32(Console.ReadLine());

switch (operationInput){
case 1:
Console.Write("First number: ");
firstNumberInput = Convert.ToDecimal(Console.ReadLine());

Console.Write("Second number: ");
secondNumberInput = Convert.ToDecimal(Console.ReadLine());

total = firstNumberInput + secondNumberInput;

Console.WriteLine($"Result: {total}");
break;

case 2:
Console.Write("First number: ");
firstNumberInput = Convert.ToDecimal(Console.ReadLine());

Console.Write("Second number: ");
secondNumberInput = Convert.ToDecimal(Console.ReadLine());

total = firstNumberInput - secondNumberInput;

Console.WriteLine($"Result: {total}");
break;

case 3:
Console.Write("First number: ");
firstNumberInput = Convert.ToDecimal(Console.ReadLine());

Console.Write("Second number: ");
secondNumberInput = Convert.ToDecimal(Console.ReadLine());

total = firstNumberInput * secondNumberInput;

Console.WriteLine($"Result: {total}");
break;

case 4:
Console.Write("First number: ");
firstNumberInput = Convert.ToDecimal(Console.ReadLine());

Console.Write("Second number: ");
secondNumberInput = Convert.ToDecimal(Console.ReadLine());

if (secondNumberInput == 0){
Console.WriteLine("Cannot divide by zero.");
}
else{
total = firstNumberInput / secondNumberInput;
Console.WriteLine($"Result: {total}");
}
break;

case 5:
Console.Write("Enter student grade: ");
grade = Convert.ToDecimal(Console.ReadLine());

if (grade >= 70){
Console.WriteLine("Student Approved");}
else{
Console.WriteLine("Student Failed");}
break;

case 0:
exit = true;
Console.WriteLine("Program closed.");
break;

default:
Console.WriteLine("Invalid option.");
break;
}
}
catch
{
Console.WriteLine("Invalid data entered.");
}
}