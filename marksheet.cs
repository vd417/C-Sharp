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
        
        float percentage = (total%3)F;
        
        if(percentage<33)
            System.Console.WriteLine("FAIL");
            
            
        else if(percentage<45)
            System.Console.WriteLine("3rd Division");
            
        else if(percentage<60)
            System.Console.WriteLine("2nd Division");
            
        else if(percentage>=60&&percentage<=100)
            System.Console.WriteLine("1st Division");
            
    }
    
}
