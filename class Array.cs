class Array
{
    static void Main()
    {
        System.Console.Write("Enter the size of array : ");
        int size = int.Parse(System.Console.ReadLine());
        
        int []arr = new int[size];
        
        for(int i=0; i < arr.Length; i++)
        {
            System.Console.Write("Enter the Number :");
            arr[i] = int.Parse(System.Console.ReadLine());
            
        }
        string result;
         int num = arr[0];
        for(int i = 0 ; i< arr.Length; i++)
        {
            if(num > 0)
            {
                num = arr[i];
                result = "Positive"; 
            }
            else
            {
                result = "negative";
            }       
        System.Console.WriteLine("Given number is "+arr[i]+" : " +result);
        }
        
        
    }
}