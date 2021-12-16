using System;
using System.Collections.Generic;
using System.Threading;

namespace DasarCSharp
{
    class Program
    {
        public static List<string> subjects = new List<string>();
        public static IdentitasPenting idp = new IdentitasPenting();
        static void Main(string[] args)
        {
            Console.WriteLine("     ================================     ");
            Console.WriteLine("     |Silahkan Login Terlebih Dahulu|     ");
            Console.WriteLine("     ================================     ");
            Console.WriteLine("");
            LoginPage();
        }
        static void LoginPage()
        {
            Console.Write("\tUsername : ");
            string username = Console.ReadLine();
            Console.Write("\tPassword : ");
            string password = Console.ReadLine();
            if (username == "ilhampatri" && password == "ilhampatri")
            {
                Console.Clear();

                MenuUtama();
            }
            else if (username == "akbar" && password == "akbar")
            {
                Console.Clear();

                MenuUtama();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Password Salah");
                Console.WriteLine("");
                Console.WriteLine("Apakah anda ingin login kembali ? (Y/N)");
                string loginlagi = Console.ReadLine();
                if (loginlagi == "Y" || loginlagi == "y")
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("     ================================     ");
                        Console.WriteLine("         Silahkan Login Kembali");
                        Console.WriteLine("     ================================     ");
                        Console.WriteLine("");
                        LoginPage();
                    }
                    while (true);
                }
                else if (loginlagi == "N" || loginlagi == "n")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

        }
        static void MenuUtama()
        {
            Console.WriteLine("");
            Console.WriteLine("     ================================     ");
            Console.WriteLine("\t\tMENU");
            Console.WriteLine("     ================================     ");
            List<string> isimenuUtama = new List<String>();
            isimenuUtama.Add("Profile");
            isimenuUtama.Add("Daftar Dosen");
            isimenuUtama.Add("Daftar Mata Kuliah");
            isimenuUtama.Add("Input Mata Kuliah");
            isimenuUtama.Add("Lihat PRS");
            isimenuUtama.Add("Hapus data PRS");
            isimenuUtama.Add("Exit");
            for (int i = 0; i < isimenuUtama.Count; i++)
            {
                Console.WriteLine("\t"+(i + 1) + " : " + isimenuUtama[i]);
            }
            Console.WriteLine("");
            try {
                Console.Write("Masukkan menu yang anda pilih : ");
                int pilihan = int.Parse(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Siapa nama ibu kandung anda : ");
                            string validasi = Console.ReadLine();
                            if(validasi == "ibupatri")
                            {
                                profileilhampatri();
                            }
                            else if(validasi == "ibuakbar")
                            {
                                profileakbar();
                            }
                            else
                            {
                                Console.WriteLine("TIDAK VALID");
                                Environment.Exit(0);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            DaftarDosen();
                            kembalimenuUtama();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            DaftarMatkul();
                            kembalimenuUtama();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            DaftarMatkul();
                            InputRS();
                            kembalimenuUtama();
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\tMATA KULIAH YANG TELAH DI AMBIL ");
                            Console.WriteLine("\t==============================");
                            LihatPrs();
                            Console.WriteLine("\t==============================");
                            kembalimenuUtama();
                            break;
                        }
                    case 6:
                        {
                            HapusPrs();
                            break;
                        }
                    default:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            catch
            {
                Console.Clear();
                MenuUtama();
            }
        }
        static void kembalimenuUtama()
        {
            Console.WriteLine("");
            Console.WriteLine("Apakah anda ingin kembali ke menuutama ? (Y/N)");
            string kembali = Console.ReadLine();
            if (kembali == "Y" || kembali == "y")
            {
                do
                {
                    Console.Clear();
                    MenuUtama();
                    Console.WriteLine("");
                }
                while (true);
            }
            else if (kembali == "N" || kembali == "n")
            {
                Environment.Exit(0);
            }
        }
        static void DaftarDosen()
        {
            string[] nama_dosen = { "Ilham", "Nofal", "Rahmi", "Wenda", "Anjas", "iqbal" };
            string[] kode_dosen = { "TAP", "PAL", "RMI", "WND", "AJO", "GAL" };
            Console.WriteLine("NAMA DOSEN |   KODE");
            Console.WriteLine("===================");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{i + 1}.  {nama_dosen[i]}  |   {kode_dosen[i]}");
            }
        }
        static void DaftarMatkul()
        {
            Console.WriteLine("\t==========================");
            Console.WriteLine("\t     DAFTAR MATA KULIAH   ");
            Console.WriteLine("\t==========================");
            List<string> mk = new List<string>();
            mk.Add("\t1. Kalkulus");
            mk.Add("\t2. Bahasa Indonesia");
            mk.Add("\t3. Bahasa Inggris");
            mk.Add("\t4. Statistika");
            mk.Add("\t5. Algoritma Pemograman");
            mk.Add("\t6. Pengolahan Sinyal dan Waktu Kontinu");
            mk.Add("\t7. Rangkaian Listrik");
            mk.ForEach(Console.WriteLine);
        }
        static void InputRS()
        {
            try
            {
                Console.WriteLine("");
                Console.Write("Masukkan jumlah matakuliah yang ingin diambil : ");
                int jumlah = int.Parse(Console.ReadLine());

                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine("");
                    Console.Write("\tPilihan " + (i + 1) + ":");
                    String input = Console.ReadLine();
                    subjects.Add(input);
                }
            }
            catch
            {
                Console.WriteLine("Masukkan harus berupa angka !");
                InputRS();
            }
        }
        static void LihatPrs ()
        {
            for (int i = 0; i < subjects.Count; i++)
            {
                Console.WriteLine("\t"+(i + 1) + " : " + subjects[i]);
            }
           // subjects.ForEach(Console.WriteLine );
        }
        static void HapusPrs()
        {
            Console.WriteLine("");
            LihatPrs();
            Console.WriteLine("");
            Console.Write("Silahkan Masukkan data yang ingin di hapus :");
            //int hapus = Convert.ToInt32(Console.ReadLine());
            string hapus = Console.ReadLine();
            foreach (var item in subjects)
            {
                if (item == hapus)
                {
                    subjects.Remove(hapus);
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Input salah, Format harus sama dengan List !");
                    HapusPrs();
                }
            }
        }
        static void profileilhampatri()
        {
            idp.TempatLahir = "Padang";
            idp.Alamat = "Jl. Padang 123";
            idp.Kelas = "ELEKTRO 41";
            idp.Jurusan = "TEKNIK ELEKTRO";
            Console.WriteLine(""); ;
            idp.patripenting();
        }
        static void profileakbar()
        {
            idp.TempatLahir = "Jakarta";
            idp.Alamat = "Jl. Jakarta 123";
            idp.Kelas = "ELEKTRO 41";
            idp.Jurusan = "TEKNIK ELEKTRO";
            Console.WriteLine(""); ;
            idp.akbarpenting();
        }
    }
}

/*
           for (int i = 0; i < subjects.Count; i++)
          {
              if (i == hapus)
              {
                  subjects.RemoveAt(hapus);
              }
              else
              {
                  Console.WriteLine("");
                  Console.WriteLine("Input salah, Format harus sama dengan List !");
                  HapusPrs();
              }
          }
          */



