// Заполните спирально массив 4 на 4(массив заполняется по часовой стрелке от периферии к центру). Пример: https://ibb.co/J7RP9Dw

Console.WriteLine("Введите количество элементов стороны матрицы (default = 4)");
var entry = Convert.ToString(Console.ReadLine());
int side = 4;
if (entry.Length != 0) {
    side = Convert.ToInt32(entry);
} else {
    Console.WriteLine(side);
}
int[,] array = new int[side, side];
Console.WriteLine("Введите значение начального элемента");
array[0, 0] = Convert.ToInt32(Console.ReadLine());
int CoordX = 0;
int CoordY = 0;
int diff = 0;
int sum = 1;

while(sum < side*side) {
    if (sum < side*side) SetLine(array, CoordX, CoordY, true);
    if (sum < side*side) SetColumn(array, CoordX, CoordY, true);
    if (sum < side*side) SetLine(array, CoordX, CoordY, false);
    diff++;
    if (sum < side*side) SetColumn(array, CoordX, CoordY, false);
}
for (int i = 0; i < side; i++)
{
    for (int k = 0; k < side; k++)
    {
        Console.Write($"{array[i, k]:d2} ");
    }
    Console.WriteLine();
}

void SetLine(int[,] arr, int x, int y, bool direct) {
    if (direct) {
        for (int i = x + 1; i < side - diff; i++)
        {
            arr[y, i] = arr[y, x] + 1;
            CoordX++;
            x++;
            sum++;
        }
    } else {
        for (int i = x - 1; i >= diff; i--)
        {
            arr[y, i] = arr[y, x] + 1;
            CoordX--;
            x--;
            sum++;
        }
    }
}
void SetColumn(int[,] arr, int x, int y, bool direct) {
    if (direct) {
        for (int i = y + 1; i < side - diff; i++)
        {
            arr[i, x] = arr[y, x] + 1;
            CoordY++;
            y++;
            sum++;
        }
    } else {
        for (int i = y - 1; i >= diff; i--)
        {
            arr[i, x] = arr[y, x] + 1;
            CoordY--;
            y--;
            sum++;
        }
    }
}
