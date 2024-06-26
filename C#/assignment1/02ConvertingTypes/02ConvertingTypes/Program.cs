// See https://aka.ms/new-console-template for more information

// int max = 500;
//
// for (byte i = 0; i < max; i++)
// {
//     Console.WriteLine(i);
// }

/*
 the  above code will run infinitely because the initialize value i have the type byte, which has maxValue 255.
 When i reach 255, overflow happen and it will return back to 0. As a result the condition i < max is always true
 
 Bellow is the warning code:
*/
// int max = 500;
//
//
// byte previousNumber = 0;
// for (byte i = 0; i < max; i++)
// {
//     if (i < previousNumber)
//     {
//         Console.WriteLine("i is overflow, try to initialize i with a type with larger range");
//         break;
//     }
//
//     previousNumber = i;
//     Console.WriteLine(i);
// }

using _02ConvertingTypes;
// Fizzbuzz.Play();
// RandomGame.Play();
// DrawPyramid.Play();
// Birthdate.Play();
// Greeting.Play();
Counting.Play();