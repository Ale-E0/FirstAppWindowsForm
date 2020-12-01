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
            label1.Text = serieTV[numero].ToString();
            prevButton.Hide();
            foreach (SerieTV serie in serieTV)
                listBox.Items.Add(serie.Titolo);
            labelList.Text = "";

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (numero != serieTV.Count - 1)
            {
                numero++;
                label1.Text = serieTV[numero].ToString();
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
                label1.Text = serieTV[numero].ToString();
                nextButton.Show();
            }

            if (numero == 0)
                prevButton.Hide();
        }

        private void Read_Load(object sender, EventArgs e)
        {

        }

        private void Read_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();        
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelList.Text = serieTV[listBox.SelectedIndex].ToString();
        }
    }
}
