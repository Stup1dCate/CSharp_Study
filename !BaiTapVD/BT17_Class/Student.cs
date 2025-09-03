using System;

namespace BT17_Class
{
    class Student
    {
        // ===== THUỘC TÍNH (Fields) =====
        private int id;
        private string name;
        private int age;
        private double score;

        // ===== CONSTRUCTOR ===== 
        public Student() // constructor không tham số (mặc định)
        {
            id = 0;
            name = "Unknown";
            age = 18;
            score = 0.0;
        }
        public Student(int id, string name, int age, double score) // constructor có tham số
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }
        

        // ===== GET/SET (Properties) ===== // 
        public int Id
        {
            get { return id; }
            set
            {
                if (value >= 0) id = value;
                else id = 0;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) name = value;
                else name = "No Name";
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else age = 18;
            }
        }
        public double Score
        {
            get { return score; }
            set
            {
                if (value >= 0 && value <= 10) score = value;
                else score = 0;
            }
        }


        // ===== METHOD =====
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Age: {Age}, Score: {Score}");
        }

        public string IsPassed()
        {
            if (Score >= 5) return "Dat";
            else return "Khong Dat";
        }
    }
}
