using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKEY_LOCAL_MACHINE
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_LOCAL_MACHINE
    /// </summary>
    public class HKEY_LOCAL_MACHINE
    {
        string name = "HKEY_LOCAL_MACHINE";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HKEY_LOCAL_MACHINE(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_LOCAL_MACHINE
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            Software.Software.CreateFolder(this.Path + this.Name);
            SystemF.SystemF.CreateFolder(this.Path + this.Name);
        }
    }

    namespace Software
    {
        public class Software
        {
            string name = "Software";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                Software create = new Software();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                Microsoft.Microsoft.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace Microsoft
        {
            public class Microsoft
            {
                string name = "Microsoft";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    Microsoft create = new Microsoft();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                    Windows.Windows.CreateFolder(path + "/" + create.Name);
                }
            }

            namespace Windows
            {
                public class Windows
                {
                    string name = "Windows";
                    public string Name { get { return this.name; } }

                    public static void CreateFolder(string path)
                    {
                        Windows create = new Windows();
                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                        CurrentVersion.CurrentVersion.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace CurrentVersion
                {
                    public class CurrentVersion
                    {
                        string name = "CurrentVersion";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            CurrentVersion create = new CurrentVersion();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                            Policies.Policies.CreateFolder(path + "/" + create.Name);
                        }
                    }

                    namespace Policies
                    {
                        public class Policies
                        {
                            string name = "Policies";
                            public string Name { get { return this.name; } }

                            public static void CreateFolder(string path)
                            {
                                Policies create = new Policies();
                                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                                Explorer.Explorer.CreateFolder(path + "/" + create.Name);
                                SystemF.SystemF.CreateFolder(path + "/" + create.Name);
                            }
                        }

                        namespace Explorer
                        {
                            public class Explorer
                            {
                                string name = "Explorer";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    Explorer create = new Explorer();
                                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                    Common.Common.CreateFile("HideClock", "00000000", path + "/" + create.Name);
                                }
                            }
                        }

                        namespace SystemF
                        {
                            public class SystemF
                            {
                                string name = "System";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    SystemF create = new SystemF();
                                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                    Common.Common.CreateFile("DisableTaskbar", "00000000", path + "/" + create.Name);
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    namespace SystemF
    {
        public class SystemF
        {
            string name = "System";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                SystemF create = new SystemF();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                CurrentControlSet.CurrentControlSet.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace CurrentControlSet
        {
            public class CurrentControlSet
            {
                string name = "CurrentControlSet";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    CurrentControlSet create = new CurrentControlSet();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                    Control.Control.CreateFolder(path + "/" + create.Name);
                }
            }

            namespace Control
            {
                public class Control
                {
                    string name = "Control";
                    public string Name { get { return this.name; } }

                    public static void CreateFolder(string path)
                    {
                        Control create = new Control();
                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                        KeyboardLayout.KeyboardLayout.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace KeyboardLayout
                {
                    public class KeyboardLayout
                    {
                        string name = "KeyboardLayout";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            KeyboardLayout create = new KeyboardLayout();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                            Common.Common.CreateFile("ScancodeMap", "", path + "/" + create.Name);
                        }
                    }
                }
            }
        }
    }
}
