using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HiveCurrentUser
{
    /// <summary>
    /// Obsahuje metody pro vytvoření všech defaultních hives a keys v nadřazeném hive HKEY_CURRENT_USER
    /// </summary>
    public class HiveCurrentUser{
        string name = "HKEY_CURRENT_USER";
        public string Name { get { return this.name; } }
        public string Path { get; set; }

        public HiveCurrentUser(string path)
        {
            this.Path = path;
        }

        // Vytvoří všechny hives a keys nadřazeného hivu HKEY_CURRENT_USER
        public void CreateFolder()
        {
            System.IO.Directory.CreateDirectory(this.Path + this.Name);
            HiveControlPanel.HiveControlPanel.CreateFolder(this.Path + this.Name);
            HiveSoftware.HiveSoftware.CreateFolder(this.Path + this.Name);
        }
    }

    namespace HiveControlPanel
    {
        public class HiveControlPanel
        {
            string name = "ControlPanel";
            public string Name { get { return this.name; } }

            public static void CreateFolder(string path)
            {
                HiveControlPanel create = new HiveControlPanel();
                System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                HiveMouse.HiveMouse.CreateFolder(path + "/" + create.Name);
            }
        }

        namespace HiveMouse
        {
            public class HiveMouse
            {
                string name = "Mouse";
                public string Name { get { return this.name; } }

                public static void CreateFolder(string path)
                {
                    HiveMouse create = new HiveMouse();
                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                    Common.Common.CreateFile("DoubleClickSpeed", "00000000", path + "/" + create.Name);
                }
            }
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
                        HiveCTF.HiveCTF.CreateFolder(path + "/" + create.Name);
                        HiveCurrentVersion.HiveCurrentVersion.CreateFolder(path + "/" + create.Name);
                    }
                }

                namespace HiveCTF
                {
                    public class HiveCTF
                    {
                        string name = "CTF";
                        public string Name { get { return this.name; } }

                        public static void CreateFolder(string path)
                        {
                            HiveCTF create = new HiveCTF();
                            System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                            HiveLangBar.HiveLangBar.CreateFolder(path + "/" + create.Name);
                        }
                    }

                    namespace HiveLangBar
                    {
                        public class HiveLangBar
                        {
                            string name = "LangBar";
                            public string Name { get { return this.name; } }

                            public static void CreateFolder(string path)
                            {
                                HiveLangBar create = new HiveLangBar();
                                System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                Common.Common.CreateFile("ShowStatus", "00000000", path + "/" + create.Name);
                            }
                        }
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
                            HiveExplorer.HiveExplorer.CreateFolder(path + "/" + create.Name);
                            HivePolicies.HivePolicies.CreateFolder(path + "/" + create.Name);
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
                                HiveAdvanced.HiveAdvanced.CreateFolder(path + "/" + create.Name);
                            }
                        }

                        namespace HiveAdvanced
                        {
                            public class HiveAdvanced
                            {
                                string name = "Advanced";
                                public string Name { get { return this.name; } }

                                public static void CreateFolder(string path)
                                {
                                    HiveAdvanced create = new HiveAdvanced();
                                    System.IO.Directory.CreateDirectory(path + "/" + create.Name);

                                    Common.Common.CreateFile("HideIcons", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("ExtendedUIHoverTime", "00000000", path + "/" + create.Name);
                                }
                            }
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
                                HiveSystem.HiveSystem.CreateFolder(path + "/" + create.Name);
                                HiveExplorer.HiveExplorer.CreateFolder(path + "/" + create.Name);

                                Common.Common.CreateFile("NoChangeStartMenu", "00000000", path + "/" + create.Name);
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

                                    Common.Common.CreateFile("NoDispSettingsPage", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoDispScrSavPage", "00000000", path + "/" + create.Name);
                                }
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
                                    HiveAdvanced.HiveAdvanced.CreateFolder(path + "/" + create.Name);

                                    Common.Common.CreateFile("enableAutoTray", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoViewContextMenu", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoFolderOptions", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoPropertiesRecycleBin", "00000000", path + "/" + create.Name);
                                    Common.Common.CreateFile("NoManageMyComputerVerb", "00000000", path + "/" + create.Name);
                                }
 
                            }

                            namespace HiveAdvanced
                            {
                                public class HiveAdvanced
                                {
                                    string name = "Advanced";
                                    public string Name { get { return this.name; } }

                                    public static void CreateFolder(string path)
                                    {
                                        HiveAdvanced create = new HiveAdvanced();
                                        System.IO.Directory.CreateDirectory(path + "/" + create.Name);
                                        HiveHideIcons.HiveHideIcons.CreateFolder(path + "/" + create.Name);
                                    }
                                }

                                namespace HiveHideIcons
                                {
                                    public class HiveHideIcons
                                    {
                                        string name = "HideIcons";
                                        public string Name { get { return this.name; } }

                                        public static void CreateFolder(string path)
                                        {
                                            HiveHideIcons create = new HiveHideIcons();
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
