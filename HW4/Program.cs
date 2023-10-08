namespace bankHW
{
    class taikhoan
    {
        public string matk { get; set; }
        public string cmnd { get; set; }
        public string hoten { get; set; }
        public double sodu { get; set; }
        public double laixuat { get; set; }
        public string lichsu { get; set; }

    }
    class nganhang
    {
        private List<taikhoan> list;
        private List<taikhoan> list2;
        public nganhang()
        {
            list = new List<taikhoan>();
        }
        public void createaccount()
        {
            taikhoan tk = new taikhoan();
            Console.WriteLine("Nhap thong tin cua tai khoan");
            Console.Write("Ma tk: ");
            tk.matk = Console.ReadLine();
            Console.Write("CMND: ");
            tk.cmnd = Console.ReadLine();
            Console.Write("Ho va ten: ");
            tk.hoten = Console.ReadLine();
            Console.Write("So du: ");
            tk.sodu = double.Parse(Console.ReadLine());
            Console.Write("Lai xuat: ");
            tk.laixuat = double.Parse(Console.ReadLine());
            list.Add(tk);
            Console.WriteLine("tao tai khoan thanh cong");
            tk.lichsu = "tao tai khoan thanh cong";
            
            
            
        }
        private taikhoan timkiem(string tk)
        {
            foreach(taikhoan a  in list)
            {
                if (a.matk == tk)
                {

                    return a;
                }
            }
            return null;
        }
        public void naptien(string matk, double tien)
        {
            taikhoan tk = timkiem(matk);
            if (tk != null)
            {
                tk.sodu += tien;
                Console.WriteLine("Nap tien thanh cong");
                tk.lichsu += "Nap tien thanh cong";
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan");
            }
        }
        public void ruttien(string matk, double tien)
        {
            taikhoan tk = timkiem(matk);
            if (tk != null)
            {
                if (tk.sodu >= tien)
                {
                    tk.sodu -= tien;
                    Console.WriteLine("Rut tien thanh cong");
                    tk.lichsu += "rut tien thanh cong";
                }
                else
                {
                    Console.WriteLine("So du khong du!");
                }
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan");
            }
        }
        public void check(string matk)
        {
            taikhoan tk = timkiem(matk);
            if(tk != null)
            {
                Console.WriteLine($"So du hien tai: {tk.sodu}");
            }
            else
            {
                Console.WriteLine("Khong tim thay tai khoan");
            }
        }
        public void laithang()
        {
            foreach(taikhoan tk in list)
            {
                double laithang = (tk.sodu * tk.laixuat) / 100;
                tk.sodu += laithang;
            }

        }
        public void print()
        {
            foreach(taikhoan tk in list)
            {
                Console.WriteLine($"Ma tk: {tk.matk}");
                Console.WriteLine($"So du: {tk.sodu}");
                Console.WriteLine("Cac giao dich gan day");
                Console.WriteLine(tk.lichsu);
            }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            nganhang ban = new nganhang();
            while (true)
            {
                
                Console.WriteLine("1, tao tai khoan ");
                Console.WriteLine("2, nap tien");
                Console.WriteLine("3, rut tien");
                Console.WriteLine("4, check");
                Console.WriteLine("5, Lai thang");
                Console.WriteLine("6, in lich su");
                Console.WriteLine("7, thoat");
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
                    else if (!int.TryParse(choose, out int choosenhap) || choosenhap < 1 || choosenhap > 7)
                    {
                        Console.WriteLine("Lựa chọn phải là một số dương và nhỏ hơn 8");
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
                    case "1": ban.createaccount(); Console.ReadLine(); break;
                    case "2":
                        Console.Write("Tai khoan: ");
                        string tk = Console.ReadLine();
                        Console.Write("Nap so tien: ");
                        double tien = double.Parse(Console.ReadLine());
                        ban.naptien(tk,tien) ; Console.ReadLine(); break;
                    case "3":
                        Console.Write("Tai khoan: ");
                        string a = Console.ReadLine();
                        Console.Write("Rut so tien: ");
                        double b = double.Parse(Console.ReadLine());
                        ban.ruttien(a,b); Console.ReadLine(); break;
                    case "4":
                        Console.Write("Tai khoan: ");
                        string c = Console.ReadLine(); ban.check(c); Console.ReadLine(); break;
                    case "5": ban.laithang(); Console.ReadLine(); break;
                    case "6": ban.print(); Console.ReadLine(); break;
                    case "7": return;
            }
        }
    }
    }

}
