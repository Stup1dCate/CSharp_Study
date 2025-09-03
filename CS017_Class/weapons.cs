using System;

namespace bai17_Class
{
    /*
        <Access Modifiers> class Class_Name {
            // khai báo các thành viên: dữ liệu (thuộc tính, biến trường dữ liệu)
            // khai báo các thành viên: hàm (phương thức)
        }
    */


    class weapons
    {

        // CÁC THÀNH VIÊN DỮ LIỆU TRONG LỚP (nếu không chỉ rõ thì mặc định là private)
        /*
        public:             không giới hạn phạm vi truy cập
        protected:          chỉ truy cập trong nội bộ lớp hay các lớp kế thừa
        private:            (mặc định) chỉ truy cập được từ các thành viên của lớp chứa nó
        internal:           chỉ truy cập được trong cùng assembly (dll, exe)
        protected internal: truy cập được khi cùng assembly hoặc lớp kế thừa
        private protected:  truy cập từ lớp chứa nó, lớp kế thừa nhưng phải cùng assembly
        */

        // thuộc tính:
        public string name = "Ten vu khi"; // string name;
        int doSatThuong = 0; // không nêu gì nghĩa là giới hạn truy cập là "private" -> có thể truy cập trong cùng một lớp



        // PHƯƠNG THỨC KHỞI TẠO  (có thể quá tải phương thức khởi tạo)
        // ptkt không tham số: (mặc định)
        public weapons()
        {
            doSatThuong = 1;
        }
        // ptkt có tham số:
        public weapons(string name, int _doSatThuong)
        {
            this.name = name;
            doSatThuong = _doSatThuong;
        }



        // PHƯƠNG THỨC
        public void thietLapDoSatThuong(int doSatThuong)
        {
            this.doSatThuong = doSatThuong;
        }
        public void tanCong()
        {
            Console.Write(name + ": \n");
            for (int i = 0; i < doSatThuong; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }



        // THUỘC TÍNH
        // nếu thiếu khối lệnh get => thuộc tính này chỉ cho phép ghi không đọc được
        // nếu thiếu khối lệnh set => thuộc tính chỉ đọc không được ghi 
        // nếu thiếu 1/2 có thể báo lỗi
        public int satThuong
        {
            // khi gán
            set
            {
                Console.WriteLine(value);
            }
            // khi truy cập
            get
            {
                return doSatThuong;
            }
        }
        // khởi tạo nhanh thuộc tính:

        public string noiSanXuat { set; get; }
    }








}