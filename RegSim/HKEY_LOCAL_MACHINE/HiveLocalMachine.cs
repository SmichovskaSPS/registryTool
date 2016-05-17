using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveLocalMachine
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_LOCAL_MACHINE
    /// </summary>
    public class HiveLocalMachine
    {
        string name = "HKEY_LOCAL_MACHINE";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HiveLocalMachine(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_LOCAL_MACHINE
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            HiveSoftware.HiveSoftware.CreateFolder(this.Path + this.Name);
            HiveSystem.HiveSystem.CreateFolder(this.Path + this.Name);
        }
    }

    namespace HiveSoftware
    {
        public class HiveSoftware
        {
            string name = "Software";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                HiveSoftware create = new HiveSoftware();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                HiveMicrosoft.HiveMicrosoft.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace HiveMicrosoft
        {
            public class HiveMicrosoft
            {
                string name = "Microsoft";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    HiveMicrosoft create = new HiveMicrosoft();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                    HiveWindows.HiveWindows.CreateFolder(path + "/" + create.Name);
                }
            }

            namespace HiveWindows
            {
                public class HiveWindows
                {
                    string name = "Windows";
                    public string Name { get { return this.name; } }

                    public static void CreateFolder(string path)
                    {
                        HiveWindows create = new HiveWindows();
                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                        HiveCurrentVersion.HiveCurrentVersion.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace HiveCurrentVersion
                {
                    public class HiveCurrentVersion
                    {
                        string name = "CurrentVersion";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            HiveCurrentVersion create = new HiveCurrentVersion();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                            HivePolicies.HivePolicies.CreateFolder(path + "/" + create.Name);
                        }
                    }

                    namespace HivePolicies
                    {
                        public class HivePolicies
                        {
                            string name = "Policies";
                            public string Name { get { return this.name; } }

                            public static void CreateFolder(string path)
                            {
                                HivePolicies create = new HivePolicies();
                                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                                HiveExplorer.HiveExplorer.CreateFolder(path + "/" + create.Name);
                                HiveSystem.HiveSystem.CreateFolder(path + "/" + create.Name);
                            }
                        }

                        namespace HiveExplorer
                        {
                            public class HiveExplorer
                            {
                                string name = "Explorer";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    HiveExplorer create = new HiveExplorer();
                                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                    Common.Common.CreateFile("HideClock", "00000000", path + "/" + create.Name);
                                }
                            }
                        }

                        namespace HiveSystem
                        {
                            public class HiveSystem
                            {
                                string name = "System";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    HiveSystem create = new HiveSystem();
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

    namespace HiveSystem
    {
        public class HiveSystem
        {
            string name = "System";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                HiveSystem create = new HiveSystem();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                HiveCurrentControlSet.HiveCurrentControlSet.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace HiveCurrentControlSet
        {
            public class HiveCurrentControlSet
            {
                string name = "CurrentControlSet";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    HiveCurrentControlSet create = new HiveCurrentControlSet();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                    HiveControl.HiveControl.CreateFolder(path + "/" + create.Name);
                }
            }

            namespace HiveControl
            {
                public class HiveControl
                {
                    string name = "Control";
                    public string Name { get { return this.name; } }

                    public static void CreateFolder(string path)
                    {
                        HiveControl create = new HiveControl();
                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                        HiveKeyboardLayout.HiveKeyboardLayout.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace HiveKeyboardLayout
                {
                    public class HiveKeyboardLayout
                    {
                        string name = "KeyboardLayout";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            HiveKeyboardLayout create = new HiveKeyboardLayout();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                            Common.Common.CreateFile("ScancodeMap", "", path + "/" + create.Name);
                        }
                    }
                }
            }
        }
    }
}
