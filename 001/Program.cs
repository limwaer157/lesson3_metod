// Mетод 4 который принимает и возвращает 

string Metod4(int count, string text )
{
   int i = 0 ;
   string result = "";
   while (i < count)
   {
     i = i + 1 ;
     result = result + text;    

   }
   return result;
}
string res =  Metod4(10, "asdf");
Console.WriteLine(res);

// // Метод с функцией FOR
// string Metod5(int count1, string text1 )
// {
//    string result1 = "";
//    for  (int index = 0; index < count1 ; index = index + 1)
//    {
//     result1 = result1 + text1;    
//    }
//    return result1;
// }
// string result1 =  Metod5(13, "пёс_");
// // Console.WriteLine(result1);
// //string res =  Metod4(10, "asdf");
// //Console.WriteLine(res);



// // Вид метод 1
// void Metod1()
// {
//     Console.WriteLine("Denis");
// }

// // Metod1();


// // Метод 2 


// void Metod2 (string msg)
// {
//    Console.WriteLine(msg);
// }
// //Metod2("Text");

// void Metod21 (string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i = i + 1;
//     }
   
// }
// //Metod21(msg: "Dog", count: 1);
// //Metod21(count: 1, msg: "New Text");

// Метод 3 только возвращает но не принимает 

// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int Year = Metod3();
// //Console.WriteLine(Year);

for( int i = 2; i <=  10; i = i + 1)
{
    for ( int j = 0; j <= 10; j = j + 1 )
    {
        Console.WriteLine($"{ i } * { j } = { i * j }");
    }
    Console.WriteLine();
}