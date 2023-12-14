namespace ClassLibrary2;

public class Class1
{
    private static void FirstExercise()
    {
        int countBetweenAandB = 0;
        double maxElement;
        int maxElementIndex;
        double sumAfterMaxElement = 0;
        
        var N = Convert.ToInt32(Console.ReadLine());
        var array = new double[N];

        Random random = new Random();
        for (int i = 0; i < N; i++)
        {
            array[i] = random.NextDouble() + random.Next();
        }

        var A = Convert.ToDouble(Console.ReadLine());
        var B = Convert.ToDouble(Console.ReadLine());
        
        

        maxElement = array[0];
        maxElementIndex = 0;
        for (int i = 0; i < N; i++)
        {
            if (array[i] >= A && array[i] <= B)
            {
                countBetweenAandB++;
            }

            if (array[i] > maxElement)
            {
                maxElement = array[i];
                maxElementIndex = i;
            }
            
        }

        for (int i = maxElementIndex + 1; i < N; i++)
        {
            sumAfterMaxElement += array[i];
        }
        
        Console.WriteLine("Count of element between A and B: " + countBetweenAandB);
        Console.WriteLine("Sum of element after maxElement:  " + sumAfterMaxElement);
        
        //сортировка
        double temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.Write("Sort array: ");
        for (int i = 0; i < N; i++)
        {
            Console.Write(array[i] + " | ");
        }
    }
    
    

    private static void SecondExercise()
    {
        var X = Convert.ToInt32(Console.ReadLine());
        var Y = Convert.ToInt32(Console.ReadLine());
        var N = Convert.ToInt32(Console.ReadLine());
        double[,]array = new double[X,Y];
        Random random = new Random();
        
        Console.WriteLine("Choose rhight = 0 or down = 1: ");
        var shift = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < X; i++)
        {
            for (int j = 0; j < Y; j++)
            {   
                array[i,j] = random.NextDouble() + random.Next();
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");
        
        double tmp;
        if (shift == 1)
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[(i - N) / X, j];
                    array[(i - N) / X, j] = tmp;
                }
            }
        }

        if (shift == 0)
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[i, (j - N) / Y];
                    array[i, (j - N) / Y] = tmp;
                }
            }    
        }
            
        for (int i = 0; i < X; i++)
        { 
            for (int j = 0; j < Y; j++)
            {
                Console.Write(array[i,j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static void main()
    {
        FirstExercise();
        Console.WriteLine("\n");
        SecondExercise();
    }
}