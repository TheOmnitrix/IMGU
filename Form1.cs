using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMGU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String imageLocation = "descarga.png";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Archivos jpg(*.jpg)|*.jpg| Archivos png(*.png)|*.png| Todos los Archivos(*.*)|*.*";

                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox1.ImageLocation = imageLocation;
                
                }
            }
          catch (Exception){
                MessageBox.Show("Ah ocurrido un Error Intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
