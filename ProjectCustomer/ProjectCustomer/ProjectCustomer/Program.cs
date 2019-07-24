using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();
                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Hapus Customer");
            Console.WriteLine("3. Tampil Customer");
            Console.WriteLine("4. Keluar");
        }

        static void TambahCustomer()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Customer");
            Console.Write("Kode Costumer : ");
            string kode = Console.ReadLine().ToString();
            Console.Write("Nama Customer : ");
            string nama = Console.ReadLine().ToString();
            Console.Write("Total Piutang : ");
            string total = Console.ReadLine().ToString();

            daftarCustomer.Add(new Customer { Kode = kode, Nama = nama, Total = total });

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();
            Console.WriteLine("Hapus Daftar Customer");
            Console.Write("Kode Customer : ");
            string kode = Console.ReadLine().ToString();
            daftarCustomer.Remove(daftarCustomer.SingleOrDefault(f => f.Kode == kode));

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilCustomer()
        {
            Console.Clear();
            Console.WriteLine("Data Customer");
            int NoUrut = 1;
            Console.WriteLine();

            foreach (Customer cst in daftarCustomer)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", NoUrut, cst.Kode, cst.Nama, cst.Total);
                NoUrut++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
