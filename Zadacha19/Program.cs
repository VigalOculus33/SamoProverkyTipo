//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число");
String? number = Console.ReadLine();

void CheckNumber(String Cumming){
    if(number[0] == number[4] && number[1] == number[3]){
    Console.WriteLine($"Ваше число : {number} - палиндром.");
}
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckNumber(number);
}
else Console.WriteLine($"Введите правильное число");
