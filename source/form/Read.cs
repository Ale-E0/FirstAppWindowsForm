using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Read : Form
    {

        private List<SerieTV> _serieTV;
        private static int numero;

        public Read(List<SerieTV> serieTV)
        {

            _serieTV = new List<SerieTV>().Concat(serieTV).Concat(Main.seriesInteractives).ToList();
            
            InitializeComponent();
            
            numero = 0;
            label1.Text = serieTV[numero].ToString();
            prevButton.Hide();
            
            if(_serieTV.Count == 1)
                nextButton.Hide();

            foreach (SerieTV serie in _serieTV)
                listBox.Items.Add(serie.Titolo);

            labelList.Text = "";

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (numero != _serieTV.Count - 1)
            {
                numero++;
                label1.Text = _serieTV[numero].ToString();
                prevButton.Show();
            }

            if (numero == _serieTV.Count - 1)
                nextButton.Hide();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (numero != 0)
            {
                numero--;
                label1.Text = _serieTV[numero].ToString();
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
            labelList.Text = _serieTV[listBox.SelectedIndex].ToString();
        }
    }
}
