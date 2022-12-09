//Метод1
// void Metod1()
// {
//     System.Console.WriteLine("Автор проекта...");
// }

// Metod1();

//Вид2

// void Metod2(string msg)
// {
//     System.Console.WriteLine(msg);
// }
// Metod2(msg:"Текст сообщения");

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         System.Console.WriteLine(msg);
//         i++;
//     }
// }
// Metod21("Текст", 4);

// //метод3
// int Metod3()
// {
//     return DateTime.Now.Year;

// }
// int year = Metod3();
// System.Console.WriteLine(year);

// //метод4
// string Metod4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result=result + c;
//         i++; 
//     }
//     return result;

// }
// string res = Metod4(10, "Bye-");
// System.Console.WriteLine(res);

//метод4
// string Metod4(int count, string text)
// {
//     string result = String.Empty;
//     for (int i=0; i < count; i++)
//     {
//         result=result + text;

//     }
//     return result;

// }
// string res = Metod4(10, "Bye-");
// System.Console.WriteLine(res);

// for в for
//  for (int i=2; i <= 10; i++)
//  {
//     for (int j = 2; j<=10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i*j} ");
//     }
//     System.Console.WriteLine("");
//  }


 string text = "Палиндром - это слово, фраза или ряд чисел, которые читаются одинаково как вперед, так и назад."
                + "Палиндромы могут быть очень короткими."

                + "Например, слово Поп - это палиндром."
                + "Аргентина манит негра";
// string s = "qwerty";
// s[3] = r

string Replase( string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;

}
string newText = Replase(text, ' ', '|');
System.Console.WriteLine(newText);
System.Console.WriteLine("");

string Replase2( string newText, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = newText.Length;
    for (int i = 0; i < length; i++)
    {
        if (newText[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{newText[i]}";
    }
    return result;

}
string newText2 = Replase2(newText, 'к', 'К');
System.Console.WriteLine(newText2);