using System;
using System.Collections.Generic;
using System.Text;

namespace DasarCSharp
{
    class Identitas
    {
        public string TempatLahir { get; set; }
        public string Alamat { get; set; }
        public string Kelas { get; set; }
        public string Jurusan { get; set; }
        public void introduction()
        {
            Console.WriteLine("================");
            Console.WriteLine($"Tempat Lahir \t: {TempatLahir}");
            Console.WriteLine($"Alamat \t\t: {Alamat}");
            Console.WriteLine($"Kelas \t\t: {Kelas}");
            Console.WriteLine($"Jurusan \t: {Jurusan}");
        }
    }
}
