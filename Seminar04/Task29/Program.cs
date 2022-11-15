//Задача 29: Напишите программу, которая задаёт массив из 8
//элементов и выводит их на экран.

 Console.Write("Введите восемь чисел: ");
    int[] array = new int [8];
    
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"{array[i]} ");

    }
   
    Console.Write(String.Join(",", array));


