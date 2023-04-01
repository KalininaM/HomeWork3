Main();

void Main()
{
    bool isWorking = true;
    while(isWorking){
        Console.WriteLine("Input task");
        string task = Console.ReadLine();

        switch(task){
            case "exit": isWorking = false; break;
            case "t19": Task19(); break;
            case "t21": Task21(); break;
            case "t23": Task23(); break;
            default: break;
        }
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
void Task19(){
    int number = ReadInt("пятизначное число");
    string numStr = number.ToString();
     if ((numStr[0] == numStr[4]) && (numStr[1] == numStr[3]))
        Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}

/*Задача 21
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
void Task21(){
    int x1 = ReadInt("x1");
    int y1 = ReadInt("y1");
    int z1 = ReadInt("z1");
    int x2 = ReadInt("x2");
    int y2 = ReadInt("y2");
    int z2 = ReadInt("z2");
    double Length = Math.Round(Math.Sqrt(Math.Pow( x1 - x2, 2 ) + Math.Pow( y1 - y2, 2 ) + Math.Pow( z1 - z2, 2 )), 3);
    Console.WriteLine($"Расстояние в 3D пространсте между двух точек = {Length}");
}

/*Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
void Task23(){
    int number = ReadInt("N");
    int i = 1;
    string cubeNumbers = "";
    while(i <= number){
        cubeNumbers = cubeNumbers + " " + Math.Pow(i, 3);
        i++;
    }
    Console.WriteLine($"Таблица кубов чисел от 1 до {number}: {cubeNumbers}");
}


