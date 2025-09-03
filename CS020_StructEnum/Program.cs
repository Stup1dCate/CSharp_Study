using System;

namespace CS020_StructEnum
{

    class Program
    {
        //Enum
        enum HOCLUC // mỗi một dòng tương ứng với vị trí index
        {
            // có thể gán giá trị
            KEM = 2,        // 0
            TRUNGBINH = 4,  // 1
            KHA = 6,        // ..
            GIOI = 8,
            XUATSAC = 10
        }
        // VD: Kiem tra hoc luc nhap vao
        /*
        0 - Kem
        1 - Trung binh
        2 - Kha
        3 - gioi
        4 - xuat sac
        */
        public static void Main(string[] args)
        {

            HOCLUC hocluc;

            // ep kieu:
            hocluc = HOCLUC.GIOI;
            int sodiem = (int)hocluc; // tương ứng: ouput = 8 (giỏi)
            Console.WriteLine("Hoc luc khi ep sang kieu so: " + sodiem);

            hocluc = (HOCLUC)(4); // tương ứng: output = khá (4)
            

            switch (hocluc)
            {
                /* mặc định với switch - case thông thường
                case 0:
                    Console.WriteLine("Hoc luc kem");
                    break;
                case 1:
                    Console.WriteLine("Hoc luc trung binh");
                    break;
                case 2:
                    Console.WriteLine("Hoc luc kha");
                    break;
                case 3:
                    Console.WriteLine("Hoc luc gioi");
                    break;
                case 4:
                    Console.WriteLine("Hoc luc xuat sac");
                    break;
                */
                case HOCLUC.KEM:
                    Console.WriteLine("Hoc luc kem");
                    break;
                case HOCLUC.TRUNGBINH:
                    Console.WriteLine("Hoc luc trung binh");
                    break;
                case HOCLUC.KHA:
                    Console.WriteLine("Hoc luc kha");
                    break;
                case HOCLUC.GIOI:
                    Console.WriteLine("Hoc luc gioi");
                    break;
                case HOCLUC.XUATSAC:
                    Console.WriteLine("Hoc luc xuat sac");
                    break;
                default:
                    Console.WriteLine("Hoc luc nhap vao khong chinh xac !");
                    break;
            }

        }
    }
}