using System.Data.Common;

namespace projets1;

 public class Student
    {
        public int id;
        public static int Id = 1; // Id que l'on va incrémenté a chaque élève 
         public string name;
         public float average;
         public bool isScholarshipHolder ;       

         public Student() // 1er constructeur sans paramètre  
    {
        this.id = Id++; 
    }
     public Student(string name, float average, bool isScholarshipHolder) // 2eme constructeur complet 
    {
         this.Name = name;
         this.Average = average;
         this.isScholarshipHolder = isScholarshipHolder;
         this.id = Id++;
    }
    public Student(string name, float average) // 3eme constructeur partiel (name, average)
    {
        this.Name = name ;
        this.Average = average ;
        this.id = Id++;
    }
    public string Name
    {
        get {return name;} // lire la valeur de name
        set {name = value ;} // mettre la valeur attribué à name 
    }
    public float Average
    {
        get {return average;} // lire la valeur average 
        set {average = value;} // mettre la valeur attribué average
    }
    public static int GetCurrentCount() // Méthode pour appeller l'Id à chaque incrémentation 
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
