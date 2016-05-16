﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HKEY_CLASSES_ROOT
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_CLASSES_ROOT
    /// </summary>
    public class HKEY_CLASSES_ROOT
    {
        string name = "HKEY_CLASSES_ROOT";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HKEY_CLASSES_ROOT(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_CLASSES_ROOT
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            CLSID.CLSID.CreateFolder(this.Path + this.Name);
        }
    }

    namespace CLSID
    {
        public class CLSID
        {
            string name = "CLSID";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                CLSID create = new CLSID();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                F_5b4dae26b807_11d0_9815_00c04fd91972.F_5b4dae26b807_11d0_9815_00c04fd91972.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace F_5b4dae26b807_11d0_9815_00c04fd91972
        {
            public class F_5b4dae26b807_11d0_9815_00c04fd91972
            {
                string name = @"{5b4dae26b807-11d0-9815-00c04fd91972}";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    F_5b4dae26b807_11d0_9815_00c04fd91972 create = new F_5b4dae26b807_11d0_9815_00c04fd91972();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                   
                }
                
            }
        }
    }
}