using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
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
            serieTV.Clear();
            StreamWriter sr = new StreamWriter(Main.Path);

            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellCollection cells = dataGridView1.Rows[i].Cells;
                SerieTV tv = new SerieTV();
                tv.Titolo = cells[0].Value.ToString();
                tv.Stagioni = Convert.ToInt32(cells[1].Value);
                tv.Episodi = Convert.ToInt32(cells[2].Value);
                tv.Genere = cells[3].Value.ToString();
                tv.Paese = cells[4].Value.ToString();
                tv.Anno = cells[5].Value.ToString();

                serieTV.Add(tv);
            }
            
            sr.Write(JsonSerializer.Serialize(serieTV));
            sr.Close();
            
            
            MessageBox.Show("File Salvato!", "ColleoniWWF");
        }
        
    }
}
