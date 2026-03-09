namespace projets1;

 public class Student
    {
        public int id;
        public static int Id;
         public string name;
         public float average;
         public bool isScholarshipHolder ;       

         public Student() // 1er constructeur sans paramètre  
    {
        
    }
     public Student(string name, float average, bool isScholarshipHolder) // 2eme constructeur complet 
    {
         this.name = name;
         this.average = average;
         this.isScholarshipHolder = isScholarshipHolder;
    }
    public Student(string name, float average) // 3eme constructeur partiel (name, average)
    {
        this.name = name ;
        this.average = average ;
        Id ++;
    }
     
     public static int Id()
    {
        return Id; 
    }

    }



class Program
{
   
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
