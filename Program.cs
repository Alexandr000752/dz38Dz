
Console.Write("Введите номер: ");
int numberA = int.Parse(Console.ReadLine());

int[] array = new int[numberA];

for(int i = 0; i< array.Length; i++)
{
	array[i] = new Random().Next(1, 100);
	Console.Write(array[i] + ", ");
}

PrintMaxMin(array);


void PrintMaxMin(int[] array)
{
	int max = array[0];
	int min = array[0];
	
	for(int index = 0; index < array.Length; index++)
	{
		if(max < array[index]) max = array[index];
	
     	if(min > array[index]) min =array[index];
	}
	Console.WriteLine("max: " + max + "; min: "+ min + ";");
	Console.WriteLine("Разница между максимальным и минимальным числом будет ровна: " + (max-min));
}



