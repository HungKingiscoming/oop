using System;
using System.Collections;
using System.Collections.Generic;

namespace HW3
{
    abstract class bill
    {
        protected string clerk;
        protected string masp;
        protected double total;
        public double price;
        public bill()
        {
            this.clerk = clerk;
            this.masp = masp;
            this.total = total;
            this.price = price;
        }

        public virtual void setitem()
        {
            Console.WriteLine("Ma san pham: ");
            masp = Console.ReadLine();
            Console.WriteLine("Price: ");
            price = double.Parse(Console.ReadLine());
            
        }
        public void nhap()
        {
            Console.WriteLine("Nhap thong tin bill");
            Console.Write("Nhan vien: ");
            clerk = Console.ReadLine();
        }
        public abstract double getitem();
        
    }
    class norbill:bill
    {
        
        public override double getitem()
        {
            return price;
        }

        public override void setitem()
        {
            base.setitem();
            getitem();           
        }
        public void show1()
        {
            Console.WriteLine($"Nhan vien: {clerk}");
        }
        public void show2()
        {
            Console.WriteLine($"Masp: {masp},gia sp: {price}");
        }
    }
    class discountbill:bill
    {
        public override double getitem()
        {
            price = price * 0.8;
            return price;
        }
        public override void setitem()
        {
            base.setitem();
            getitem();
        }
        public void show1()
        {
            Console.WriteLine($"Nhan vien: {clerk}");
        }
        public void show2()
        {
            Console.WriteLine($"Masp: {masp},gia sp: {price}");
        }
    }
    class managebill : norbill
    {
        List<norbill> list = new List<norbill>();
        List<norbill> list1 = new List<norbill>();
        public void nhap()
        {
            norbill nb = new norbill();
            nb.nhap();
            list.Add(nb);
            do
            {              
                norbill nb1 = new norbill();
                nb1.setitem();
                
                list1.Add(nb1);
                Console.Write("Bạn có muốn nhập nữa không?(y/n): ");
                string st = Console.ReadLine();
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

            } while (true);
            

        }
        public void show()
        {
            double a = 0;
            foreach (var iteam in list)
            {
                iteam.show1();
            }
            foreach (var iteam in list1)
            {
                iteam.show2();
            }
            foreach (var item in list1)
            {
                a = a + item.price;
            }
            Console.WriteLine(a);
        }

    }
    class managevbill : discountbill
    {
        List<discountbill> list2 = new List<discountbill>();
        List<discountbill> list3 = new List<discountbill>();
        public void nhap()
        {

            discountbill nb = new discountbill();
            nb.nhap();
            list2.Add(nb);
            do
            {
                discountbill nb1 = new discountbill();
                nb1.setitem();

                list3.Add(nb1);
                Console.Write("Bạn có muốn nhập nữa không?(y/n): ");
                string st = Console.ReadLine();
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

            } while (true);

        }
        public void show()
        {
            double b = 0;
            foreach (var iteam in list2)
            {
                iteam.show1();
            }
            foreach (var iteam in list3)
            {
                iteam.show2();
            }
            foreach (var item in list3)
            {
                b = b + item.price;
            }
        }


    }
    class program
    {
        static void Main()
        {
            managebill nb = new managebill();
            managevbill db = new managevbill();
            while (true)
            {
                Console.WriteLine("1, Nhap norbill");
                Console.WriteLine("2, Nhap discountbill");
                Console.WriteLine("3, xuat norbill");
                Console.WriteLine("4, xuat norbill");
                Console.Write("\n\n Mời bạn nhập lựa chọn của mình: ");
                string choose = Console.ReadLine();
                while (true)
                {
                    if (string.IsNullOrEmpty(choose))
                    {
                        Console.WriteLine("Lựa chọn không được rỗng");
                        Console.Write("Mời bạn nhập lựa chọn của mình: ");
                        choose = Console.ReadLine();
                    }
                    else if (!int.TryParse(choose, out int choosenhap) || choosenhap < 1 || choosenhap > 6)
                    {
                        Console.WriteLine("Lựa chọn phải là một số dương và nhỏ hơn 6");
                        Console.Write("Mời bạn nhập lựa chọn của mình: ");
                        choose = Console.ReadLine();

                    }

                    else
                    {

                        break;
                    }
                }
                switch (choose)
                {
                    case "1": nb.nhap(); Console.ReadLine(); break;
                    case "2": db.nhap(); Console.ReadLine(); break;
                    case "3": nb.show(); Console.ReadLine(); break;
                    case "4": db.show(); Console.ReadLine(); break;
                    case "5": return;
                }
            }
        }
    }
}
