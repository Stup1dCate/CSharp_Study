/*
- Toán tử logic: 
 && --> trả về true khi và chỉ khi cả 2 vế đều đúng
 || --> trả về false khi và chỉ khi cả 2 vế đều sai
 !  --> phép phủ định (x: true --> !x: false) 
 ?: --> toán tử điều kiện

- Toán tử tiền tố, hậu tố:
 ++ --> tăng giá trị lên 1 đơn vị (a=1, a++ => a=2)
 -- --> gảim giá trị đi 1 đơn vị (a=2, a-- => a=1)

- Quy tắc dấu cảu tiền tố, hậu tố:
 a++, a-- (dấu viết sau biến) => hậu tố (postfix)
 ++a, --a (dấu viết trước biến) => tiền tố (prefix)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_logic_prefix_postfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result, result_1;
            int a = 6, b = 10;
            // chỉ sai khi cả 2 vế cùng sai
            result = (a != b) || (a < 3);
            Console.WriteLine(result); // result == true

            // chỉ đúng khi cả 2 vế cùng đúng
            result_1 = (b != a) && (a >= 6);
            Console.WriteLine(result_1); // result_1 == true

            /* Quy tắc tính với tiền tố - hậu tố
            VD: int x = 1, y = 2;
            int z = x++ - ++y +1;
            Step 1: ++y => y = 3
            Step 2: x - y + 1 = 1 - 3 + 1 = -1
            Step 3: z = -1
            Step 4: x++ => x = 2
            => sau các bước trên ta thu được x = 2, y = 3, z = -1
            */
            int x = 1, y = 2;
            int z = x++ - ++y + 1;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            
        }
    }
}
