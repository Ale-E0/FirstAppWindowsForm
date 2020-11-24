﻿using System;
using System.IO;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            SerieTV s = new SerieTV
            {
                Titolo = boxTitolo.Text,
                Stagioni = Convert.ToInt32(boxStagioni.Text),
                Episodi = Convert.ToInt32(boxEpisodi.Text),
                Genere = boxGenere.Text,
                Paese = boxPaese.Text,
                Anno = boxAnno.Text
            };
            labelConfirm.Text = s.ToString();

            string line = s.Titolo + ";" +
                          s.Stagioni + ";" +
                          s.Episodi + ";" +
                          s.Genere + ";" +
                          s.Paese + ";" +
                          s.Anno;

            DialogResult dr = MessageBox.Show("Vuoi inserirla?", "ColleoniWWF", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                using (StreamWriter file = File.AppendText(Main.Path))
                {
                    file.WriteLine(line);
                }
            }
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}