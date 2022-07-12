namespace CBriscola
{
    public partial class Form1 : Form
    {
        Giocatore utente, cpu, primo, secondo, temp;
        CBriscolaOpzioni opzioni;
        System.Drawing.SolidBrush b;
        System.Drawing.Size cu, cc;
        Mazzo m;
        Carta c, c1;
        ElaboratoreCarteBriscola ecb;
        CartaHelperBriscola br;
        Image img;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            primo.AggiornaPunteggio(secondo);
            try
            {
                primo.AddCarta(m);
                secondo.AddCarta(m);
            } catch (System.NullReferenceException e1)
            {
             /*   string s;
                int val = utente.GetPunteggio() - cpu.GetPunteggio();
                if (val == 0)
                    s = strings.msgPartitaPatta;
                else
                {
                    if (val > 0)
                        s = strings.msgVinto;
                    else
                        s = strings.msgPerso;
                    s = strings.msgHai + s + strings.msgPer + Math.Abs(val) + strings.msgPunti;
                }
                MessageBox.Show(this, s, strings.captionFinePartita, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
                return;*/
            }
            if (primo == cpu)
                cpu.Gioca(0);
            Refresh();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = false;

            fd.Font = opzioni.font;

            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                fd.Font = opzioni.font;            
                Refresh();
            }
        }

        private void testoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = opzioni.coloreTesto;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                //ForeColor = MyDialog.Color;
                b.Dispose();
                opzioni.coloreTesto = MyDialog.Color;
                b = new System.Drawing.SolidBrush(opzioni.coloreTesto);
                Refresh();
            }
        }

        private void sfondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = opzioni.coloreSfondo;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                opzioni.coloreSfondo = MyDialog.Color;
                BackColor = opzioni.coloreSfondo;
                Refresh();
            }
        }

        private void informazioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo f = new FormInfo();
            f.ShowDialog();
        }

        private void opzioniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpzioniForm f = new OpzioniForm();
            f.SetOpzioni(opzioni);
            f.ShowDialog();
            opzioni = f.GetOpzioni();
            f.Dispose();
            //utente.SetNome(opzioni.nomeUtente);
            //cpu.SetNome(opzioni.nomeCpu);
            timer1.Interval = opzioni.secondi * 1000;
            Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            KeyPress += new KeyPressEventHandler(OnKeyPressed);
           /* fileToolStripMenuItem.Text = strings.MenuFile;
            nuovaPartitaToolStripMenuItem.Text = strings.MenuNuovaPartita;
            opzioniToolStripMenuItem.Text = strings.MenuOpzioni;
            fontToolStripMenuItem.Text = strings.MenuFont;
            esciToolStripMenuItem.Text = strings.MenuEsci;
            coloriToolStripMenuItem.Text = strings.MenuColori;
            testoToolStripMenuItem.Text = strings.MenuTesto;
            sfondoToolStripMenuItem.Text = strings.MenuSfondo;
            toolStripMenuItem1.Text = strings.MenuAbout;
            controllaAggiornamentiToolStripMenuItem.Text =strings.MenuAggiornamenti;
            informazioniToolStripMenuItem.Text = strings.MenuInfo;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opzioni = new CBriscolaOpzioni();
            ecb = new ElaboratoreCarteBriscola(true);
            // GiocatoreHelper motoreCpu = null;
            br = new CartaHelperBriscola(ecb);
            Carta.Inizializza(40, br, "Napoletane");
            //Carta.CaricaImmagini("Napoletano");

            m = new Mazzo(ecb);

            GiocatoreHelper motoreCpu = new GiocatoreHelperCpu(ecb.GetCartaBriscola());
            utente = new Giocatore(new GiocatoreHelperUtente(), "Giulio", true, 3);
            cpu = new Giocatore(motoreCpu, "Computer", true, 3);
            ResetOpzioni();
            primo = utente;
            secondo = cpu;
            temp = null;
            Carta c = null, c1 = null;
            int i;
            for (i = 0; i < 3; i++)
            {
                primo.AddCarta(m);
                secondo.AddCarta(m);
            }
            opzioni.font = new System.Drawing.Font("Arial", 16);
            b = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            CaricaImmagine();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           // String s = strings.msgNelMazzoRimangono + m.GetNumeroCarteStr() + strings.msgCarte;
            base.OnPaint(e);
            Graphics g = this.CreateGraphics();

            /*cu=utente.Paint(g, opzioni.font, b);
            cc=cpu.Paint(g, opzioni.font, b);
            g.DrawString(strings.msgSemeBriscola+br.GetSemeStr(ecb.GetCartaBriscola()), opzioni.font, b, cu.Width, cu.Height * 3-40);
            g.DrawString(s, opzioni.font, b, cu.Width, cu.Height*4-60);
            System.Drawing.Size d = TextRenderer.MeasureText(s, opzioni.font);*/
            if (m.GetNumeroCarte() > 2)
            {
//                g.DrawImage(Carta.GetImmagine(ecb.GetCartaBriscola()), cu.Width + d.Width / 4, cu.Height * 5, Carta.GetImmagine(ecb.GetCartaBriscola()).Width, Carta.GetImmagine(ecb.GetCartaBriscola()).Height);
               // g.DrawImage(img, cu.Width + d.Width /4- img.Height/2, cu.Height * 5+img.Width-img.Height, img.Width, img.Height);
            }
            g.Dispose();
        }

        private void OnKeyPressed(Object o, KeyPressEventArgs e)
        {
            if (utente.HasCartaGiocata())
                return;
            switch (e.KeyChar)
            {
                case (char)Keys.D1: Gioca(0); break;
                case (char)Keys.D2: Gioca(1); break;
                case (char)Keys.D3: Gioca(2); break;
            }
        }

        private void Gioca(int quale)
        {
            Boolean continua = true;
            try
            {
                utente.Gioca(quale);
            }
            catch (System.IndexOutOfRangeException e)
            {
                continua = false;
            }
            if (continua)
            {
                if (!cpu.HasCartaGiocata())
                    cpu.Gioca(utente, 0);
                Refresh();
                c = primo.GetCartaGiocata();
                c1 = secondo.GetCartaGiocata();
                if ((primo.StessoSemeCartaGiocata(secondo) && br.Compara(c.GetNumero(), c1.GetNumero()) == CartaHelper.RISULTATI_COMPARAZIONE.MAGGIORE_LA_SECONDA) || (secondo.StessoSeme(Carta.GetCarta(ecb.GetCartaBriscola())) && !primo.StessoSeme(Carta.GetCarta(ecb.GetCartaBriscola()))))
                {
                    temp = primo;
                    primo = secondo;
                    secondo = temp;
                }

                timer1.Start();
            }
        }

        public void CaricaImmagine()
        {
            img=Image.FromFile(Carta.GetPathCarte() + "retro carte mazzo.jpg");
        }


        private void ResetOpzioni()
        {
            opzioni.nomeUtente = utente.GetNome();
            opzioni.nomeCpu = cpu.GetNome();
            opzioni.secondi = 1;
            opzioni.punti = true;
            opzioni.ordina = true;
            opzioni.avvisa = true;
            opzioni.cartaAlta = true;
            opzioni.upgrades = false;
            opzioni.versione = 0.1f;
        }
	}
}
