//#1
/*
int[] array = new int[100];
int arraySize = array.Length;
int count=0;
for (int i = 0; i < arraySize; i++)
{
	array[i] = new Random().Next(100, 1000);
	if (array[i]%2==0) count++;
}
//Console.WriteLine($" {string.Join("; ", array)} ");
Console.WriteLine($"Количество четных чисел массива = {count}");
*/
//№2
/*
int[] array = new int[10];
int arraySize = array.Length;
int count = 0;
for (int i = 0; i < arraySize; i++)
{
	array[i] = new Random().Next(10);
	if (i != 0 && i % 2 != 0) count += array[i];
}
Console.WriteLine($" {string.Join("; ", array)} ");
Console.WriteLine($"Сумма чисел на нечетных поцизиях массива = {count}"); //Позиция = индекс числа в массиве!
*/

//#3

double[] array = new double[10];
double arraySize = array.Length;
double maxNum = 0;
double minNum = 100;
for (int i = 0; i < arraySize; i++)
{
	array[i] = Math.Round(new Random().NextDouble()*100,2);
	if (array[i]>maxNum) maxNum=array[i];
	if (array[i]<minNum) minNum=array[i];
}
//Console.WriteLine($" {string.Join("; ", array)} максимум - {maxNum} минимум - {minNum}");
System.Console.WriteLine($"Разница максимального {maxNum} и минимального {minNum} чисел массива = {maxNum-minNum}");
