//Задача 1: Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”
int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
//int number = Promt("Введите число 1:\t"), degree = Promt("Введите число 2 :\t");
  
    void DegreeNumber(int number,int degree)
    {
    if(number>degree)
    Console.WriteLine($"\nоперация невозможна");
    else
    {
int i =0;
for(i =number;i<degree;i*=number);
if(i==degree) Console.WriteLine($"\nчисло {degree} является степенью {number}");
 else Console.WriteLine($"\nчисло {degree} не является степенью {number}");
    }
}
Console.WriteLine($"\nОпределите, является ли число 2 степенью числа 1");
int number = Promt("\nВведите число 1:\t"), degree = Promt("Введите число 2 :\t");
DegreeNumber( number,degree);


