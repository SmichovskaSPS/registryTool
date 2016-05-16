using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnStart
{
    /// <summary>
    /// Obsahuje metody pro vytvoření defautních hives a keys
    /// </summary>
    public class OnStart
    {
        public string Path { get; set; }
        //Vytvoří hierarchickou strukturu hives na disku, vytvoří defaultní keys
        public static void CreateFolders()
        {
            KeyPaths.KeyPaths keyPaths = new KeyPaths.KeyPaths();
            string path = keyPaths.Path;

            HKEY_CURRENT_USER.HKEY_CURRENT_USER hkey_current_user = new HKEY_CURRENT_USER.HKEY_CURRENT_USER(path);
            hkey_current_user.CreateFolder();

            HKEY_LOCAL_MACHINE.HKEY_LOCAL_MACHINE hkey_local_machine = new HKEY_LOCAL_MACHINE.HKEY_LOCAL_MACHINE(path);
            hkey_local_machine.CreateFolder();

            HKEY_CLASSES_ROOT.HKEY_CLASSES_ROOT hkey_classes_root = new HKEY_CLASSES_ROOT.HKEY_CLASSES_ROOT(path);
            hkey_classes_root.CreateFolder();
        }
    }
}
