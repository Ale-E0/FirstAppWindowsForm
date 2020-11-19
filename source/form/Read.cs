using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Read : Form
    {

        private List<SerieTV> serieTV;
        private static int numero;

        public Read(List<SerieTV> serieTV)
        {
            this.serieTV = serieTV;
            InitializeComponent();
            numero = 0;
            label1.Text = serieTV[numero].Visualizza();
            prevButton.Hide();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (numero != serieTV.Count - 1)
            {
                numero++;
                label1.Text = serieTV[numero].Visualizza();
                prevButton.Show();
            }

            if (numero == serieTV.Count - 1)
                nextButton.Hide();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (numero != 0)
            {
                numero--;
                label1.Text = serieTV[numero].Visualizza();
                nextButton.Show();
            }

            if (numero == 0)
                prevButton.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
            Main m = new Main();
            m.Show();
        }

        private void Read_Load(object sender, EventArgs e)
        {

        }
    }
}
