using System;
using System.Collections.Generic;

// абстрактний клас студент
abstract class Student {
    // конструктор
    public Student(string name) {
        Name = name;
        State = "";
    }
    // змінні ім'я та стан
    public string Name { get; set; }
    public string State;

    // клас study оголошуємо абстрактним, щоб перевизначати в похідних класах
    public abstract void Study();
    public void Read() {
        State += "Read ";
    }
    public void Write() {
        State += "Write ";
    }
    public void Relax() {
        State += "Relax ";
    }
    // функції, які змінють рядок стан
}

class BadStudent : Student {
    public BadStudent(string Name) : base(Name) {
        State = "Bad. ";
    }

    //перезаписаний клас study
    public override void Study() {
        for (int i = 0; i < 4; ++i)
            Relax();
        Read();
    }
}

class GoodStudent : Student {
    public GoodStudent(string Name) : base(Name) {
        State = "Good. ";
    }

    public override void Study() {
        Read();
        Write();
        Read();
        Write();
        Relax();
    }
}

class Group {
    // конструктор групи, який призначає вказане ім'я
    public Group(string groupName) {
        this.groupName = groupName; 
    }
    public List<Student> s = new List<Student>();
    public string groupName;

    // методи, які додають студента в наш список та 
    public void AddStudent(Student st) {
        s.Add(st);
    }

    // дістють часткову та повну інформацію
    public void GetInfo() {
        Console.WriteLine(groupName);
        foreach(Student st in s)
            Console.WriteLine(st.Name);
    }
    public void GetFullInfo() {
        Console.WriteLine(groupName);
        foreach(Student st in s) {
            Console.WriteLine(st.Name + ": " + st.State);
        }
    }

}

namespace ДЗ_2__Task_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodStudent s1 = new GoodStudent("Alice");
            BadStudent s2 = new BadStudent("Bob");

            Console.WriteLine(s1.Name);
            Console.WriteLine(s2.Name);
            s1.Study();
            s2.Study();

            Console.WriteLine();
            Group g = new Group("Group #1");
            g.AddStudent(s1);
            g.AddStudent(s2);
            g.GetInfo();
            Console.WriteLine();
            g.GetFullInfo();
        }
    }
}
