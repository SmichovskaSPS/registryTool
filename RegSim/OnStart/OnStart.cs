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

            HiveCurrentUser.HiveCurrentUser hiveCurrentUser = new HiveCurrentUser.HiveCurrentUser(path);
            hiveCurrentUser.CreateFolder();

            HiveLocalMachine.HiveLocalMachine hiveLocalMachine = new HiveLocalMachine.HiveLocalMachine(path);
            hiveLocalMachine.CreateFolder();

            HiveClassesRoot.HiveClassesRoot hiveClassesRoot = new HiveClassesRoot.HiveClassesRoot(path);
            hiveClassesRoot.CreateFolder();
        }
    }
}
