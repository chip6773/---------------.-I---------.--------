﻿// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, 
//    если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения
//    (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом
//    (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// СОБСТНА, РЕШЕНИЕ:

// здесь метод выбора массива для проверки
string [] ChooseEx(string [] arr1, string [] arr2, string [] arr3)
{
    
    Console.Write("выберете массив для проверки:");
    Console.Write("1 -> [“Hello”, “2”, “world”, “:-)”]");
    Console.Write($"2 -> [“1234”, “1567”, “-2”, “computer science”]");
    Console.Write($"3 -> [“Russia”, “Denmark”, “Kazan”]");
    Console.Write($"4 -> ваш пример.");
    Console.WriteLine();
    Console.Write($"и введите его номер -> ");
    Console.WriteLine();

    string [] arrCh = {};
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1) arrCh = arr1;
    else if (choice == 2) arrCh = arr2;
    else if (choice == 3) arrCh = arr3;
    else if (choice == 4) arrCh = // здесь д/б ссылка на метод для заполнения значениями от пользователя ();
    else
    {
        while (choice > 4 || choice <= 0) // цикл проверки ввода от 1 до 4
            {
                Console.WriteLine($"у вас всего 4 варианта. хнык.");
                choice = Convert.ToInt32(Console.ReadLine());
            }
    }
    return arrCh;
}

// здесь метод для заполнения значениями от пользователя
string [] UserEx()
{
    Console.Write("сколько будет элементов в вашем массиве -> ");
    int arrSize = Convert.ToInt32(Console.ReadLine());
    while (arrSize <= 0)
    {
        Console.Write("длина должна быть положительной -> ");
        arrSize = Convert.ToInt32(Console.ReadLine());
    }

    string [] userArray = new string[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"ведите элемент массива №{i+1} -> ");
        userArray[i] = Console.ReadLine()!;
        while (userArray[i] == "")
        {
            Console.WriteLine("элемент не может быть пустым. заново -> ");
            userArray[i] = Console.ReadLine()!;
        }
    }
    return userArray;
}

// здесь метод вывода массива на экран

// здесь метод для решения основной задачи


Console.Clear();

string [] arrayToChoose1 = {"Hello", "2", "world", ":-)"};
string [] arrayToChoose2 = {"1234", "1567", "-2", "computer science"};
string [] arrayToChoose3 = {"Russia", "Denmark", "Kazan"};



Console.Write("массив на основе выбранного, но с элементами из 3ёх символов и менее:");
// здесь будет ссылка на метод

// сначала программа, потом блок-схема. мне так быстрее.