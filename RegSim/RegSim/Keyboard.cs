using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegSim
{
    /// <summary>
    ///Obsahuje konfiguraci dialogového okna Klávesnice
    /// </summary>
    public partial class Keyboard : Form
    {
        public delegate void AdviseParentEventHandler(string text);
        public event AdviseParentEventHandler AdviseParent;

        public int ShiftClicks { get; set; }
        public int CapsClicks { get; set; }

        public Keyboard()
        {
            InitializeComponent();
            
        }

        //posílá input z klávesnice hlavnímu formuláři
        public void SetMainFormTextBox(string text)
        {
            if (AdviseParent != null)
                AdviseParent(text);
        }
        
        //podoba kláves v UpperCase podobě
        private void KeysToUpper()
        {
            aKey.Text = "A";
            bKey.Text = "B";
            cKey.Text = "C";
            dKey.Text = "D";
            eKey.Text = "E";
            fKey.Text = "F";
            gKey.Text = "G";
            hKey.Text = "H";
            iKey.Text = "I";
            jKey.Text = "J";
            kKey.Text = "K";
            lKey.Text = "L";
            mKey.Text = "M";
            nKey.Text = "N";
            oKey.Text = "O";
            pKey.Text = "P";
            qKey.Text = "Q";
            rKey.Text = "R";
            sKey.Text = "S";
            tKey.Text = "T";
            uKey.Text = "U";
            vKey.Text = "V";
            wKey.Text = "W";
            xKey.Text = "X";
            yKey.Text = "Y";
            zKey.Text = "Z";
        }

        //podoba kláves v LowerCase podobě
        private void KeysToLower()
        {
            aKey.Text = "a";
            bKey.Text = "b";
            cKey.Text = "c";
            dKey.Text = "d";
            eKey.Text = "e";
            fKey.Text = "f";
            gKey.Text = "g";
            hKey.Text = "h";
            iKey.Text = "i";
            jKey.Text = "j";
            kKey.Text = "k";
            lKey.Text = "l";
            mKey.Text = "m";
            nKey.Text = "n";
            oKey.Text = "o";
            pKey.Text = "p";
            qKey.Text = "q";
            rKey.Text = "r";
            sKey.Text = "s";
            tKey.Text = "t";
            uKey.Text = "u";
            vKey.Text = "v";
            wKey.Text = "w";
            xKey.Text = "x";
            yKey.Text = "y";
            zKey.Text = "z";
        }

        //podoba kláves při aktivní klávese CapsLock
        private void KeysCapsOn()
        {
            KeysToUpper();
            uSKrouzkemKey.Text = "Ů";
            uSCarkouKey.Text = "Ú";
            eSHackemKey.Text = "Ě";
            sSHackemKey.Text = "Š";
            cSHackemKey.Text = "Č";
            rSHackemKey.Text = "Ř";
            zSHackemKey.Text = "Ž";
            ySCarkouKey.Text = "Ý";
            aSCarkouKey.Text = "Á";
            iSCarkouKey.Text = "Í";
            eSCarkouKey.Text = "É";
        }

        //podoba kláves při neaktivní klávese CapsLock
        private void KeysCapsOff()
        {
            KeysToLower();
            uSKrouzkemKey.Text = "ů";
            uSCarkouKey.Text = "ú";
            eSHackemKey.Text = "ě";
            sSHackemKey.Text = "š";
            cSHackemKey.Text = "č";
            rSHackemKey.Text = "ř";
            zSHackemKey.Text = "ž";
            ySCarkouKey.Text = "ý";
            aSCarkouKey.Text = "á";
            iSCarkouKey.Text = "í";
            eSCarkouKey.Text = "é";
        }

        //podoba kláves při aktivní klávese Shift
        private void KeysShiftOn()
        {
            KeysToUpper();
            backSlashKey.Text = "|";
            commaKey.Text = "?";
            dotKey.Text = ":";
            hyphenKey.Text = "_";
            uSKrouzkemKey.Text = @"""";
            paragraphKey.Text = "!";
            doubleDotKey.Text = "'";
            uSCarkouKey.Text = "/";
            zavorkyKey.Text = "(";
            semicolonKey.Text = "°";
            plusKey.Text = "1";
            eSHackemKey.Text = "2";
            sSHackemKey.Text = "3";
            cSHackemKey.Text = "4";
            rSHackemKey.Text = "5";
            zSHackemKey.Text = "6";
            ySCarkouKey.Text = "7";
            aSCarkouKey.Text = "8";
            iSCarkouKey.Text = "9";
            eSCarkouKey.Text = "0";
            rovnaSeKey.Text = "%";
            carkaNadPismenemKey.Text = "ˇ";
        }

        //podoba kláves při neaktivní klávese Shift
        private void KeysShiftOff()
        {
            KeysToLower();
            backSlashKey.Text = @"\";
            commaKey.Text = ",";
            dotKey.Text = ".";
            hyphenKey.Text = "-";
            uSKrouzkemKey.Text = "ů";
            paragraphKey.Text = "§";
            doubleDotKey.Text = "¨";
            uSCarkouKey.Text = "ú";
            zavorkyKey.Text = ")";
            semicolonKey.Text = ";";
            plusKey.Text = "+";
            eSHackemKey.Text = "ě";
            sSHackemKey.Text = "š";
            cSHackemKey.Text = "č";
            rSHackemKey.Text = "ř";
            zSHackemKey.Text = "ž";
            ySCarkouKey.Text = "ý";
            aSCarkouKey.Text = "á";
            iSCarkouKey.Text = "í";
            eSCarkouKey.Text = "é";
            rovnaSeKey.Text = "=";
            carkaNadPismenemKey.Text = "´";
        }

        //aktivuje a deaktivuje klávesu CapsLock
        private void caps_Click(object sender, EventArgs e)
        {
            if (this.CapsClicks % 2 == 0)
            {
                caps.BackColor = Color.Blue;
                KeysCapsOn();
            }
            else
            {
                caps.BackColor = Color.Transparent;
                KeysCapsOff();
            }
            this.CapsClicks++;
        }

        //aktivuje a deaktivuje klávesu Shift, zajišťuje komunikaci mezi oběma klávesami Shift
        #region shift
        private void shift1_Click(object sender, EventArgs e)
        {
            
            if (this.ShiftClicks % 2 == 0)
            {
                shift1.BackColor = Color.Blue;
                shift2.BackColor = Color.Blue;
                KeysShiftOn();
            }
            else
            {
                shift1.BackColor = Color.Transparent;
                shift2.BackColor = Color.Transparent;
                KeysShiftOff();
            }
            this.ShiftClicks++;
        }

        private void shift2_Click(object sender, EventArgs e)
        {
            if (this.ShiftClicks % 2 == 0)
            {
                shift1.BackColor = Color.Blue;
                shift2.BackColor = Color.Blue;
                KeysShiftOn();
            }
            else
            {
                shift1.BackColor = Color.Transparent;
                shift2.BackColor = Color.Transparent;
                KeysShiftOff();

            }
            this.ShiftClicks++;
        }
        #endregion

        //------------------------------------------------------
        //------------------------------------------------------
        //------------------------------------------------------

        //předává hodnotu stisknuté klávesy metodě SetMainFormTextBox, která hodnotu předává hlavnímu formuláři
        #region stisk kláves
        private void aKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(aKey.Text);    
        }

        private void bKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(bKey.Text);
        }

        private void cKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(cKey.Text);
        }

        private void dKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(dKey.Text);
        }

        private void eKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(eKey.Text);
        }

        private void fKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(fKey.Text);
        }

        private void gKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(gKey.Text);
        }

        private void hKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(hKey.Text);
        }

        private void iKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(iKey.Text);
        }

        private void jKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(jKey.Text);
        }

        private void kKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(kKey.Text);
        }

        private void lKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(lKey.Text);
        }

        private void mKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(mKey.Text);
        }

        private void nKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(nKey.Text);
        }

        private void oKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(oKey.Text);
        }

        private void pKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(pKey.Text);
        }

        private void qKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(qKey.Text);
        }

        private void rKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(rKey.Text);
        }

        private void sKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(sKey.Text);
        }

        private void tKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(tKey.Text);
        }

        private void uKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(uKey.Text);
        }

        private void vKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(vKey.Text);
        }

        private void wKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(wKey.Text);
        }

        private void xKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(xKey.Text);
        }

        private void yKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(yKey.Text);
        }

        private void zKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(zKey.Text);
        }

        //------------------------
        //------------------------

        private void aSCarkouKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(aSCarkouKey.Text);
        }

        private void eSCarkouKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(eSCarkouKey.Text);
        }

        private void iSCarkouKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(iSCarkouKey.Text);
        }

        private void uSCarkouKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(uSCarkouKey.Text);
        }

        private void ySCarkouKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(ySCarkouKey.Text);
        }

        private void eSHackemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(eSHackemKey.Text);
        }

        private void uSKrouzkemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(uSKrouzkemKey.Text);
        }

        private void cSHackemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(cSHackemKey.Text);
        }

        private void rSHackemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(rSHackemKey.Text);
        }

        private void sSHackemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(sSHackemKey.Text);
        }

        private void zSHackemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(zSHackemKey.Text);
        }


        //----------------------------
        //----------------------------
        private void semicolonKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(semicolonKey.Text);
        }

        private void plusKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(plusKey.Text);
        }

        private void rovnaSeKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(rovnaSeKey.Text);
        }

        private void carkaNadPismenemKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(carkaNadPismenemKey.Text);
        }

        private void zavorkyKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(zavorkyKey.Text);
        }

        private void doubleDotKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(doubleDotKey.Text);
        }

        private void backSlash_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(backSlashKey.Text);
        }

        private void forwardSlash_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(commaKey.Text);
        }

        private void dotKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(dotKey.Text);
        }

        private void hyphenKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(hyphenKey.Text);
        }

        private void paragraphKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(paragraphKey.Text);
        }


        //.....................
        //.....................

        private void up_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|UP|");
        }

        private void left_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|LEFT|");
        }

        private void down_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|DOWN|");
        }

        private void right_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|RIGHT|");
        }



        //.....................
        //.....................

        private void esc_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|ESC|");
        }

        private void tab_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("\t");
        } 

        private void fnKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|FN|");
        }

        private void ctrl1_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|CTRLL|");
        }

        private void winKey_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|WIN|");
        }

        private void alt1_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|ALTL|");
        }

        private void spacebar_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(" ");
        }

        private void alt2_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|ALTGR|");
        }

        private void ctrl2_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|CONTROLR|");
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|BACKSPACE|");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox(System.Environment.NewLine);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|DELETE|");
        }

        private void mystery_Click(object sender, EventArgs e)
        {
            SetMainFormTextBox("|MYSTERY|");
        }
        #endregion

    }
}
