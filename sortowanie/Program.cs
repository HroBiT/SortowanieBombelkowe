class Program
{
    public static void bubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n -i - 1; j++)
            {
                if (array[j] < array[j+1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        try
        {
            Console.Write("Podaj jaka ilosc miejsc ma miec tablica\n");
            int r = Convert.ToInt16(Console.ReadLine());
        

        int[] array = new int[r];
        Random random = new Random();
        for (int i = 0;i< r; i++) 
        {
            array[i] = random.Next(1,100);
        }

        Console.WriteLine("\n przed sortowaniem");
        foreach (int l in array) {
            Console.WriteLine(l + ",");
        }

        bubbleSort(array);

        Console.WriteLine("\n po sortowaniu");
        foreach (int l in array) {
           Console.WriteLine(l + ",");
        }
        }
        catch (Exception e)
        {
            Console.WriteLine("podaj dobra liczbe");
        }
    }
}