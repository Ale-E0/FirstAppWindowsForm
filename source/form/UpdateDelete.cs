using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Update : Form
    {
        private List<SerieTV> serieTV;
        private bool changed;
        public Update(List<SerieTV> serieTV)
        {
            this.serieTV = serieTV;
            InitializeComponent();


            dataGridView1.Columns.Add("Titolo", "Titolo");
            dataGridView1.Columns.Add("Stagioni", "Stagioni");
            dataGridView1.Columns.Add("Episodi", "Episodi");
            dataGridView1.Columns.Add("Genere", "Genere");
            dataGridView1.Columns.Add("Paese", "Paese");
            dataGridView1.Columns.Add("Anno", "Anno");
            changed = false;
            foreach (SerieTV serie in this.serieTV)
                dataGridView1.Rows.Add(serie.Titolo, serie.Stagioni, serie.Episodi, serie.Genere, serie.Paese, serie.Anno);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
        }

        private void Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changed)
            {
                if (MessageBox.Show("Vuoi salvare?\nNon hai premuto salva, le modifiche non verranno effettuate",
                    "ColleoniWWF", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    save();
                }
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed = true;
        }

        private void save()
        {
            if (changed)
            {
                changed = false;
            }
            StreamWriter sr = new StreamWriter(Main.Path);

            sr.WriteLine("Titolo;N°Stagioni;N°Episodi;Genere;Paese;Anno_Pub");

            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellCollection cells = dataGridView1.Rows[i].Cells;
                sr.WriteLine(cells[0].Value + ";" + cells[1].Value + ";" + cells[2].Value + ";" + cells[3].Value + ";" + cells[4].Value + ";" + cells[5].Value);
            }

            sr.Close();
            MessageBox.Show("File Salvato!");
        }
        
    }
}
