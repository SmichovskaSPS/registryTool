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

namespace RegSim
{
    /// <summary>
    /// Dialogové okno pro editaci vybraného key
    /// </summary>
    public partial class EditKey : Form
    {

        public string NazevSouboru { get; set; }
        public string CestaSouboru { get; set; }

        public delegate void AdviseParentEventHandler(bool closed);
        public event AdviseParentEventHandler AdviseParent;
       
        // zobrazí informace o klíči (např. název, cestu) a vypíše jeho obsah do textboxu
        public EditKey(string nazevSouboru, string cestaSouboru)
        {
            InitializeComponent();
            this.NazevSouboru = nazevSouboru;
            this.CestaSouboru = cestaSouboru;

            this.Text = this.NazevSouboru;
            pathLabel.Text = this.CestaSouboru;

            valueDataTextBox.Text = File.ReadAllText(cestaSouboru);

        }

        //posílá MainFormu informaci o tom, že bylo stisknuto tlačítko "OK" a formulář EditKey byl zavřen
        public void EditFormClosed(bool closed)
        {
            if (AdviseParent != null)
                AdviseParent(closed);
        }

        //po stisku tlačítka "Cancel" zavře dialogové okno
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //po stisku tlačítka "OK" uloží editovaný text do daného key (pokud je text validní), zavře dialogové okno
        private void okButton_Click(object sender, EventArgs e)
        {

            FileStream stream = new FileStream(CestaSouboru, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);

            if (valueDataTextBox.Text == String.Empty)
            {
                valueDataTextBox.Text = "No value";
            }

            writer.Write(valueDataTextBox.Text);

            writer.Close();
            stream.Close();

            this.Close();
            EditFormClosed(true);
        }      
    }

}
