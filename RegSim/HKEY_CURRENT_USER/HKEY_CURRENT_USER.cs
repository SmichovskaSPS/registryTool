using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HKEY_CURRENT_USER
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_CURRENT_USER
    /// </summary>
    public class HKEY_CURRENT_USER{
        string name = "HKEY_CURRENT_USER";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HKEY_CURRENT_USER(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_CURRENT_USER
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            ControlPanel.ControlPanel.CreateFolder(this.Path + this.Name);
            Software.Software.CreateFolder(this.Path + this.Name);
        }
    }

    namespace ControlPanel
    {
        public class ControlPanel
        {
            string name = "ControlPanel";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                ControlPanel create = new ControlPanel();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                Mouse.Mouse.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace Mouse
        {
            public class Mouse
            {
                string name = "Mouse";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    Mouse create = new Mouse();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                    Common.Common.CreateFile("DoubleClickSpeed", "00000000", path + "/" + create.Name);
                }
            }
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
                        CTF.CTF.CreateFolder(path + "/" + create.Name);
                        CurrentVersion.CurrentVersion.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace CTF
                {
                    public class CTF
                    {
                        string name = "CTF";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            CTF create = new CTF();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                            LangBar.LangBar.CreateFolder(path + "/" + create.Name);
                        }
                    }

                    namespace LangBar
                    {
                        public class LangBar
                        {
                            string name = "LangBar";
                            public string Name { get { return this.name; } }

                            public static void CreateFolder(string path)
                            {
                                LangBar create = new LangBar();
                                System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                Common.Common.CreateFile("ShowStatus", "00000000", path + "/" + create.Name);
                            }
                        }
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
                            Explorer.Explorer.CreateFolder(path + "/" + create.Name);
                            Policies.Policies.CreateFolder(path + "/" + create.Name);
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
                                Advanced.Advanced.CreateFolder(path + "/" + create.Name);
                            }
                        }

                        namespace Advanced
                        {
                            public class Advanced
                            {
                                string name = "Advanced";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    Advanced create = new Advanced();
                                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                    Common.Common.CreateFile("HideIcons", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("ExtendedUIHoverTime", "00000000", path + "/" + create.Name);
                                }
                            }
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
                                SystemF.SystemF.CreateFolder(path + "/" + create.Name);
                                Explorer.Explorer.CreateFolder(path + "/" + create.Name);

                                Common.Common.CreateFile("NoChangeStartMenu", "00000000", path + "/" + create.Name);
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

                                    Common.Common.CreateFile("NoDispSettingsPage", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoDispScrSavPage", "00000000", path + "/" + create.Name);
                                }
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
                                    Advanced.Advanced.CreateFolder(path + "/" + create.Name);

                                    Common.Common.CreateFile("enableAutoTray", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoViewContextMenu", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoFolderOptions", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoPropertiesRecycleBin", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoManageMyComputerVerb", "00000000", path + "/" + create.Name);
                                }
 
                            }

                            namespace Advanced
                            {
                                public class Advanced
                                {
                                    string name = "Advanced";
                                    public string Name { get { return this.name; } }

                                    public static void CreateFolder(string path)
                                    {
                                        Advanced create = new Advanced();
                                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                                        HideIcons.HideIcons.CreateFolder(path + "/" + create.Name);
                                    }
                                }

                                namespace HideIcons
                                {
                                    public class HideIcons
                                    {
                                        string name = "HideIcons";
                                        public string Name { get { return this.name; } }

                                        public static void CreateFolder(string path)
                                        {
                                            HideIcons create = new HideIcons();
                                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        
    }
}
