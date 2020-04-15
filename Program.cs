using System;
using System.Windows.Forms;
using System.Drawing.dll;


namespace Telas
{

        static class Program
        {
            [STAThread]

            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefaut(false);
                Application.Run(new Formulario());
            }
        }
    public class Formulario :Form{
        
        Label labelNome;
        Label labelDTNacimento;
        Label labelCPF;
        LAbel labelDiasDev;
        textBox txtNome;

        public Formulario(){
            int x = 20;
            int y = 20;
            label = new Label();
            label.Text = " Nome";
        
        }
    }
}
