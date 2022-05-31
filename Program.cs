using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Program
    {
        static void Main(String[] args)
        {
            Vehicle ve1 = new Vehicle("Vo Nguyen Tran Quoc", "Toyota Raize", 1000, 570000000);
            Console.WriteLine("{0} \t{1} \t{2} \t{3} \t{4}", "Ten chu xe", "\tLoai xe", "\tDung tich", "\tTri gia", "\tThue phai nop");
            ve1.Show();
        }

    }
}
