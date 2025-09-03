using System;

namespace CS021_Inheritance
{
    // Tính kế thừa:
    /*
    A, B với B kế thừa A, ta nói:
    A - là lớp cơ sở (lớp cha)
    B - là lớp kế thừa (lớp con)

    class B : A
    {

    }

    Animal
        - leg
        - weight
        - showlegs

    Cat : Animal

    */

    class Animal
    // sealed class Animal -> niêm phong class => các class kế thừa không thể truy cập
    {
        public Animal()
        {
            Console.WriteLine("Khoi tao Animal");
        }
        public int legs { set; get; }
        public float weight { set; get; }
        public string name { set; get; }
        public string food { set; get; }
        public void showLegs()
        {
            Console.WriteLine($"leg: {legs}");
        }
        public void showWeight()
        {
            Console.WriteLine($"weight: {weight} kg");
        }
        public void showFood()
        {
            Console.WriteLine($"food: {food}");
        }
    }

    class Cat : Animal
    {
        // hàm khởi tạo thông số cụ thể của đối tượng
        public Cat()
        {
            this.legs = 4;
            this.weight = 10;
            this.food = "fish";
            Console.WriteLine("Khoi tao Cat");
            this.name = "Cat";
        }
        // các hàm hiển thị thông tin có thể gọi riêng từ Main hoặc gọi đồng loạt từ showInfo
        /* public void Weight()
        {
            Console.WriteLine(weight);
        }
        public void Eat()
        {
            Console.WriteLine(food);
        }
        */
        public void ShowInfo()
        {
            base.showFood();
            base.showWeight();
            base.showLegs();
        }
    }
    class Chicken : Animal
    {
        public Chicken()
        {
            this.legs = 2;
            this.food = "seed";
            this.weight = 1.5f;
            this.name = "Chicken";
        }
        public void ShowInfo()
        {
            base.showFood();
            base.showWeight();
            base.showLegs();
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Cat c = new Cat();
            Console.WriteLine("Thong so cua doi tuong " + c.name);
            c.ShowInfo(); // các thông tin chi tiết của đối tượng được đưa hết vào showinfo nên chỉ cần dòng này để hiển thị ra hết

            Chicken ck = new Chicken();
            Console.WriteLine("Thong so cua doi tuong " + ck.name);
            ck.ShowInfo(); 

        }
    }
}