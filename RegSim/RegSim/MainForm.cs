using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CC = Common.Common;

namespace RegSim
{
    /// <summary>
    /// Startovní dialogové okno aplikace, obsahuje konfiguraci grafického simulátoru
    /// </summary>
    public partial class MainForm : Form
    {
        private Keyboard keyboard = new Keyboard();
        private KeyPaths.KeyPaths keyPaths = new KeyPaths.KeyPaths();
        private bool animationOn, showStart, showLangContext, showDesktopOrIconContext, spusteniProgramuPlocha, showListaContext = true;
        private bool listaHidden = false;
        private List<string> restrictedText = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            if (!Directory.Exists("RegSim Data")) { 
                OnStart.OnStart.CreateFolders();
            }
            KeyBehavior();
            keyboard.AdviseParent += new Keyboard.AdviseParentEventHandler(SetFromKeyboard);
            DateTime dateTime = DateTime.UtcNow.Date;
            date.Text = dateTime.ToString("dd/MM/yyyy");
        }
 
        //zobrazuje input poslaný formulářem Klávesnice v textovém editoru
        public void SetFromKeyboard(string text)
        {
            bool write = true;
            foreach (string item in restrictedText)
            {
                if(text == item.ToLower() || text == item.ToUpper())
                {
                    write = false;
                }
            }
            if (write)
            {
                keyboardOutputTextBox.Text += text;
            }
        }
    
        //po kliknutí na tlačítko "Otevřít" zobrazí OpenFileDialog pro výběr key, po stisku OK otevře klíč v dialogovém okně EditKey 
        private void otevritButton_Click(object sender, EventArgs e)
        {
            DialogResult result = vyberKey.ShowDialog();

            if (result == DialogResult.OK)
            {
                string cestaSouboru = vyberKey.FileName;
                string nazevSouboru = Path.GetFileName(cestaSouboru);

                try
                {
                    EditKey editKey = new EditKey(nazevSouboru, cestaSouboru);
                    editKey.Show();
                    editKey.AdviseParent += new EditKey.AdviseParentEventHandler(EditClosed);
                }
                catch (IOException)
                {
                }
            }
            else
            {
                KeyBehavior();
            }      
        }
        
        //po stisknutí tlačítka "OK" formuláře "EditKey" vykoná metodu "KeyBehavior" (změny simulátoru v závislosti na hodnotách keys)
        public void EditClosed(bool closed)
        {
            if(closed == true)
            {
                KeyBehavior();
            }
        }

        //zkontroluje všechny keys a provede změny v simulátoru v závislosti na jejich hodnotě
        public void KeyBehavior()
        {
            IDictionary<string, string> keys = keyPaths.KeyList();

            #region HKEY_CURRENT_USER
            if (File.Exists(keys["enableAutoTray"]) && CC.IsOne(keys["enableAutoTray"]))
            {
                listaHidden = true;
                this.lista.Visible = false;
                this.winIcon.Visible = false;
                this.sm_notepad.Visible = false;
                this.sm_tentoPocitac.Visible = false;
                this.sm_kos.Visible = false;
                this.sm_folder.Visible = false;
                this.language.Visible = false;
                this.date.Visible = false;
            }
            else
            {
                listaHidden = false;
                this.lista.Visible = true;
                this.winIcon.Visible = true;
                this.sm_notepad.Visible = true;
                this.sm_tentoPocitac.Visible = true;
                this.sm_kos.Visible = true;
                this.sm_folder.Visible = true;
                this.language.Visible = true;
                this.date.Visible = true;
            }

            if (File.Exists(keys["HideIcons"]) && CC.IsOne(keys["HideIcons"]))
            {
                this.notepad.Visible = false;
                this.tentoPocitac.Visible = false;
                this.kos.Visible = false;
                this.folder.Visible = false;
                this.sm_notepad.Visible = false;
                this.sm_tentoPocitac.Visible = false;
                this.sm_kos.Visible = false;
                this.sm_folder.Visible = false;
            }
            else
            {
                this.notepad.Visible = true;
                this.tentoPocitac.Visible = true;
                this.kos.Visible = true;
                this.folder.Visible = true;
                if (!listaHidden)
                {
                    this.sm_notepad.Visible = true;
                    this.sm_tentoPocitac.Visible = true;
                    this.sm_kos.Visible = true;
                    this.sm_folder.Visible = true;
                }
            }

            if (File.Exists(keys["ExtendedUIHoverTime"]) && CC.IsOne(keys["ExtendedUIHoverTime"]))
            {
                animationOn = false;
            }
            else
            {
                animationOn = true;
            }

            if (File.Exists(keys["NoChangeStartMenu"]) && CC.IsOne(keys["NoChangeStartMenu"]))
            {
                showStart = false;
            }
            else
            {
                showStart = true;
            }

            if (File.Exists(keys["ShowStatus"]) && CC.IsOne(keys["ShowStatus"]))
            {
                showLangContext = false;
            }
            else
            {
                showLangContext = true;
            }

            if (File.Exists(keys["NoViewContextMenu"]) && CC.IsOne(keys["NoViewContextMenu"]))
            {
                showDesktopOrIconContext = false;
            }
            else
            {
                showDesktopOrIconContext = true;
            }

            if (File.Exists(keys["DoubleClickSpeed"]) && CC.IsOne(keys["DoubleClickSpeed"]))
            {
                spusteniProgramuPlocha = false;
            }
            else
            {
                spusteniProgramuPlocha = true;
            }

            if (File.Exists(keys["NoFolderOptions"]) && CC.IsOne(keys["NoFolderOptions"]))
            {
                plochaContextNovaSlozka.Enabled = false;
            }
            else
            {
                plochaContextNovaSlozka.Enabled = true;
            }

            if (File.Exists(keys["NoDispSettingsPage"]) && CC.IsOne(keys["NoDispSettingsPage"]))
            {
                plochaContextNastaveniZobrazeni.Enabled = false;
            }
            else
            {
                plochaContextNastaveniZobrazeni.Enabled = true;
            }

            if (File.Exists(keys["NoDispScrSavPage"]) && CC.IsOne(keys["NoDispScrSavPage"]))
            {
                plochaContextPrizpusobit.Enabled = false;
            }
            else
            {
                plochaContextPrizpusobit.Enabled = true;
            }

            if (File.Exists(keys["NoPropertiesRecycleBin"]) && CC.IsOne(keys["NoPropertiesRecycleBin"]))
            {
                kosContextVysypatKos.Enabled = false;
            }
            else
            {
                kosContextVysypatKos.Enabled = true;
            }

            if (File.Exists(keys["NoManageMyComputerVerb"]) && CC.IsOne(keys["NoManageMyComputerVerb"]))
            {
                tentoPCContextSpravovat.Enabled = false;
            }
            else
            {
                tentoPCContextSpravovat.Enabled = true;
            }

            #endregion

            #region HKEY_LOCAL_MACHINE
            if (File.Exists(keys["HideClock"]) && CC.IsOne(keys["HideClock"]))
            {
                this.date.Visible = false;
            }
            else
            {
                if (!listaHidden)
                {
                    this.date.Visible = true;
                }
            }

            if (File.Exists(keys["DisableTaskbar"]) && CC.IsOne(keys["DisableTaskbar"]))
            {
                showListaContext = false;
            }
            else
            {
                showListaContext = true;
            }

            if (File.Exists(keys["ScancodeMap"]))
            {
                FileStream klavesyStream = new FileStream(keys["ScancodeMap"],FileMode.Open);
                StreamReader klavesyReader = new StreamReader(klavesyStream);
                string obsahScancode = klavesyReader.ReadToEnd();
                klavesyReader.Close();
                klavesyStream.Close();

                #region disabledKeyboardKeys
                if (obsahScancode.Contains("(00_1E)"))
                {
                    restrictedText.Add("a");
                }
                if (obsahScancode.Contains("(00_30)"))
                {
                    restrictedText.Add("b");
                }
                if (obsahScancode.Contains("(00_2E)"))
                {
                    restrictedText.Add("c");
                }
                if (obsahScancode.Contains("(00_20)"))
                {
                    restrictedText.Add("d");
                }
                if (obsahScancode.Contains("(00_12)"))
                {
                    restrictedText.Add("e");
                }
                if (obsahScancode.Contains("(00_21)"))
                {
                    restrictedText.Add("f");
                }
                if (obsahScancode.Contains("(00_22)"))
                {
                    restrictedText.Add("g");
                }
                if (obsahScancode.Contains("(00_23)"))
                {
                    restrictedText.Add("h");
                }
                if (obsahScancode.Contains("(00_17)"))
                {
                    restrictedText.Add("i");
                }
                if (obsahScancode.Contains("(00_24)"))
                {
                    restrictedText.Add("j");
                }
                if (obsahScancode.Contains("(00_25)"))
                {
                    restrictedText.Add("k");
                }
                if (obsahScancode.Contains("(00_26)"))
                {
                    restrictedText.Add("l");
                }
                if (obsahScancode.Contains("(00_32)"))
                {
                    restrictedText.Add("m");
                }
                if (obsahScancode.Contains("(00_31)"))
                {
                    restrictedText.Add("n");
                }
                if (obsahScancode.Contains("(00_18)"))
                {
                    restrictedText.Add("o");
                }
                if (obsahScancode.Contains("(00_19)"))
                {
                    restrictedText.Add("p");
                }
                if (obsahScancode.Contains("(00_10)"))
                {
                    restrictedText.Add("q");
                }
                if (obsahScancode.Contains("(00_13)"))
                {
                    restrictedText.Add("r");
                }
                if (obsahScancode.Contains("(00_1F)"))
                {
                    restrictedText.Add("s");
                }
                if (obsahScancode.Contains("(00_14)"))
                {
                    restrictedText.Add("t");
                }
                if (obsahScancode.Contains("(00_16)"))
                {
                    restrictedText.Add("u");
                }
                if (obsahScancode.Contains("(00_2F)"))
                {
                    restrictedText.Add("v");
                }
                if (obsahScancode.Contains("(00_11)"))
                {
                    restrictedText.Add("w");
                }
                if (obsahScancode.Contains("(00_2D)"))
                {
                    restrictedText.Add("x");
                }
                if (obsahScancode.Contains("(00_15)"))
                {
                    restrictedText.Add("y");
                }
                if (obsahScancode.Contains("(00_2C)"))
                {
                    restrictedText.Add("z");
                }
                if (obsahScancode.Contains("(00_27)"))
                {
                    restrictedText.Add(";");
                }
                if (obsahScancode.Contains("(00_34)"))
                {
                    restrictedText.Add(".");
                }
                if (obsahScancode.Contains("(E0_5B)"))
                {
                    restrictedText.Add("|WIN|");
                }
                if (obsahScancode.Contains("(00_39)"))
                {
                    restrictedText.Add(" ");
                }
                if (obsahScancode.Contains("(00_0F)"))
                {
                    restrictedText.Add("|TAB|");
                }

                if (obsahScancode.Contains("(E0_4F)"))
                {
                    restrictedText.Add("|ESC|");
                }
                if (obsahScancode.Contains("(E0_53)"))
                {
                    restrictedText.Add("|DEL|");
                }
                if (obsahScancode.Contains("(00_0E)"))
                {
                    restrictedText.Add("|BACKSPACE|");
                }
                if (obsahScancode.Contains("(E0_48)"))
                {
                    restrictedText.Add("|UP|");
                }
                if (obsahScancode.Contains("(E0_50)"))
                {
                    restrictedText.Add("|DOWN|");
                }
                if (obsahScancode.Contains("(E0_4B)"))
                {
                    restrictedText.Add("|LEFT|");
                }
                if (obsahScancode.Contains("(E0_4D)"))
                {
                    restrictedText.Add("|RIGHT|");
                }
                #endregion
            }
            else
            {
                restrictedText.Clear();
            }
            #endregion

            #region HKEY_CLASSES_ROOT
            if (Directory.Exists(keys["{5b4dae26b807-11d0-9815-00c04fd91972}"]) == false && Directory.Exists(keys["{-5b4dae26b807-11d0-9815-00c04fd91972}"]))
            {
                this.winIcon.Visible = false;
            }
            else
            {
                if (!listaHidden)
                {
                    this.winIcon.Visible = true;
                }
            }
            #endregion
        }

        //po kliknutí na tlačítko "Nápověda" zobrazí nápovědu aplikace
        private void napovedaButton_Click(object sender, EventArgs e)
        {
            Help napoveda = new Help();
            napoveda.ShowDialog();
        }

        //vrátí aplikaci do defaultního nastavení
        private void resetButton_Click(object sender, EventArgs e)
        {
            animationOn = true;
            showStart = true;
            showLangContext = true;
            showDesktopOrIconContext = true;
            spusteniProgramuPlocha = true;
            showListaContext = true;
            listaHidden = false;
            restrictedText.Clear();
            if (Directory.Exists("RegSim Data"))
            {
                Directory.Delete("RegSim Data", true);
                OnStart.OnStart.CreateFolders();
                MessageBox.Show("Data byla vrácena do výchozího nastavení");
                KeyBehavior();
            }
            else
            {
                MessageBox.Show("Systémové soubory nebyly nenalezeny");
            }
        }

        //řešení spouštění aplikací na ploše a liště
        #region SpusteniAplikaci
        private void notepad_DoubleClick(object sender, EventArgs e)
        {
            if (spusteniProgramuPlocha)
            {
                keyboardOutputTextBox.Visible = true;
                closeNotepadButton.Visible = true;
                keyboard.ShowDialog();
            }
        }
        private void tentoPocitac_DoubleClick(object sender, EventArgs e)
        {
            if (spusteniProgramuPlocha)
            {
                MessageBox.Show("Tento počítač otevřen");
            }
        }
        private void kos_DoubleClick(object sender, EventArgs e)
        {
            if (spusteniProgramuPlocha)
            {
                MessageBox.Show("Koš otevřen");
            }
        }
        private void folder_DoubleClick(object sender, EventArgs e)
        {
            if (spusteniProgramuPlocha)
            {
                MessageBox.Show("Složka otevřena");
            }
        }
        private void sm_notepad_Click(object sender, EventArgs e)
        {
            sm_notepad.Focus();
            keyboardOutputTextBox.Visible = true;
            closeNotepadButton.Visible = true;
            keyboard.ShowDialog();
        }

        private void sm_tentoPocitac_Click(object sender, EventArgs e)
        {
            sm_tentoPocitac.Focus();
            MessageBox.Show("Tento počítač otevřen");
        }

        private void sm_kos_Click(object sender, EventArgs e)
        {
            sm_kos.Focus();
            MessageBox.Show("Koš otevřen");
        }

        private void sm_folder_Click(object sender, EventArgs e)
        {
            sm_folder.Focus();
            MessageBox.Show("Složka otevřena");
        }
        #endregion

        //řešení zobrazování a skrývání defaultně skrytých Controls
        #region ControlsVisibility
        private void winIcon_Click(object sender, EventArgs e)
        {
            winIcon.Focus();
            if (showStart)
            {
                start.Visible = true;
                start.Focus();
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            start.Focus();
        }
        private void start_LostFocus(object sender, EventArgs e)
        {
            start.Visible = false;
        }
        private void language_Click(object sender, EventArgs e)
        {
            if (showLangContext)
            {
                jazykContext.Visible = true;
            }
        }
        private void language_LostFocus(object sender, EventArgs e)
        {
            jazykContext.Visible = false;
        }
        private void simulator_Click(object sender, EventArgs e)
        {
            simulator.Focus();
            plochaContextNovaSlozka.Visible = false;
            plochaContextPrizpusobit.Visible = false;
            plochaContextNastaveniZobrazeni.Visible = false;
            kosContextOtevrit.Visible = false;
            kosContextVysypatKos.Visible = false;
            tentoPCContextOtevrit.Visible = false;
            tentoPCContextSpravovat.Visible = false;
        }
        private void simulator_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showDesktopOrIconContext)
            {
                plochaContextNastaveniZobrazeni.Visible = true;
                plochaContextNovaSlozka.Visible = true;
                plochaContextPrizpusobit.Visible = true;
            }
        }
        private void kos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showDesktopOrIconContext)
            {
                kosContextOtevrit.Visible = true;
                kosContextVysypatKos.Visible = true;
                kosContextOtevrit.Focus();
            }
        }
        private void tentoPocitac_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showDesktopOrIconContext)
            {
                tentoPCContextOtevrit.Visible = true;
                tentoPCContextSpravovat.Visible = true;
                tentoPCContextOtevrit.Focus();
            }
        }
        private void lista_Click(object sender, EventArgs e)
        {
            lista.Focus();
        }
        private void lista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showListaContext)
            {
                listaContextSpravceUloh.Visible = true;
                listaContextSpravceUloh.Focus();
            }
        }
        private void listaContextSpravceUloh_LostFocus(object sender, EventArgs e)
        {
            listaContextSpravceUloh.Visible = false;
        }
        private void notepad_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showDesktopOrIconContext)
            {
                notepadContextOtevrit.Visible = true;
                notepadContextOtevrit.Focus();
            }
        }
        private void notepadContextOtevrit_LostFocus(object sender, EventArgs e)
        {
            notepadContextOtevrit.Visible = false;
        }
        private void folder_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && showDesktopOrIconContext)
            {
                folderContextOtevrit.Visible = true;
                folderContextOtevrit.Focus();
            }
        }
        private void folderContextOtevrit_LostFocus(object sender, EventArgs e)
        {
            folderContextOtevrit.Visible = false;
        }
        #endregion

        //po singleClicku na ikonu na ploše mění její pozadí, po Clicku mimo ho vrátí do defaultní hodnoty
        #region ZmenaPozadiClick 
        private void notepad_Click(object sender, EventArgs e)
        {
            notepad.BackColor = Color.BlueViolet;
            notepad.Focus();
        }
        private void notepad_LostFocus(object sender, EventArgs e)
        {
            notepad.BackColor = Color.White;
        }
        private void tentoPocitac_Click(object sender, EventArgs e)
        {
            tentoPocitac.BackColor = Color.BlueViolet;
            tentoPocitac.Focus();
        }
        private void tentoPocitac_LostFocus(object sender, EventArgs e)
        {
            tentoPocitac.BackColor = Color.White;
        }
        private void kos_Click(object sender, EventArgs e)
        {
            kos.BackColor = Color.BlueViolet;
            kos.Focus();
        }
        private void kos_LostFocus(object sender, EventArgs e)
        {
            kos.BackColor = Color.White;
        }
        private void folder_Click(object sender, EventArgs e)
        {
            folder.BackColor = Color.BlueViolet;
            folder.Focus();
        }
        private void folder_LostFocus(object sender, EventArgs e)
        {
            folder.BackColor = Color.White;
        }
        #endregion

        //mění pozadí ikony na liště po přejetí nad ní myší
        #region ZmenaPozadiHover
        private void sm_notepad_MouseEnter(object sender, EventArgs e)
        {
            if (animationOn)
            {
                sm_notepad.BackColor = Color.DodgerBlue;
            }
        }
        private void sm_notepad_MouseLeave(object sender, EventArgs e)
        {
            sm_notepad.BackColor = Color.White;
        }
        private void sm_tentoPocitac_MouseEnter(object sender, EventArgs e)
        {
            if (animationOn)
            {
                sm_tentoPocitac.BackColor = Color.DodgerBlue;
            }
        }
        private void sm_tentoPocitac_MouseLeave(object sender, EventArgs e)
        {
            sm_tentoPocitac.BackColor = Color.White;
        }
        private void sm_kos_MouseEnter(object sender, EventArgs e)
        {
            if (animationOn)
            {
                sm_kos.BackColor = Color.DodgerBlue;
            }
        }
        private void sm_kos_MouseLeave(object sender, EventArgs e)
        {
            sm_kos.BackColor = Color.White;
        }
        private void sm_folder_MouseEnter(object sender, EventArgs e)
        {
            if (animationOn)
            {
                sm_folder.BackColor = Color.DodgerBlue;
            }
        }
        private void sm_folder_MouseLeave(object sender, EventArgs e)
        {
            sm_folder.BackColor = Color.White;
        }
        #endregion

        //řeší spouštění událostí ContextMenu buttonů
        #region ContextMenuClicks
        private void plochaContextNovaSlozka_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nová složka založena");
        }
        private void plochaContextNastaveniZobrazeni_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nastavení zobrazení otevřeno");
        }
        private void plochaContextPrizpusobit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Přizpůsobit otevřeno");
        }
        private void kosContextOtevrit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koš otevřen");
        }
        private void kosContextVysypatKos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Koš vysypán");
        }
        private void tentoPCContextOtevrit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tento počítač otevřen");
        }
        private void tentoPCContextSpravovat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spravovat otevřeno");
        }
        private void folderContextOtevrit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Složka otevřena");
        }
        private void listaContextSpravceUloh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Správce úloh otevřen");
        }
        private void notepadContextOtevrit_Click(object sender, EventArgs e)
        {
            keyboardOutputTextBox.Visible = true;
            closeNotepadButton.Visible = true;
            keyboard.ShowDialog();
        }
        #endregion


        //po kliknutí na křížek v textovém editoru editor a klávesnici zavře
        private void closeNotepadButton_Click(object sender, EventArgs e)
        {
            closeNotepadButton.Visible = false;
            keyboardOutputTextBox.Visible = false;
        }
    }
}
