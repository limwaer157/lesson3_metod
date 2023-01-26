// Дан текст в тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменнить большими, а большие буквы "С" маленькими

string text = "- Я думаю, - сказал князь, улыбаясь, - что "
            + "ежели  бы вас послали вместо нашего милого Винценгероде"
            + "вы бы взяли приступом согласие русского короля."
            + "вы так красноречивы. Вы дадите мне чаю";

string Replace(string text, char oldValue, char newValue )
{
      string result = "";
      int lenght = text.Length;
     for (int i = 0; i < lenght; i = i + 1)
     {
       if (text[i] == oldValue) result = result + $"{newValue}";
       else result =   result + $"{text[i]}";
     }
       return result;
}
string newText = Replace(text,' ','*');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText,'с','С');
Console.WriteLine(newText);