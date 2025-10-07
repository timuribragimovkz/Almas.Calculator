
 Console.WriteLine("Enter the first number: ");
 string firstNumberString = Console.ReadLine();
 if (string.IsNullOrWhiteSpace(firstNumberString)) 
 {
     Console.WriteLine("Number input cannot be empty.");
     Environment.Exit(0);
 }
 if (!firstNumberString.All(char.IsDigit))
 {
     Console.WriteLine("Input value is not a number.");
     Environment.Exit(0);
 }
 var firstNumberInt = Convert.ToInt32(firstNumberString);
 
 Console.WriteLine("Enter the operation.");
 var operation = Console.ReadLine();
 
 Console.WriteLine("Enter the second number: ");
 string secondNumberString = Console.ReadLine();
 if (string.IsNullOrWhiteSpace(secondNumberString)) 
 {
     Console.WriteLine("Input number cannot be empty.");
     Environment.Exit(0);
 }
 if (!firstNumberString.All(char.IsDigit))
 {
     Console.WriteLine("Input value is not a number.");
     Environment.Exit(0);
 } 
 var secondNumberInt = Convert.ToInt32(secondNumberString);
 
 switch (operation)
 {
     case "+":
         var c = firstNumberInt + secondNumberInt;
         Console.WriteLine($"Result of operation = {c}");
         break;
     case "-":
         c = firstNumberInt - secondNumberInt;
         Console.WriteLine($"Result of operation = {c}");
         break;
     case "*":
         c = firstNumberInt * secondNumberInt;
         Console.WriteLine($"Result of operation = {c}");
         break;
     case "/":
         c = firstNumberInt / secondNumberInt;
         Console.WriteLine($"Result of operation = {c}");
         break;
     default:
         Console.WriteLine("Input incorrect operation.");
         break;
 }


 

 