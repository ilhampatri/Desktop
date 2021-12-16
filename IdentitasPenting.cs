using System;
using System.Collections.Generic;
using System.Text;

namespace DasarCSharp
{
    class IdentitasPenting :Identitas
    {
        public void patripenting(/*String ibu_kandung = "ibupatri"*/)
        {
            base.introduction();
            String ibu_kandung = "ibupatri";
            Console.WriteLine("Nama ibu \t:" + ibu_kandung);
        }
        public void akbarpenting(/*string ibu_kandung = "ibuakbar"*/)
        {
            base.introduction();
            string ibu_kandung = "ibuakbar";
            Console.WriteLine("Nama ibu \t:" + ibu_kandung);
        }
    }
}
