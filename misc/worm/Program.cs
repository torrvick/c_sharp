int m = 10;
int n = 10;
int[,] worm = new int[m, n];
int cur_row = 0;
int cur_col = 0;
int r = m;
int c = n;
int chi = 1;

for(int g=0;g<m*n;g++)
{
for (int i = cur_col; i < c; i++, chi++)
    worm[cur_row, i] = chi;
cur_col = c - 1;
for (int i = cur_row + 1; i < r; i++, chi++)
    worm[i, cur_col] = chi;
cur_row = r - 1;
for (int i = cur_col - 1; i >= n - cur_col - 1; i--, chi++)
    worm[cur_row, i] = chi;
cur_col = n - cur_col - 1;
for (int i = cur_row - 1; i > m - cur_row - 1; i--, chi++)
    worm[i,cur_col] = chi;
cur_row = m - cur_row;
cur_col++;

r--;
c--;
}





PrintArray(worm);

void PrintArray(int[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
}