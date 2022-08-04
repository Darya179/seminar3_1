Console.WriteLine("Введите 5значное число: ");
int n = int.Parse(Console.ReadLine());

String Rezult(int nLoc){

int a = nLoc/10000;
int b = nLoc%10;

int a1 = nLoc%10000/1000;
int b1 = nLoc%100/10;

 if ( a == b && a1 == b1 ){

     return "Палидром";
 }
 else
 {
     return "Не палиндром";
 }
}

Console.WriteLine(Rezult(n));


