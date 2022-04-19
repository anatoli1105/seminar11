//Задача 2: Проверка на простое число:
//N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”
int Promt(string messege)
{
    Console.Write(messege);
    string strN = Console.ReadLine();
    int N =int.Parse(strN);
    return N;
}
void CheckNumber(int value)
{
    int sum =1;
    for(int i =0;i<value-2;i++)
    {
        sum+=1;
        if (value%sum==0)
        {
            Console.Write("Это не простое число");
            return;
        }
    }
     Console.Write("Это простое число");
}

int value = Promt("Введите число :\t");
if(value<0) 
{
    Console.Write("Это не простое число");return;
}    
CheckNumber(value);