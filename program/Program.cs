Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] mass = new string[size];
for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i}: ");
        mass[i]  = Console.ReadLine();
    }