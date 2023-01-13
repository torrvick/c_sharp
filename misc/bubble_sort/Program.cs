using static BubbleArray;

10.Create()
  .Show()
  .Sort()
  .Show();
//Console.WriteLine($"[{string.Join(" ", array)}]");

public static class BubbleArray
{
    public static int[] Create(this int size, int min = 0, int max = 11)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
            array[i] = Convert.ToInt32(new Random().Next(min, max));

        return array;
    }

    public static int[] Show(this int[] array)
    {
        Console.WriteLine($"[{string.Join(" ", array)}]");
        return array;
    }


    public static int[] Sort(this int[] array)
    {
        for (int i = 0; i < array.Length-1;)
        {
            if(array[i+1]<array[i])
            {
                Console.WriteLine($"[{string.Join(" ", array)}]   [{i}] <-> [{i+1}]  {array[i]} <-> {array[i+1]}");
                int temp = array[i];
                array[i] = array[i+1];
                array[i+1] = temp;
                i = 0;               
            }
            else 
            i++;
        }
        return array;
    }
}

