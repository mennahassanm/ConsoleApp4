namespace Program
{

    //1. Class      ==>Functions
    //2. Struct     ==>Functions
    //3. Interface  ==> Functions
    //4. Enum 

    // -------------- 2 ------------

    class NewData
    {
        public int Sum;
        public int Mul;
    }

    internal class Program
    {
        // Entry Point 

        //static void PrintShape()
        //{
        //    //Body
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }
        //}


        //static void PrintShape(int Count)
        //{
        //    //Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine("^_^");
        //    }
        //}


        //static void PrintShape(int Count , string Pattern)
        //{
        //    //Body
        //    for (int i = 1; i <=Count ; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static void PrintShape( string Pattern , int Count = 4)
        //{
        //    //Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static void PrintShape(string Pattern = "*_*", int Count = 4)
        //{
        //    //Body
        //    for (int i = 1; i <= Count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}

        //static int SumNumbers(int Number01, int Number02)
        //{
        //    return Number01 + Number02;
        //}

        //static void SWAP (int X , int Y)
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

        //------------- 1 -------------

        //static int[] SumMul (int X , int Y)
        //{
        //    int[] Result = { X + Y, X * Y };
        //    return Result;
        //}

        // ------------- 2 -------------

        //static NewData SumMul(int X, int Y)
        //{
        //    NewData data = new NewData();
        //    data.Sum = X + Y;
        //    data.Mul = X * Y;
        //    return data;
        //}

        //Passing By Out 
        //static void SumMul(int X, int Y,out int Sum,out int Mull)
        //{
        //    Sum = Y + X ;
        //    Mull = Y * X ; 
        //}

        //static int SumArray(int[] Arr )
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    { 
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //static int SumArray(params int[] Arr)
        //{
        //    int Sum = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        static void Main(string[] args)
        {

            #region One D Array

            //int[] Numbers;
            ////Declare For Reference (Pointer) From Type 'Array Of Integers'
            ////Number : Can Refer To Object From Type 'Array Of Integers'
            ////Number : Refer To Null

            ////8 Bytes Will Be Allocated At Stack For The Reference 'Number'
            ////0 Bytes Will Be Allocated At Heap

            ////Number = new int[Size];

            //Numbers = new int[5];

            ////New :
            ////1. Allocate The Number Of Required Bytes For The Object At HEAP (4 Bytes * 5) =20
            ////2. Initialized The Allocated Bytes With The Default Value Of The Datatype
            ////3. Call User-Defind Constructor is Exists
            ////4. Assign The Object To Reference 'Numbers'

            ////Console.WriteLine(Numbers[0]); //0

            ////Console.WriteLine(Numbers[1]); //0

            ////Numbers[0] = 12;
            ////Numbers[1] = 6;
            ////Numbers[2] = 7;
            ////Numbers[3] = 11;
            ////Numbers[4] = 19;
            ////Numbers[5] = 20; // oUT Of Range

            ////Console.WriteLine(Numbers[0]);
            ////Console.WriteLine(Numbers[1]);
            ////Console.WriteLine(Numbers[2]);
            ////Console.WriteLine(Numbers[3]);
            ////Console.WriteLine(Numbers[4]);

            ////int[] Numbers01 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            ////int[] Numbers02 = new int[4] { 1,2, 3, 4 };

            ////int[] Numbers03 = new int[] { 1, 2, 3, 4 };

            ////int[] Numbers04 = new int[7];

            ////Console.WriteLine(value: "Enter Numbers [0] : ");
            ////Numbers[0] = int .Parse(Console.ReadLine());

            ////Console.WriteLine(value: "Enter Numbers [1] : ");
            ////Numbers[1] = int.Parse(Console.ReadLine());

            ////Console.WriteLine(value: "Enter Numbers [2] : ");
            ////Numbers[2] = int.Parse(Console.ReadLine());

            ////Console.WriteLine(value: "Enter Numbers [3] : ");
            ////Numbers[3] = int.Parse(Console.ReadLine());

            ////Console.WriteLine(value: "Enter Numbers [4 ] : ");
            ////Numbers[4] = int.Parse(Console.ReadLine());

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(value:$"Enter Numbers [{i}] : " );
            ////    Numbers[i] = int.Parse(Console.ReadLine());
            ////}

            ////Console.WriteLine(value: "============================");

            ////for (int i = 0; i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(value:$"{Numbers[i]}" );
            ////}

            ////One D Array

            //Console.WriteLine(Numbers.Length); //5

            //Console.WriteLine(Numbers.Rank); //Dimension 1

            //Console.WriteLine(Numbers); //System.Int32[] 

            #endregion

            #region Two D Array (Rectangle Array)

            ////Two D Array 

            //int[,] Marks = new int[3, 3];

            ////Marks[0, 0] = 99;
            ////Marks[0, 1] = 99;
            ////Marks[0, 2] = 99;

            ////Marks[1, 0] = 80;
            ////Marks[1, 1] = 98;
            ////Marks[1, 2] = 97;

            ////Marks[2, 0] = 88;
            ////Marks[2, 1] = 78;
            ////Marks[2, 2] = 47;

            ////Console.WriteLine(Marks[0,0]);
            ////Console.WriteLine(Marks[0,1]);
            ////Console.WriteLine(Marks[0,2]);

            ////Console.WriteLine(Marks[1, 0]);
            ////Console.WriteLine(Marks[1, 1]);
            ////Console.WriteLine(Marks[1, 2]);

            ////Console.WriteLine(Marks[2, 0]);
            ////Console.WriteLine(Marks[2, 1]);
            ////Console.WriteLine(Marks[2, 2]);

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 3; j++)
            ////    {
            ////        Console.WriteLine(value: $"Enter Marks [{i} , {j}] : ");
            ////        Marks[i, j] = int.Parse(Console.ReadLine());
            ////    }
            ////}

            ////Console.WriteLine();

            ////for (int i = 0; i < 3; i++)
            ////{
            ////    for (int j = 0; j < 3; j++)
            ////    {
            ////        Console.WriteLine(value: $"{Marks[i,j]}  ");
            ////    }

            ////    Console.WriteLine();

            ////} 

            #endregion

            #region Two D Array (Juddge Array)

            //int[][] Marks =new int[3][];

            //Marks[0] = new int[] { 1, 2, 3 };

            //Marks[1] = new int[] { 1, 2 };

            //Marks[2] = new int[] { 1, 2, 3, 4 };


            //int[][] Marks = new int[3][];

            //Marks[0] = new int[2] ;

            //Marks[1] = new int[5] ;

            //Marks[2] = new int[1] ;

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine(value: $"Marks[{i} {j}] : ");
            //        Marks[i][j] = int.Parse(Console.ReadLine()) ;
            //    }

            //}


            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.WriteLine(value: $"{ Marks[i][j] }");
            //    }

            //}

            #endregion

            #region Function Prototype 

            //Functions : Block Of Code That Have Name If U Need To Execute This Code
            //U Need To Call The Function By The Name
            //DRY

            // Function prototype
            // 1. Signature
            //1.1. Name 
            //1.2. Retrun Type 
            //1.3. Parameters (Inputs)

            // 2. Body (Code)


            //Calling For The Functions

            //PrintShape(3);
            //PrintShape(Count: 5, Pattern: "0_0"); // Passin By Order
            //PrintShape(Pattern: "*_*", Count: 5 );
            //PrintShape(Pattern: "#_#");
            //PrintShape();

            //Methods 
            //1. Class Memeber Method (Static Method)
            //2. Object Memeber Method  (Non Static Method)


            //int Sum = SumNumbers(2, 3);
            // Console.WriteLine(Sum); //5

            //Console.WriteLine(SumNumbers(2, 3)); //5 

            #endregion

            #region Passing Parameter Value Type

            //Passing By Value 
            //Passing By Reference 

            //Passing Parameter Value Type : 
            //1. Passing By Value 

            //int A = 4 ,B = 5;

            //Console.WriteLine($"A : {A}"); //4
            //Console.WriteLine($"B : {B}"); //5

            //Console.WriteLine("--------------- After Swap --------------");

            //SWAP(A, B); // Passing By Value 

            //Console.WriteLine($"A : {A}"); //4 
            //Console.WriteLine($"B : {B}"); //5

            //2. Passing By Ref

            //int A = 4, B = 5;

            //Console.WriteLine($"A : {A}"); //4
            //Console.WriteLine($"B : {B}"); //5

            //Console.WriteLine("--------------- After Swap --------------");

            //SWAP(ref A,ref  B); // Passing By Value 

            //Console.WriteLine($"A : {A}"); //5
            //Console.WriteLine($"B : {B}"); //4

            #endregion

            #region Passing Parameter Reference Type EX01

            //Passing Parameter Reference Type
            //1. Passing By Value 

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(Numbers); // Passing By Value 

            ////Console.WriteLine(Result); //6
            //Console.WriteLine(Result); //105

            //Console.WriteLine(Numbers[0]);//100

            //2. Passing By Reference

            //int[] Numbers = { 1, 2, 3 };

            //int Result = SumArray(ref Numbers); // Passing By Ref
            ////The Addres Of The Numbers 

            ////Console.WriteLine(Result); //6
            //Console.WriteLine(Result); //105

            //Console.WriteLine(Numbers[0]);//100

            #endregion

            #region Passing Parameter Reference Type EX02

            //Passing Parameter Reference Type 

            //int [] Numbers = { 1, 2 ,3};
            //Console.WriteLine(SumArray(Numbers)); //Passing By Value //60

            //Console.WriteLine(Numbers[0]); //1


            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Numbers)); //Passing By Ref //15

            ////Copy Of Numbers
            //Console.WriteLine(Numbers[0]); //4

            #endregion

            #region Passing By Out 

            //--------- 1 ----------

            //int A = 3 ; int B = 4;

            //int[] Result  = SumMul (A, B);

            //Console.WriteLine(Result[0]); //7
            //Console.WriteLine(Result[1]); //12

            //Console.WriteLine(SumMul(A , B )); //System.Int32[]

            //---------- 2 ----------

            //int A = 3; int B = 4;

            //NewData Result = SumMul(A, B);

            //Console.WriteLine(Result.Sum); //7
            //Console.WriteLine(Result.Mul); //12

            //Output Paramters 
            //Passing By Out 

            //int A = 4, B = 5, Sum, Mull;

            //SumMul (A, B ,out Sum ,out Mull);

            //Console.WriteLine(Sum);//9
            //Console.WriteLine(Mull); //20


            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out int Mull);

            //Console.WriteLine(Sum);//9
            //Console.WriteLine(Mull); //20

            //int A = 4, B = 5;

            //SumMul(A, B, out int Sum, out _);

            //Console.WriteLine(Sum); // 9 

            #endregion

            #region Params 

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SumArray(Numbers)); //28

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(SumArray(1, 2, 3, 4, 5, 6, 7)); //28


            #endregion

        }
    }
}
