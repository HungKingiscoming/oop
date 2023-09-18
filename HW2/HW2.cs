namespace hung
{


    public class person
    {
        public string name
        {
            get; set;
        }
        public string address
        {
            get; set;
        }
        public string salary
        {
            get; set;
        }
        public person() { }

        public person(string name, string address, string salary)
        {
            this.name = name;
            this.address = address;
            this.salary = salary;
        }
        public void input()
        {
            Console.WriteLine("Moi ban nhap ten");
            name = Console.ReadLine();
            Console.WriteLine("Moi ban nhap dia chi");
            address = Console.ReadLine();
            Console.Write("Luong: ");
            salary = Console.ReadLine();
            while (true)
            {

                if (string.IsNullOrEmpty(salary))
                {
                    Console.WriteLine("Luong khong duoc rong");
                    Console.Write("Luong: ");
                    salary = Console.ReadLine();
                }
                else if (!int.TryParse(salary, out int luongnhap) || luongnhap < 1)
                {
                    Console.WriteLine("luong phải là một số dương ");
                    Console.Write("Mời bạn nhập số luong của mình: ");
                    salary = Console.ReadLine();

                }

                else
                {
                    break;
                }
            }


        }
        public void display()
        {
            Console.WriteLine("thong tin nguoi");
            Console.WriteLine($"Ten: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Luong: {salary}");
        }

    }

    public class manageperson
    {
        private List<person> list = new List<person>();
        public void nhap()
        {

            do
            {
                person kh = new person();
                kh.input();
                list.Add(kh);
                Console.Write("Bạn có muốn nhập nữa không?(y/n): ");
                string st = Console.ReadLine();
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

            } while (true);

        }
        public void xuat()
        {
            foreach (var iteam in list)
            {
                iteam.display();
            }
        }
        public void sort()
        {
            foreach (var item in list)
            {
                list.Sort();
            }
        }
    }
    class program
    {
        static void Main()
        {
            manageperson dn = new manageperson();
            dn.nhap();
            dn.xuat();
        }
    }
}