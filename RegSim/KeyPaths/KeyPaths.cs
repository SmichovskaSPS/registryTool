using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeyPaths
{
    /// <summary>
    /// Uchovává cestu, kam se vytvoří systém hives
    /// </summary>
    public class KeyPaths
    {
        string path = "RegSim Data/";
        public string Path { get { return this.path; } }

        //obsahuje cesty ke všem keys
        public IDictionary<string, string> KeyList()
        {
            string firstPartOfPath = @"\Studentsky_Projekt\RegSim\RegSim\bin\Debug\" + this.Path;
            string HCU_path = firstPartOfPath + @"HKEY_CURRENT_USER\";
            string HLM_path = firstPartOfPath + @"HKEY_LOCAL_MACHINE\";
            string HCR_path = firstPartOfPath + @"HKEY_CLASSES_ROOT\";

            IDictionary<string, string> keys = new Dictionary<string, string>();

            #region HKEY_CURRENT_USER
            //skrytí lišty | 1
            keys.Add("enableAutoTray", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\enableAutoTray.txt");
            //skrytí ikon programů (na liště i ploše) | 1
            keys.Add("HideIcons", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\HideIcons.txt");
            //disable animaci na ikonách po přejetí myší (na liště) | 1
            keys.Add("ExtendedUIHoverTime", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced\ExtendedUIHoverTime.txt");
            //nezobrazování startu (po kliknutí na ikonu Startu levým tlačítkem) | 1
            keys.Add("NoChangeStartMenu", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\NoChangeStartMenu.txt");
            //nezobrazení nabídky po kliknutí na jazyk (na liště levým tlačítkem) | 1
            keys.Add("ShowStatus", HCU_path + @"Software\Microsoft\Windows\CTF\LangBar\ShowStatus.txt");
            //nezobrazení nabídky pravého tlačítka po kliknutí pravým tlačítkem na volnou plochu nebo na ikonu programu na ploše | 1
            keys.Add("NoViewContextMenu", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoViewContextMenu.txt");
            //nespuštění programu po double-clicku (na ploše) -> disable double-clicku | 1
            keys.Add("DoubleClickSpeed", HCU_path + @"ControlPanel\Mouse\DoubleClickSpeed.txt");
            //disable click na Vytvoření nové složky (contextmenu volné plochy) | 1
            keys.Add("NoFolderOptions", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoFolderOptions.txt");
            //disable click na Nastavení zobrazení (contextmenu volné plochy) | 1
            keys.Add("NoDispSettingsPage", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\System\NoDispSettingsPage.txt");
            //disable click na Přizpůsobit (contextmenu volné plochy) | 1
            keys.Add("NoDispScrSavPage", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\System\NoDispScrSavPage.txt");
            //disable click na Vysypat koš (contextmenu koše) | 1
            keys.Add("NoPropertiesRecycleBin", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoPropertiesRecycleBin.txt");
            //disable click na Spravovat (contextmenu Tento PC)
            keys.Add("NoManageMyComputerVerb", HCU_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\NoManageMyComputerVerb.txt");
            #endregion
  
            #region HKEY_LOCAL_MACHINE
            //skrytí datumu (lišta) | 1
            keys.Add("HideClock", HLM_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\HideClock.txt");   
            //disable click na Správce úloh (contextmenu lišty) | 1
            keys.Add("DisableTaskbar", HLM_path + @"Software\Microsoft\Windows\CurrentVersion\Policies\System\DisableTaskbar.txt");
            //disable stisk kláves (klávesnice) | (00_1E),(00_30),(.....)
            keys.Add("ScancodeMap", HLM_path + @"System\CurrentControlSet\Control\KeyboardLayout\ScancodeMap.txt");
            #endregion

            #region HKEY_CLASSES_ROOT
            //skrytí ikony Start (lišta) | {-5b4dae26b807-11d0-9815-00c04fd91972} (pomlčka za opening bracket)
            keys.Add("{5b4dae26b807-11d0-9815-00c04fd91972}", HCR_path + @"CLSID\{5b4dae26b807-11d0-9815-00c04fd91972}");
            //upravená verze key výše
            keys.Add("{-5b4dae26b807-11d0-9815-00c04fd91972}", HCR_path + @"CLSID\{-5b4dae26b807-11d0-9815-00c04fd91972}"); 
            #endregion

            return keys;
        }
    }

}
