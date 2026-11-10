// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine(IsDivisible(a, b).ToString().ToLower());

// bool IsDivisible(int a, int b)
// {
//     return a % b == 0;
// }

// int a = int.Parse(Console.ReadLine());

//  Console.WriteLine(GetNumberType(a));

//  string GetNumberType(int a){
//     if(a % 2 == 0)
//     {
//         return "Even";
//     }
//      else
//     {
//         return "Odd";
//     }
//  }
// task 3
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine(CountNumbers(a, b));

// int CountNumbers(int a, int b)
// {
//     int min = a;
//     int max = b;
//     if (a > b)
//     {
//       min = b;
//  max = a;
//     }

//     int count = 0;
//     for (int i = min + 1; i < max; i++)
//     {
//        count++;
//     }
//     return count;
// }
// task4
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine(SumFromOne(a));

// int SumFromOne(int a)
// {
//     int sum = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// task 5 
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine(Factorial(a));

// int Factorial(int a)
// {
//     int res = 1;
//     for (int i = 1; i <= a; i++)
//     {
//         res *= i;
//     }
//     return res;
// }

// task 6


// int a = int.Parse(Console.ReadLine());

// Console.WriteLine(ReverseNumber(a));

// int ReverseNumber(int a)
// {
//     int s = 0;
//     while (a > 0)
//     {
//         s = s * 10 + a % 10;
//         a /= 10;
//     }
//     return s;
// }

//  int a = int.Parse(Console.ReadLine());
// System.Console.WriteLine(Rass(a));

// int Rass(int a)
// {
//     int s=0;
//     for(int i=a ; i>0 ; i/=10)s++;
//     return s;
// }



//hmtk1


// int n = int.Parse(Console.ReadLine());
// Print(1, n);
// Console.WriteLine();

// void Print(int i, int n)
// {
//     if (i > n) return;

//     Console.Write(i);
//     if (i < n) Console.Write(" ");

//     Print(i + 1, n);
// }


//hmtk2

// int n = int.Parse(Console.ReadLine());
// Print(n);
// Console.WriteLine();

// void Print(int i)
// {
//     if (i < 1) return;

//     Console.Write(i);
//     if (i > 1) Console.Write(" ");

//     Print(i - 1);
// }

//hmtk3


// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(Sum(n));

// int Sum(int i)
// {
//     if (i <= 0) return 0;

//     return i + Sum(i - 1);
// }


//
//hmtk4

// int n = int.Parse(Console.ReadLine());
// Clas(n);
// Console.WriteLine();

// void Clas(int x)
// {
//     if (x == 0) return;

//     Clas(x / 10); 
//     Console.Write(x % 10 + " ");
// }

//hmtk5

// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(CountDigits(n) + " ");

// int Rass(int x)
// {
//     if (x == 0) return 0;

//     return 1 + Rass(x / 10);
// }

//hmtk6

// int n=int.Parse(Console.ReadLine());

// Console.WriteLine(IsEven(n));

// bool IsEven(int n){
//     return n%2==0;

// }

//task7
// int a=int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// Console.WriteLine(Max3(a , b, c));

// int Max3(int a , int b , int c){
//     int max = a;
//     if(b > max) max=b;
//     if( c > max) max = c;

//     return max;
// }

//task8
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine(SumOfDigits(n));

// int SumOfDigits(int number)
// {
//     int sum = 0;

//     for (; number != 0; number /= 10)
//     {
//         sum += Math.Abs(number % 10);
//     }

//     return sum;
// }


//task9
