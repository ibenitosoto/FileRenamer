using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryRenamer.RenameDirectoryTree(@"C:\Users\Nacho\OneDrive - Atlantic TU\Computer Architecture", 
                                                name => name.Replace(" - Tagged", ""));
        }
    }
}
