using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows;

namespace LEDAplikacja
{
    public partial class Form1 : Form
    {
        public class DaneDoPrzeslania
        {
            public int[] parametry = new int[7];
            public string tekst;
            public string czas;

        }

        string zbierzTresc()
        {
            string tresc = textBox.Text;
            return tresc;
        }

        string zbierzCzas()
        {
            string time = czasBox.Text;
            return time;
        }
        int[] zbierzParametry(){
                int vAnim = Convert.ToInt32(vAnimWej.Text);
                int brightness = Convert.ToInt32(jasnoscAnim.Text);
                int vAnimOut = Convert.ToInt32(vAnimWyj.Text);

                int effWej = 1;
                switch (effAnimWej.Text){
                    case "Kursor":
                        effWej = 1;
                        break;
                    case "Linia":
                        effWej = 2;
                        break;
                    case "Pojawianie":
                        effWej = 3;
                        break;
                }
                int effWyj = 1;
                switch (effAnimWyj.Text){
                    case "Kursor prawo":
                        effWyj = 1;
                        break;
                    case "Kursor lewo":
                        effWyj = 2;
                        break;
                    case "Zanikanie":
                        effWyj = 3;
                        break;
                }
                int colour = 0;
                switch (kolorAnim.Text){
                    case "Czerwony":
                        colour = 2;
                        break;
                    case "Zielony":
                        colour = 1;
                        break;
                }
                int negatyw = 0;
                switch (invert.Text){
                    case "Tak":
                        negatyw = 2;
                        break;
                    case "Nie":
                        negatyw = 1;
                        break;
                }
                string time = czasBox.Text;

                int[] Parametry = new int[7]; // tablica z parametrami animacji

                Parametry[0] = effWej;
                Parametry[1] = vAnim;
                Parametry[2] = brightness;
                Parametry[3] = colour;
                Parametry[4] = effWyj;
                Parametry[5] = vAnimOut;
                Parametry[6] = negatyw;

                return Parametry;

   
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {

            WriteFile();

        }
        void dane() {

        }
        void WriteFile()
        {
            try
            {
                DaneDoPrzeslania Dane = new DaneDoPrzeslania();
                Dane.parametry = zbierzParametry();
                Dane.tekst = zbierzTresc();
                Dane.czas = zbierzCzas();

            }
            catch
            {
                MessageBox.Show("Zły format wprowadzonych danych", "BŁĄD", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto etykieta;
            } 
            try
            {
                string dysksd = dysk.Text;
                String sFilename = "dane.txt";
                DaneDoPrzeslania Dane = new DaneDoPrzeslania();
                Dane.parametry = zbierzParametry();
                Dane.tekst = zbierzTresc();
                Dane.czas = zbierzCzas();
                StreamWriter myFile = new StreamWriter(dysksd+":/" + sFilename);

                myFile.Write(Dane.tekst + "|");
                for (int i = 0; i <= 6; i++)
                {
                    myFile.Write(Dane.parametry[i]+"|");
                }
                myFile.WriteLine(Dane.czas ); 
                myFile.Close();

                File.SetAttributes(dysksd + ":/" + sFilename, FileAttributes.Normal);

                MessageBox.Show("Animacja zapisana pomyślnie", "Zapisano", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {   
                MessageBox.Show("Nie odnaleziono karty SD", "BŁĄD", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        etykieta:
            int v = 0;
        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.CharacterCasing = CharacterCasing.Upper;
        }

        private void buttonWyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zapiszAnimacjeToolStrip_Click(object sender, EventArgs e)
        {

                SaveFileDialog sfd = new SaveFileDialog();
                
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        string path = sfd.FileName;
                        StreamWriter sw = new StreamWriter(File.Create(path));

                        DaneDoPrzeslania Dane = new DaneDoPrzeslania();
                        Dane.parametry = zbierzParametry();
                        Dane.tekst = zbierzTresc();
                        Dane.czas = zbierzCzas();

                        sw.Write(Dane.tekst + "|");
                        for (int i = 0; i <= 6; i++)
                        {
                            sw.Write(Dane.parametry[i] + "|");
                        }
                        sw.WriteLine(Dane.czas);
                        
                        sw.Close();
                        File.SetAttributes(path, FileAttributes.Normal);


                        MessageBox.Show("Animacja zapisana pomyślnie", "Zapisano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się zapisać animacji", "Błąd zapisu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
              }
        }

        private void wczytajAnimacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {

                OpenFileDialog ofd = new OpenFileDialog();

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        string path = ofd.FileName;
                        System.IO.StreamReader sr = new
                        System.IO.StreamReader(ofd.FileName);

                        string tekst_in = sr.ReadToEnd();
                        
                        int commaIndex = tekst_in.IndexOf('|');
                        int secondCommaIndex = tekst_in.IndexOf('|', commaIndex + 1);
                        int thirdCommaIndex = tekst_in.IndexOf('|', secondCommaIndex + 1);
                        int fourCommaIndex = tekst_in.IndexOf('|', thirdCommaIndex + 1);
                        int fiveCommaIndex = tekst_in.IndexOf('|', fourCommaIndex + 1);
                        int sixCommaIndex = tekst_in.IndexOf('|', fiveCommaIndex + 1);
                        int sevenCommaIndex = tekst_in.IndexOf('|', sixCommaIndex + 1);
                        int eightCommaIndex = tekst_in.IndexOf('|', sevenCommaIndex + 1);

                        String firstValue = tekst_in.Substring(0, commaIndex);
                        String secondValue = tekst_in.Substring(commaIndex + 1, 1);
                        String thirdValue = tekst_in.Substring(secondCommaIndex + 1, 1);
                        String fourValue = tekst_in.Substring(thirdCommaIndex + 1, 2);
                        String fiveValue = tekst_in.Substring(fourCommaIndex + 1, 1);
                        String sixValue = tekst_in.Substring(fiveCommaIndex + 1, 1);
                        String sevenValue = tekst_in.Substring(sixCommaIndex + 1, 1);
                        String eightValue = tekst_in.Substring(sevenCommaIndex + 1, 1);
                        String nineValue = tekst_in.Substring(eightCommaIndex + 1);

                        textBox.Text = firstValue;
                        if (secondValue == "1")
                        {
                            effAnimWej.Text = "Kursor";
                        }
                        else if (secondValue == "2")
                        {
                            effAnimWej.Text = "Linia";
                        }
                        else
                        {
                            effAnimWej.Text = "Pojawianie";
                        }

                        vAnimWej.Text = thirdValue;
                        jasnoscAnim.Text = fourValue;
                        kolorAnim.Text = fiveValue;

                        if (fiveValue == "1")
                        {
                            kolorAnim.Text = "Zielony";
                        }
                        else 
                        {
                            kolorAnim.Text = "Czerwony";
                        }

                        if (sixValue == "1")
                        {
                            effAnimWyj.Text = "Kursor prawo";
                        }
                        else if (sixValue == "2")
                        {
                            effAnimWyj.Text = "Kursor lewo";
                        }
                        else
                        {
                            effAnimWyj.Text = "Zanikanie";
                        }
                        vAnimWyj.Text = sevenValue;
                        
                        if (eightValue == "1")
                        {
                            invert.Text = "Nie";
                        }
                        else
                        {
                            invert.Text = "Tak";
                        }

                        czasBox.Text = nineValue;
                        MessageBox.Show("Animacja wczytana pomyślnie", "Wczytano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        sr.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Nie udało się wczytać animacji", "Błąd wczytania", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }     
    }
}
 