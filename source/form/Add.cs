using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Add : Form
    {
        private List<SerieTV> series;
        bool _isInteractive;
        public Add(List<SerieTV> series)
        {
            this.series = new List<SerieTV>().Concat(series).Concat(Main.seriesInteractives).ToList();
            InitializeComponent();
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                _isInteractive = true;
            SerieTV s = new SerieTV()
            {
                Titolo = boxTitolo.Text,
                Stagioni = Convert.ToInt32(boxStagioni.Text),
                Episodi = Convert.ToInt32(boxEpisodi.Text),
                Genere = boxGenere.Text,
                Paese = boxPaese.Text,
                Anno = boxAnno.Text,
                isInteractive = _isInteractive
            };
            labelConfirm.Text = s.ToString();
            DialogResult dr = MessageBox.Show("Vuoi inserirla?", "ColleoniWWF", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                series.Add(s);
                StreamWriter sw = new StreamWriter(Main.Path);
                sw.WriteLine(JsonSerializer.Serialize(series));
                sw.WriteLine(JsonSerializer.Serialize(Main.seriesInteractives));

                sw.Close();
                labelLast.Text = labelConfirm.Text;
                labelConfirm.Text = "...";
                boxTitolo.Clear();
                boxStagioni.Clear();
                boxEpisodi.Clear();
                boxGenere.Clear();
                boxPaese.Clear();
                boxAnno.Clear();
                checkBox1.Checked = false;
            }
        }

        private void Add_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }
    }
}