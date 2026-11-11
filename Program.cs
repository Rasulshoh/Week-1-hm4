
//
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());

// Console.WriteLine(FindMid(a , b , c));

// int FindMid(int a, int b, int c){

//     int max = a;
//     if(b > max) max=b;
//     if(c<max) max=c;
//     return max;
// }

//task2

//  int a = int.Parse(Console.ReadLine());
//  int b = int.Parse(Console.ReadLine());

//   Console.WriteLine(hama(a , b));

//   bool hama(int a , int b){
//     if(a > 0 && b > 0)
//     {
//         return true;
//     }
//      return false;
//   }

// task 3

//   int n = int.Parse(Console.ReadLine());

// Console.WriteLine(NON(n));

// int NON(int n)
// {
//     n = Math.Abs(n);
//     int c = 0;
//     for (int t = n; t > 0; t /= 10)
//     {
//         c++;
//     }
//     for (int i = 0; i < c / 2; i++)
//     {
//         n /= 10;
//     }
//     return n % 10;
// }

//


//  string name = Console.ReadLine();

//   Console.WriteLine(Lengt(name));

//   string Lengt(string name)
// {
//     string f=0;
//     for(int i=name ; i > 0 ; i--)
//     {
//         f=i;

//         if( name == f){
//              return truel;
//         }
//         else
//         {
//             return false;
//             // Console.WriteLine("Not Palidrom");

//         }
//     }






// }

// string name = Console.ReadLine();

// Console.WriteLine(Lengt(name));

// bool Lengt(string name)
// {
//     string rev = "";
//     for (int i = name.Length - 1; i >= 0; i--)
//     {
//         rev += name[i];
//     }
//     return name == rev;
// }

//

// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(End(n));

// int End(int n)
// {
//     int c =0;
//     for( ; n > 0 ; n /= 10)
//     {
//         c+=n%10;
//     }
//     return c;
// }

//

// string name = Console.ReadLine();
// Console.WriteLine(len(name));

// string len(string name){
//     string rev = "";
//     for(int i=name.Length-1  ; i >=0 ; i-- ){
//         rev+=name[i];
//     }
//       return rev;
// }

//

// Console.WriteLine(PowN(5 , 3));

// int PowN(int a , int n){
//     if( n == 0)
//     {
//         return 1;
// //     }
// //      return a*PowN(a , n-1);
// // }

// //

// int n = int.Parse(Console.ReadLine());

// for (int i = 0; i < n; i++)
// {
//     Console.Write(Fib(i) + " ");
// }

// int Fib(int k)
// {
//     if (k == 0) return 0;
//     if (k == 1) return 1;
//     return Fib(k - 1) + Fib(k - 2);
// }

//hmt1
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Even : " + EvenCount(n));
// Console.WriteLine("Odd : " + OddCount(n));
// Console.WriteLine("Zero : " + ZeroCount(n));
// Console.WriteLine("Digits :" + DigitCount(n));
// Console.WriteLine("Min : " + MinDigit(n));
// Console.WriteLine("Max : " + MaxDigit(n));
// Console.WriteLine("Sum : " + SumDigit(n));

// int EvenCount(int n)
// {
//     n = Math.Abs(n);
//     int c = 0;
//     for (; n > 0; n /= 10)
//     {
//         if (n % 10 % 2 == 0)
//         {
//             c++;
//         }
//     }
//     return c;
// }

// int OddCount(int n)
// {
//     n = Math.Abs(n);
//     int c = 0;
//     for (; n > 0; n /= 10)
//     {
//         if (n % 10 % 2 != 0)
//         {
//             c++;
//         }
//     }
//     return c;
// }

// int ZeroCount(int n)
// {
//     n = Math.Abs(n);
//     if (n == 0) return 1;
//     int c = 0;
//     for (; n > 0; n /= 10)
//     {
//         if (n % 10 == 0)
//         {
//             c++;
//         }
//     }
//     return c;
// }

// int DigitCount(int n)
// {
//     n = Math.Abs(n);
//     if (n == 0) return 1;
//     int c = 0;
//     for (; n > 0; n /= 10)
//     {
//         c++;
//     }
//     return c;
// }

// int MinDigit(int n){
//     n=Math.Abs(n);
//     int min = 9;
//     if(n==0)return 0;
//     for(; n>0 ; n/=10){
//         if(n%10 < min){
//             min=n%10;
//         }

//     }
//      return min;
// }
 
//   int MaxDigit(int n){
//     n=Math.Abs(n);
//     int max=0;
//     if(n==0)return 0;
//     for( ; n > 0 ; n /=10){
//         if(n % 10 > max){
//             max=n%10;
//         }

//     }
//      return max;
//   }
//   int SumDigit(int n){
//     n=Math.Abs(n);
//     if(n==0)return 0;
//     int sum=0;
//     for(; n > 0 ; n /= 10 ){
//          sum+=n%10;
//     }
//     return sum;
//   }

//2
// int n = int.Parse(Console.ReadLine());
//  System.Console.WriteLine(CheckGrade(n));
// char CheckGrade(int n){
//     if( n>=90 && n >= 100){
//         return 'A';
//     }
//      else if( n >=80){
//         return 'B';
//      }
//       else if(n >= 70){
//         return 'C';
//       }
//       else if(n >=60){
//         return 'D';
//       }
//       else {
//         return 'F';
//       }
     
// }

//3
// int n = int.Parse(Console.ReadLine());

// int[] arr = new int [n];
// for(int i = 0 ; i< n ; i++){
//    arr[i]=int.Parse(Console.ReadLine());

// }
//   int neg = 0 , pos= 0 , zer = 0 , eve=0, odd = 0  , sum = 0 ;
//  int max = arr[0];
//  int min = arr[0];
//  for(int i = 0 ; i < n ; i++){
//     int x=arr[i];
//     if(x<0)neg++;
//     else if(x>0)pos++;
//     else zer++;

//     if( x % 2 ==0) eve++;
//     else odd++;

//     if(x > max) max = x;
//     if( x < min) min = x ;
//     sum+=x;

//  }
//   System.Console.WriteLine("Negative : " + neg);
//   System.Console.WriteLine("Positive : " + pos);
//   System.Console.WriteLine("Zeros : " + zer);
//   System.Console.WriteLine("Even : " + eve );
//   System.Console.WriteLine("Odd : " + odd);
//   System.Console.WriteLine("Max : " + max);
//   System.Console.WriteLine("Min : " + min);
//   System.Console.WriteLine("Sum of Digits : " + sum);

//4
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }

// for (int i = 0; i < n; i += 2)
// {
//     Console.Write(arr[i] + " ");
// }

//5
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }

// int count = 0;
// for (int i = 1; i < n; i++)
// {
//     if (arr[i] > arr[i - 1])
//     {
//         count++;
//     }
// }

// Console.WriteLine(count);

//6
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];

// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         if (arr[j] == arr[i])
//         {
//             Ras = false;
//         }
//     }

//     if (Ras == false)
//     {
//         continue;
//     }
//     int count = 0;
//     for (int j = 0; j < n; j++)
//     {
//         if (arr[j] == arr[i])
//         {
//             count++;
//         }
//     }

//     if (count > 1)
//     {
//         Console.Write(arr[i] + " ");
//     }
// }


//7

// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());

// for(int i=x ; i<=y ; i++){
//     for(int j=1 ; j<=10 ; j++){
//         Console.WriteLine(i + " * " + j + " = "+ i * j);
//     }
// }

//7
// int a = int.Parse(Console.ReadLine());
// char v  = char.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// if(v == '+'){
//     System.Console.WriteLine( a + " + " + b + " = " + (a+b));
// }
//  else if(v== '-'){
//     System.Console.WriteLine( a + " - " + b + " = " + (a-b));
//  }

//  else if( v == '*'){
//     System.Console.WriteLine( a + " * " + b + " = " + (a*b));
//  }
//   else if( v=='/'){
//     System.Console.WriteLine(a + " / " + b + " = " + (a/b));
//   }
//   else{
//     System.Console.WriteLine("NON");
//   }
 


 //8

//  int a = int.Parse(Console.ReadLine());
//  int b = int.Parse(Console.ReadLine());

//  Console.WriteLine(Pow(a , b ));

//  int Pow (int a , int b){
//         if(b==0)return 1;
//         if( b < 0) return 1 / Pow(a , -b);
//         return a * Pow(a , b-1);
//  }

//9
 int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write(Fib(i) + " ");
}

int Fib(int k)
{
    if (k == 0) return 0;
    if (k == 1) return 1;
    return Fib(k - 1) + Fib(k - 2);
}



///