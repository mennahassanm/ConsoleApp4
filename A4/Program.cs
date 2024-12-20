using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace A4
{
    #region Q1

    //static void SWAP(int X, int Y)
    //{
    //    int Temp = X;
    //    X = Y;
    //    Y = Temp;
    //}

    //static void SWAP(ref int X, ref int Y)
    //{
    //    int Temp = X;
    //    X = Y;
    //    Y = Temp;
    //} 

    #endregion

    #region Q2

    //static int SumArray(int[] Arr) 
    //{
    //    int sum = 0;

    //    for (int i = 0; i < Arr.Length; i++)
    //    { 
    //        sum += Arr[i];
    //    }
    //    return sum;
    //}

    //static int SumArray(int[] Arr)
    //{
    //    int sum = 0;

    //    Arr[0] = 100;

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        sum += Arr[i];
    //    }
    //    return sum;
    //}

    //static int SumArray(ref int[] Arr)
    //{
    //    int sum = 0;

    //    Arr[0] = 100;

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        sum += Arr[i];
    //    }
    //    return sum;
    //}


    //static int SumArray(int[] Arr)
    //{
    //    int sum = 0;

    //    Arr = new int[] {10, 20 , 30};

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        sum += Arr[i];
    //    }
    //    return sum;
    //}

    //static int SumArray(ref int[] Arr)
    //{
    //    int sum = 0;

    //    Arr = new int[] { 4 , 5 , 6 };

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        sum += Arr[i];
    //    }
    //    return sum;
    //} 

    #endregion

    #region Q3

    //static (int Sum, int Sup) Calculate(int Num1, int Num2, int Num3, int Num4)
    //{
    //    int Sum = Num1 + Num2;
    //    int Sub = Num3 - Num4;
    //    return (Sum, Sub);
    //}

    #endregion

    #region Q4

    //static int Sum(int number)
    //{
    //    int sum = 0;

    //    while (number != 0)
    //    {
    //        sum += number % 10;
    //        number /= 10;
    //    }
    //    return sum;
    //}
    #endregion

    #region Q5

    //static bool IsPrime(int number)
    //{
    //    if (number <= 1)
    //        return false;

    //    for (int i = 2; i <= Math.Sqrt(number); i++)
    //    {
    //        if (number % i == 0)
    //            return false;
    //    }

    //    return true;
    //}

    #endregion

    #region Q6

    //static void MinMaxArray(int[] Arr, ref int min, ref int max)
    //{
    //    min = Arr[0];
    //    max = Arr[0];

    //    foreach (int num in Arr)
    //    {
    //        if (num < min)
    //            min = num;
    //        if (num > max)
    //            max = num;
    //    }
    //}


    #endregion

    #region Q7 

    //static long Iterative(int number)
    //{

    //    long num = 1;

    //    for (int i = 1; i <= number; i++)
    //    {
    //        num *= i;
    //    }

    //    return num;
    //}


    #endregion

    #region Q8

    //static string ChangeChar(string input, int position, char newChar)
    //{
    //    if (string.IsNullOrEmpty(input))
    //        throw new ArgumentException("Input String Cannot Be Null Or Empty.");
    //    if (position < 0 || position >= input.Length)
    //        throw new ArgumentOutOfRangeException(nameof(position), "Position Is Out Of Range.");

    //    return $"{input[..position]}{newChar}{input[(position + 1)..]}";
    //}

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //1.Explain the difference between passing (Value type parameters) by value and by
            //reference then write a suitable c# example

            //Passing By Value 
            //Passing By Reference 

            //Passing Parameter Value Type : 
            //1. Passing By Value ==>Function مش بتتاثر بالقيمه اللي انا بعتها في  

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}"); //4
            //Console.WriteLine($"B : {B}"); //5

            //Console.WriteLine("--------------- After Swap --------------");

            //SWAP(A, B); // Passing By Value 

            //Console.WriteLine($"A : {A}"); //4 
            //Console.WriteLine($"B : {B}"); //5

            //2. Passing By Ref ==> بتتاثر لان بعتلها القيمة نفسها بس بعمله فوق باسم مستعار 

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}"); //4
            //Console.WriteLine($"B : {B}"); //5

            //Console.WriteLine("--------------- After Swap --------------");

            //SWAP(ref A, ref B); // Passing By Value 

            //Console.WriteLine($"A : {A}"); //5
            //Console.WriteLine($"B : {B}"); //4

            #endregion

            #region Q2

            //2.Explain the difference between passing (Reference type parameters) by value and by reference
            //then write a suitable c# example.

            #region EX01
            //Passing Parameter Reference Type
            //1. Passing By Value ==> بتتاثر 

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(Numbers); // Passing By Value 

            ////Console.WriteLine(Result); //6
            //Console.WriteLine(Result); //105

            //Console.WriteLine(Numbers[0]);//100

            //2. Passing By Reference ==> علي حسسب المثال 

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(ref Numbers); // Passing By Ref
            ////The Addres Of The Numbers 

            ////Console.WriteLine(Result); //6
            //Console.WriteLine(Result); //105

            //Console.WriteLine(Numbers[0]);//100

            #endregion

            #region EX02

            //Passing Parameter Reference Type 

            //int [] Numbers = { 1, 2 ,3};
            //Console.WriteLine(SumArray(Numbers)); //Passing By Value //60

            //Console.WriteLine(Numbers[0]); //1


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); //Passing By Ref //15

            ////Copy Of Numbers
            //Console.WriteLine(Numbers[0]); //4

            #endregion

            #endregion

            #region Q3

            ////3. Write a c# Function that accept 4 parameters from user and return result of summation and
            ////subtracting of two numbers


            //Console.Write("Enter the first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter the Last number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //int Num1, Num2, Num3, Num4;
            //do
            //{
            //    Console.WriteLine("Enter Number01 : ");

            //} while (!int.TryParse(Console.ReadLine(), out Num1));

            //do
            //{
            //    Console.WriteLine("Enter Number02 : ");

            //} while (!int.TryParse(Console.ReadLine(), out Num2));

            //do
            //{
            //    Console.WriteLine("Enter Number03 : ");

            //} while (!int.TryParse(Console.ReadLine(), out Num3));

            //do
            //{
            //    Console.WriteLine("Enter Number04 : ");

            //} while (!int.TryParse(Console.ReadLine(), out Num4));

            //(int Sum, int Sub) Result = Calculate(Num1, Num2, Num3, Num4);
            //Console.WriteLine($" Sum = {Num1} + {Num2} = {Result.Sum}");
            //Console.WriteLine($" Sub = {Num3} - {Num4} = {Result.Sub}");

            //Enter Number01 : 30
            //Enter Number02 : 60
            //Enter Number03 : 80
            //Enter Number04 : 30
            // Sum = 30 + 60 = 90
            // Sub = 80 - 30 = 50

            #endregion

            #region Q4

            //4.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //int Num01;
            //bool Flag;

            //do

            //{
            //    Console.Write("Enter a number: ");
            //    Flag = int.TryParse(Console.ReadLine(), out Num01);
            //} while (!Flag);

            //int Reslut = Sum(Num01);
            //Console.WriteLine($"The sum of the digits of the number {Num01} is : {Reslut}");

            // Enter a number: 25
            //The sum of the digits of the number 25 is : 7



            #endregion

            #region Q5

            //5.Create a function named "IsPrime", which receives an integer number and retuns true if it is prime,
            //or false if it is not:

            //Console.Write("Enter a number to check if it is prime: ");
            //int Num = Convert.ToInt32(Console.ReadLine());

            //if (IsPrime(Num))
            //    Console.WriteLine($"{Num} is a prime number.");
            //else
            //    Console.WriteLine($"{Num} is not a prime number.");

            //Enter a number to check if it is prime: 1
            //1 is not a prime number.

            //Enter a number to check if it is prime: 2
            //2 is a prime number.

            #endregion

            #region Q6

            //6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array,
            //using reference parameters

            //int[] numbers = { 10, 20, 30, 40, 50, 60 };

            //int min = 0, max = 0;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine("Minimum : " + min);
            //Console.WriteLine("Maximum : " + max);

            //Minimum : 10
            //Maximum : 60

            #endregion

            #region Q7

            //7.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter a number to calculate its factorial: ");
            //int Num = int.Parse(Console.ReadLine());

            //long result = Iterative(Num);
            //Console.WriteLine($"The factorial of {Num} is: {result}");

            //Enter a number to calculate its factorial: 5
            //The factorial of 5 is: 120

            #endregion

            #region Q8

            //8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string,
            //replacing it with a different letter

            //Console.Write("Enter a String: ");
            //string input = Console.ReadLine();

            //Console.Write("Enter The Position To Change (0-based index): ");
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter The New Character: ");
            //char newChar = Convert.ToChar(Console.ReadLine());

            //try
            //{
            //    string result = ChangeChar(input, position, newChar);
            //    Console.WriteLine($"Modified string: {result}");
            //}
            //catch (Exception E)
            //{
            //    Console.WriteLine("Error: " + E.Message);
            //}

            //Enter a string: Minna
            //Enter the position to change(0 - based index): 1
            //Enter the new character: e
            //Modified string: Menna

            #endregion

            #region Q9

            //9.Write a program that prints an identity matrix using for loop, in other words takes a value n
            //from the user and shows the identity table of size n * n.

            //Console.Write("Enter The Size Of The Identity Matrix (n): ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n <= 0)
            //{
            //    Console.WriteLine("The Size Must Be a Positive Integer.");
            //    return;
            //}

            //Console.WriteLine($"Identity Matrix Of Size {n}x{n}:");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine();
            //}

            //Enter the size of the identity matrix(n): 5
            //Identity Matrix of size 5x5:
            //1 0 0 0 0
            //0 1 0 0 0
            //0 0 1 0 0
            //0 0 0 1 0
            //0 0 0 0 1

            #endregion

            #region Q10

            //10.Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.Write("Enter the number of elements in the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = new int[n];

            //Console.WriteLine("Enter The Elements Of The Array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine($"The Sum Of All Elements In The Array is: {sum}");

            //Enter the number of elements in the array: 5
            //Enter the elements of the array:
            //Element 1: 4
            //Element 2: 6
            //Element 3: 7
            //Element 4: 25
            //Element 5: 6
            //The sum of all elements in the array is: 48

            #endregion

            #region Q11

            //11.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int Size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter The Size Of The Elements : ");
            //    flag = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flag);

            //int[] Array01 = new int[Size];
            //Console.WriteLine("Enter Elements First Array");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Element {i + 1} :");
            //    Array01[i] = int.Parse(Console.ReadLine());
            //}


            //int[] Array02 = new int[Size];
            //Console.WriteLine("Enter Elements Second Array");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Element {i + 1} :");
            //    Array02[i] = int.Parse(Console.ReadLine());
            //}

            //int[] Marray = new int[Size * 2]; 
            //Array01.CopyTo(Marray, 0);
            //Array02.CopyTo(Marray, Size);

            //Array.Sort(Marray);
            //Console.WriteLine("The Merged And Sorted Array is:");
            //foreach (int Element in Marray)
            //{
            //    Console.Write(Element + " ");
            //}

            //Enter The Size Of The Elements : 4
            //Enter Elements First Array
            //Element 1 :8
            //Element 2 :3
            //Element 3 :1
            //Element 4 :5
            //Enter Elements Second Array
            //Element 1 :2
            //Element 2 :4
            //Element 3 :7
            //Element 4 :6
            //The Merged And Sorted Array is:
            //1 2 3 4 5 6 7 8

            #endregion

            #region Q12

            //12.Write a program in C# Sharp to count the frequency of each element of an array.

            //int Size;
            //bool flag;
            //do
            //{
            //    Console.WriteLine("Enter The Size Of The Array:");
            //    flag = int.TryParse(Console.ReadLine(), out Size);
            //} while (!flag);

            //int[] Array = new int[Size];
            //Console.WriteLine("Enter Your The Element Array");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.WriteLine($"Element {i + 1} :");
            //    Array[i] = int.Parse(Console.ReadLine());
            //}


            //Dictionary<int, int> frequency = new Dictionary<int, int>();

            //foreach (int Element in Array)
            //{
            //    if (frequency.ContainsKey(Element))
            //    {
            //        frequency[Element]++;
            //    }
            //    else
            //    {
            //        frequency[Element] = 1;
            //    }
            //}
            //Console.WriteLine("Frequency Of Each Element");
            //foreach (var pair in frequency)
            //{ 
            //    Console.WriteLine($"Element {pair.Key}: {pair.Value} Time(s)");
            //}

            //Enter The Size Of The Array: 5
            //Enter Your The Element Array
            //Element 1 : 2
            //Element 2 : 35
            //Element 3 : 2
            //Element 4 : 46
            //Element 5 : 66
            //Frequency Of Each Element
            //Element 2 : 2 Time(s)
            //Element 35: 1 Time(s)
            //Element 46: 1 Time(s)
            //Element 66: 1 Time(s)

            #endregion

            #region Q13

            //13. Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the size of the array: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (n <= 0)
            //{
            //    Console.WriteLine("Array Must Contain At Least One Element.");
            //    return;
            //}

            //int[] Arr = new int[n];
            //Console.WriteLine("Enter The Elements Of The Array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int max = Arr[0];
            //int min = Arr[0];

            //foreach (int num in Arr)
            //{
            //    if (num > max)
            //    {
            //        max = num; 
            //    }

            //    if (num < min)
            //    {
            //        min = num;  
            //    }
            //}

            //Console.WriteLine("The Maximum Element In The Array is: " + max);
            //Console.WriteLine("The Minimum Element In The Array is: " + min);

            //Enter the size of the array: 5
            //Enter The Elements Of The Array:
            //10
            //20
            //30
            //40
            //50
            //The Maximum Element In The Array is: 50
            //The Minimum Element In The Array is: 10

            #endregion

            #region Q14

            //14.Write a program in C# Sharp to find the second largest element in an array.

            //Console.Write("Enter The Size Of The Array: ");
            //int Size = Convert.ToInt32(Console.ReadLine());

            //if (Size < 2)
            //{
            //    Console.WriteLine("The Array Must Have At Least Two Elements.");
            //    return;
            //}

            //int[] Array = new int[Size];
            //Console.WriteLine("Enter The Elements Of The Array:");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    Array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int Largest = int.MinValue;
            //int SecondLargest = int.MinValue;

            //foreach (int Element in Array)
            //{
            //    if (Element > Largest)
            //    {
            //        SecondLargest = Largest;
            //        Largest = Element;
            //    }
            //    else if (Element > SecondLargest && Element !=  Largest)
            //    {
            //        SecondLargest = Element;
            //    }
            //}

            //if (SecondLargest == int.MinValue)
            //{
            //    Console.WriteLine("No Second Largest Element Found (All Elements May Be The Same).");
            //}
            //else
            //{
            //    Console.WriteLine($"The Second Largest Element is: {SecondLargest}");
            //}

            //Enter The Size Of The Array: 4
            //Enter The Elements Of The Array:
            //Element 1: 100
            //Element 2: 70
            //Element 3: 90
            //Element 4: 50
            //The Second Largest Element is: 90

            #endregion

            #region Q15 , Q16

            //15.Consider an Array of Integer values with size N, having values as in this Example
            //write a program to find the longest distance between Two equal cells. In this example.
            //The distance is measured by the number Of cells- for example, the distance between the
            //first and the fourth cell is 2(cell 2 and cell 3).
            //In the example above, the longest distance is between the first 7 and the
            //10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st
            //And the 10th 7s.

            //Console.Write("Enter The Size Of The Array: ");
            //int Size = Convert.ToInt32(Console.ReadLine());

            //int[] Array = new int[Size];
            //Console.WriteLine("Enter The Elements Of The Array:");
            //for (int i = 0; i < Size; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    Array[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Dictionary<int, int> FirstOccurrence = new Dictionary<int, int>();
            //int maxDistance = 0;

            //for (int i = 0; i < Size; i++)
            //{
            //    if (FirstOccurrence.ContainsKey(Array[i]))
            //    {
            //        int distance = i - FirstOccurrence[Array[i]];
            //        maxDistance = Math.Max(maxDistance, distance);
            //    }
            //    else
            //    {
            //        FirstOccurrence[Array[i]] = i;
            //    }
            //}

            //Console.WriteLine($"The Longest Distance Between Two Equal Cells is: {maxDistance}");

            //Enter The Size Of The Array: 12
            //Enter The Elements Of The Array:
            //Element 1: 7
            //Element 2: 0
            //Element 3: 0
            //Element 4: 0
            //Element 5: 5
            //Element 6: 6
            //Element 7: 7
            //Element 8: 5
            //Element 9: 0
            //Element 10: 7
            //Element 11: 5
            //Element 12: 3
            //The Longest Distance Between Two Equal Cells is: 9

            #endregion

            #region Q17

            //17.Given a list of space separated words, reverse the order of the words.

            //Console.Write("Enter a List Of Space-Separated Words: ");
            //string input = Console.ReadLine();

            //string[] words = input.Split(' ');

            //Array.Reverse(words);
            //string reversed = string.Join(" ", words);
            //Console.WriteLine(reversed);

            #region EX1

            //Enter a List Of Space - Separated Words: this is a test
            //test a is this 

            #endregion

            #region EX2

            //Enter a List Of Space - Separated Words: all your base
            //base your all 

            #endregion

            #region EX3

            //Enter a List Of Space - Separated Words: Word
            //Word 

            #endregion

            #endregion

            #region Q18

            //18.Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array.
            //Now copy all the elements of the first array on second array and print second array.

            //Console.Write("Enter The Number Of Rows: ");
            //int Rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter The Number Of Columns: ");
            //int Cols = Convert.ToInt32(Console.ReadLine());

            //int[,] Array1 = new int[Rows, Cols];
            //int[,] Array2 = new int[Rows, Cols];

            //Console.WriteLine("Enter The Elements Of The First Array:");
            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        Array1[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Array2[i, j] = Array1[i, j];
            //    }
            //}

            //Console.WriteLine("The Elements Of The Second Array are:");
            //for (int i = 0; i < Rows; i++)
            //{
            //    for (int j = 0; j < Cols; j++)
            //    {
            //        Console.Write(Array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Enter The Number Of Rows: 3
            //Enter The Number Of Columns: 3
            //Enter The Elements Of The First Array:
            //Element[0, 0]: 10
            //Element[0, 1]: 40
            //Element[0, 2]: 70
            //Element[1, 0]: 20
            //Element[1, 1]: 50
            //Element[1, 2]: 80
            //Element[2, 0]: 30
            //Element[2, 1]: 60
            //Element[2, 2]: 90
            //The Elements Of The Second Array are:
            //10 40 70
            //20 50 80
            //30 60 90

            #endregion

            #region Q19

            //19.Write a Program to Print One Dimensional Array in Reverse Order

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}

            //Console.WriteLine();

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(numbers[i] + " ");
            //}


            //10 20 30 40 50
            //50 40 30 20 10

            #endregion
        }
    }
}
