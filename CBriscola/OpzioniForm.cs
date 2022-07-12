using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBriscola
{
    public partial class OpzioniForm : Form
    {
        private CBriscolaOpzioni opzioni;
        public OpzioniForm()
        {
            InitializeComponent();
            /*Text = strings.captionOpzioni;
            label1.Text = strings.ctlNomeUtente;
            label2.Text = strings.ctlNomeCPU;
            label3.Text = strings.ctlSecondi;
            checkBox1.Text = strings.ctlPunti;
            checkBox2.Text = strings.ctlOrdina;
            checkBox3.Text = strings.ctlAvvisa;
            checkBox4.Text = strings.ctlCartaAlta;
            checkBox5.Text = strings.ctlAggiornamenti;
            button1.Text = strings.ctlOK;
            button2.Text = strings.ctlCancel;*/
  
        }

        public void SetOpzioni(CBriscolaOpzioni o)
        {
            opzioni =  o;
            textBox1.Text=o.nomeUtente;
            textBox2.Text = o.nomeCpu;
            textBox3.Text = o.secondi.ToString();
            checkBox1.Checked = o.punti;
            checkBox2.Checked = o.ordina;
            checkBox3.Checked = o.avvisa;
            checkBox4.Checked = o.cartaAlta;
            checkBox5.Checked = o.upgrades;
        }

        public CBriscolaOpzioni GetOpzioni() {
            return opzioni;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                opzioni.secondi = Int16.Parse(textBox3.Text);
            }
            catch (System.FormatException e1)
            {
             //   MessageBox.Show(strings.msgErrConversione, strings.captionErrore, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            opzioni.nomeUtente = textBox1.Text;
            opzioni.nomeCpu = textBox2.Text;
            opzioni.punti = checkBox1.Checked;
            opzioni.ordina = checkBox2.Checked;
            opzioni.avvisa = checkBox3.Checked;
            opzioni.cartaAlta = checkBox4.Checked;
            opzioni.upgrades = checkBox5.Checked;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
