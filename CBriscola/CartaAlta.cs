using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBriscola
{
    public partial class CartaAlta : Form
    {
        public CartaAlta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carta=0;
            Boolean continua=true;
            String errore="";
            try
            {
                carta = Int16.Parse(textBox1.Text);
            } catch (System.FormatException e1)
            {
                continua = false;
                errore = "Il valore inserito non è intero";
            }
            if (continua)
            {
                continua = carta > 0 && carta < 41;
                if (continua)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    textBox1.Visible = false;
                } else
                {
                    if (errore == "")
                        errore = "Il valore inserito non è un numero tra 1 e 40";
                }
            }
            if (!continua)
                MessageBox.Show(errore, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
