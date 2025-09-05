using System;

namespace CS037_Operator_Overloading
{

    class Vector
    {
        double x, y;
        public Vector(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }
        public void Info()
        {
            Console.WriteLine($"x = {x}, y = {y}");
        }

        // tái tạo toán tử để thực hiện phép tính - tổng 2 vector:
        // vector <- vector + vector
        public static Vector operator +(Vector v1, Vector v2)
        //<...> ... <kiểu trả về> operator<kí hiệu phép toán>(){}
        {
            double x = v1.x + v2.x;
            double y = v1.y + v2.y;
            Vector v = new Vector(x, y);
            return v;
            // return new Vector(v1.x + v2.x, v1.y + v2.y); => ghi ngắn gọn hơn
        }
        public static Vector operator +(Vector v1, double val)
        {
            return new Vector(v1.x + val, v1.y + val);
        }


        /* Bộ đánh chỉ mục - Indexer
            Indexer là khả năng cho cho phép truy cập đến các thành viên của lớp, 
        thực hiện một số tác vụ thông qua ký hiệu chỉ mục [chỉ-mục] 
        (ký hiệu chỉ mục được dùng để truy cập các phần tử mảng - trình bày ở phần mảng C#)
        */
        // khai báo Indexer: khai báo cụm "this[<kiểu chỉ số>]" sau khi trả về 
        public double this[int i]
        { // kiểu chỉ số truy cập là interger
            set // khối này xét chỉ số
            {
                switch (i)
                {
                    case 0:
                        x = value;
                        break;
                    case 1:
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so bi sai"); // thông báo ngoại lệ
                }
            }
            get // khối này trả về giá trị
            {
                switch (i)
                {
                    case 0:
                        return x;
                    case 1:
                        return y;
                    default:
                        throw new Exception("Chi so bi sai"); // thông báo ngoại lệ
                }
            }
        }
        
        public double this[string s]
        { // kiểu chỉ số truy cập là string
            set 
            {
                switch (s)
                {
                    case "toadox":
                        x = value;
                        break;
                    case "toadoy":
                        y = value;
                        break;
                    default:
                        throw new Exception("Chi so bi sai"); 
                }
            }
            get 
            {
                switch (s)
                {
                    case "toadox":
                        return x;
                    case "toadoy":
                        return y;
                    default:
                        throw new Exception("Chi so bi sai"); 
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(2, 3);
            Vector v2 = new Vector(3, 4);

            // phép cộng 2 vector [(x1, y1) và (x2, y2) = (x1 + x2, y1 + y2)]
            var v3 = v1 + v2;
            var v4 = v1 + 10;
            v3.Info();
            v4.Info();

            // truy cập đến thành viên dữ liệu trong vector:
            // chỉ số truy cập là các số:
            // v1[0]; ~ x
            // v1[1]; ~ y
            Vector v5 = new Vector(3, 4);
            v5[0] = 5;
            v5[1] = 6;
            v5.Info();
            Console.WriteLine(v5[3]); // phát sinh lỗi nếu truy cập sai

            // chỉ số truy cập là các chuỗi:
            // v["toadox"]; ~ x
            // v["toadoy"]; ~ y 
            Vector v6 = new Vector(3, 4);
            v6["toadox"] = 10;
            v6["toadoy"] = 12;
            v6.Info();
            Console.WriteLine(v6["toadoz"]); // phát sinh lỗi




        }
    }
}