using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Net.Mail;

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
public class Course // Exercice 3 
{
    public int id;
    public string name; 
    public float credits;
    public bool isMandatory;
    public List<Student> students = new List<Student>(); 

    public Course() // 1er Construteur sans paramètre Exercice 4 
    {
        
    }

    public Course (string name, float credits, bool isMandatory) //2eme constructeur complet
    {
        this.name = name;
        this.credits = credits;
        this.isMandatory = isMandatory;
    }

    public void AddStudent (Student student)
    {
        if (student != null)
        {
            this.students.Add(student);
        }
    }

    public Course (string name) // 3eme constructeur simplifié
    {
        this.name = name;
    }

    public void InfoCours() // Exercice 7 bis 
    {
        string obligatoire = this.isMandatory ? "Oui" : "Non";
        Console.WriteLine($"Nom : {name}, Crédits : {credits}, obligatoire : {obligatoire}, Nombre d'élèves :{students.Count}");

        if (students.Count > 0) // Exercice 8  condition  si il y a un etudiant  
        {
            Console.WriteLine("Liste des étudiants:"); 
            foreach (Student s in students) //boucle foreach qui va parcourrir la liste et afficher l'id et le nom de l'étudiant
            {
                Console.WriteLine($"- [ID {s.id}] {s.Name}");
            }
        }
        else
        {
            Console.WriteLine("Aucun étudaunt inscrit");
        }
    }
        public void RemoveStudent(Student student)// Exercice 12 – Méthode pour supprimer un étudiant

    {
        if (student != null)
        {
            this.students.Remove(student);
        }
    }
}

class Program
{
   
    static void Main(string[] args)
    {
        Student s1 = new Student(); // Exercice 2 Création des élèves
        s1.Name = "Alice";
        s1.Average = 14.5f;
        Student s2 = new Student ("Bernard", 15.7f, true);
        Student s3 = new Student ("Emma", 15.7f);
        Student s4 = new Student ("Lucas", 10.3f, true);
        Student s5 = new Student ("Sarah", 5.5f, false);
        Student s6 = new Student ();

        Course c1 = new Course ("Mathématiques", 50.5f, true); // Exercice 5 
        Course c2 = new Course ("informatique", 40f, true); // Constructeur complet
        Course c3 = new Course ("Anglais"); // Construteur smplifié
        Course c4 = new Course (); // Constructeur sans paramètre
        Course c5 = new Course ("Histoire", 20f, false); 

        c1.AddStudent(s1); // Exercice 6 Inscription des étudiants aux cours 
        c1.AddStudent(s2);
        c1.AddStudent(s3);

        c2.AddStudent(s2);
        c2.AddStudent(s4);

        c3.AddStudent(s1);
        c3.AddStudent(s5);

        c5.AddStudent(s4);

        Console.WriteLine("Détails de tout les cours"); //Exercice 7 Afficher les details d'un cours
        c1.InfoCours(); 
        c2.InfoCours();
        c3.InfoCours();
        c4.InfoCours();
        c5.InfoCours();

        Console.WriteLine("Listes des cours obligatoires"); // exercice 9 Afficher les cours obligatoires
        List<Course> allCourse = new List<Course> {c1, c2, c3, c4, c5, }; 
        foreach (Course c in allCourse)
        {
            if (c.isMandatory)
            {
                Console.WriteLine($"- {c.name}");
            }
            
        }
        Console.WriteLine("\n=== ÉTUDIANTS BOURSIERS ===");// Exercice 10 – Identifier les étudiants boursiers 
        List<Student> allStudents = new List<Student> { s1, s2, s3, s4, s5, s6 };
        foreach (Student s in allStudents)
        {
            if (s.isScholarshipHolder)
            {
                Console.WriteLine($"- {s.Name} est boursier.");
            }
        }
        Console.WriteLine("\n=== ÉTUDIANTS AVEC UNE MOYENNE > 15 ===");// Exercice 11 – Utiliser la moyenne 
        foreach (Student s in allStudents)
        {
            if (s.Average > 15f)
            {
                Console.WriteLine($"- {s.Name} a une excellente moyenne ({s.Average}/20)");
            }
        }

        c1.RemoveStudent(s2); // Exercice 12 – Supprimer un étudiant d’un cours 
        Console.WriteLine("\n=== APRÈS SUPPRESSION DE BERNARD DU COURS C1 ===");
        c1.InfoCours();

    }
}
