// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
//Ввод чисел останавливается при помощи ввода 
//стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.WriteLine ("This Program will help you to count how many positive numbers are entered.Enjoy.");
 int num;
 int count=0;
 string stopWord ="stop";

 while (true)
 {
    Console.WriteLine ("Enter number here or enter <stop> to continue:");
    string answer = Console.ReadLine();
    if (answer == stopWord)
    {
        break;
    }
    num = Convert.ToInt32(answer);
    if (num>0) count++;
 }

Console.WriteLine($"Count of positive numbers: {count}");