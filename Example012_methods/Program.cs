Console.Clear();


// Вид методов 1 не принимаю и не возвращают


//void Method1()
//{
//    Console.WriteLine("Author...");
//}
//Method1();

// Вид методов 2 принимают и не возвращают


//void Method2(string msg)
//{
    //Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

//void Method21(string msg, int count)
//{
  //  int i = 0;
  //  while(i < count)
  //  {
 //       Console.WriteLine(msg);
 //       i++;
 //   }
//}
//Method21(msg: "Текст", count: 4);
//Method21(count: 4, msg: "новый текст");



// Вид методов 3 не принимают и возвращают

int Method3()
{
    
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);



// Вид методов 4 принимают и возвращают

//string Method4(int count, string c)
//{
   // int i = 0;
    //string result = String.Empty;
    //while(i < count)
   // {
  //   result = result + c;
  //   i++;
  //  }
  //  return result;
//}
//string res = Method4(10, "z");
//Console.WriteLine(res);

string Method4(int count, string c)
{string result = String.Empty;
for(int i = 0; i < count; i++)

     {result = result + c;}
    return result;
}
string res = Method4(10, "z");
//Console.WriteLine(res);

for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
     Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}