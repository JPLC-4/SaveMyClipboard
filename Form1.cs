using System;

using System.IO;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMyClipboard
{
    public partial class Programme : Form
    {
        public Programme()
        {
            InitializeComponent();
        }
        public string TexteDuPressePapier = string.Empty;
        string Fichier = Path.GetTempPath() + "//" + "SaveMyClipboard" + ".txt";
        string Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");


        private void EcrireTexteduPressepapier()
        {
            if (Checkbox.Checked == true)
            {
                while (true)
                {
                    Task.Delay(3000);
                    string Texte = Clipboard.GetText();
                    
                    if (Texte != TexteDuPressePapier)
                    {
                        if (Texte != string.Empty)
                        {
                            File.AppendAllText(Fichier, Date + Environment.NewLine + Texte + Environment.NewLine);
                            TexteDuPressePapier = Texte;
                        }
                        
                    }
                    
                   
                }
            }

            else
            {
                label.Text = "Mode Automatique Desactivé";
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EcrireTexteduPressepapier();
           
        }
    }
}
