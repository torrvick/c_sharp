PrintArray(WormArray(4,4));

int[,] WormArray(int totalRows, int totalCols)
{
    int[,] wormArray = new int[totalRows, totalCols];
    int curIterTotalRows = totalRows;
    int curIterTotalCols = totalCols;

    int currentRow = 0;
    int currentCol = 0;
    int value = 1;
    int totalValue = totalRows * totalCols;

    while (currentRow < (totalRows / 2 + totalRows % 2) || currentCol < (totalCols / 2 + totalRows % 2))
    {
        for (int i = currentCol; i < curIterTotalCols && value <= totalValue; i++, value++)
            wormArray[currentRow, i] = value;
        currentCol = curIterTotalCols - 1;
        currentRow++;

        for (int i = currentRow; i < curIterTotalRows && value <= totalValue; i++, value++)
            wormArray[i, currentCol] = value;
        currentRow = curIterTotalRows - 1;
        currentCol--;

        for (int i = currentCol; i >= totalCols - curIterTotalCols && value <= totalValue; i--, value++)
            wormArray[currentRow, i] = value;
        currentCol = totalCols - curIterTotalCols;
        currentRow--;
        
        for (int i = currentRow; i > totalRows - curIterTotalRows && value <= totalValue; i--, value++)
            wormArray[i, currentCol] = value;
        currentRow = totalRows - curIterTotalRows + 1;
        currentCol++;
        curIterTotalRows--;
        curIterTotalCols--;
    }

    return wormArray;
}

void PrintArray(int[,] array)
{
    int max_elem = array.GetLength(0) * array.GetLength(1);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            //Console.Write($"{array[i, j],5}");
            //Отображение ведущих нулей в выводе:
            Console.Write($"{array[i,j].ToString().PadLeft(max_elem.ToString().Length, '0')}  ");
        Console.WriteLine();
    }
}