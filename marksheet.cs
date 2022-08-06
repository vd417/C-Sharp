class demo{
    static void Main(){
        
        System.Console.WriteLine("Enter the name of student:");
        string name = System.Console.ReadLine();
        
        
        System.Console.WriteLine("Enter the RollNo. of student:");
        int rollno = System.Convert.ToInt32(System.Console.ReadLine());

        
        System.Console.WriteLine("Enter the Marks of student in Hindi Subject:");
        int hindi = System.Convert.ToInt32(System.Console.ReadLine());

        
        System.Console.WriteLine("Enter the Marks of student in english Subject:");
        int english = System.Convert.ToInt32(System.Console.ReadLine()); 

        
        System.Console.WriteLine("Enter the Marks of student in Math Subject:");
        int math = System.Convert.ToInt32(System.Console.ReadLine()); 
        
        int total = hindi + english + math;
        
        float percentage = (total%300)*100;
        
        if(percentage>=60)
            System.Console.WriteLine("1st Division");
            
            
        else if(percentage<=60 && percentage>=50)
            System.Console.WriteLine("2st Division");
            
        else if(percentage<=50 && percentage>=40)
            System.Console.WriteLine("3st Division");
            
        else if(percentage<=40)
            System.Console.WriteLine("Fail");
            
    }
    
}