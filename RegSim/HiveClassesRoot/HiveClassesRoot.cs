using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HiveClassesRoot
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_CLASSES_ROOT
    /// </summary>
    public class HiveClassesRoot
    {
        string name = "HKEY_CLASSES_ROOT";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HiveClassesRoot(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_CLASSES_ROOT
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            HiveCLSID.HiveCLSID.CreateFolder(this.Path + this.Name);
        }
    }

    namespace HiveCLSID
    {
        public class HiveCLSID
        {
            string name = "CLSID";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                HiveCLSID create = new HiveCLSID();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                HiveF5b.HiveF5b.CreateFolder(path + "/" + create.Name);
            }
        }

        //reprezentuje hive F_5b4dae26b807_11d0_9815_00c04fd91972
        namespace HiveF5b
        {
            public class HiveF5b
            {
                string name = @"{5b4dae26b807-11d0-9815-00c04fd91972}";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    HiveF5b create = new HiveF5b();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                   
                }
                
            }
        }
    }
}
