using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Update : Form
    {
        #region Declaration
        
        private List<SerieTV> serieTV;
        private bool changed;
        
        #endregion

        #region Initialize
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
            dataGridView1.Columns.Add("Interattiva", "Interattiva");
            changed = false;
            foreach (SerieTV serie in this.serieTV)
                dataGridView1.Rows.Add(serie.Titolo, serie.Stagioni, serie.Episodi, serie.Genere, serie.Paese, serie.Anno, serie.isInteractive);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion
        
        #region Close Form
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
        
        #endregion
        
        #region DataGrid 
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changed = true;
        }
        
        #endregion
        
        #region Save task
        private void saveButton_Click(object sender, EventArgs e)
        {
            save();
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
                SerieTV tv = new SerieTV(
                    cells[0].Value.ToString(),
                    Convert.ToInt32(cells[1].Value),
                    Convert.ToInt32(cells[2].Value),
                    cells[3].Value.ToString(),
                    cells[4].Value.ToString(),
                    cells[5].Value.ToString(),
                        Convert.ToBoolean(cells[6].Value)
                    );
                serieTV.Add(tv);
            }
            
            sr.WriteLine(JsonSerializer.Serialize(serieTV));
            sr.WriteLine(JsonSerializer.Serialize<List<SerieTvInteractive>>(Main.seriesInteractives));
            sr.Close();
            
            MessageBox.Show("File Salvato!", "ColleoniWWF");
        }
        #endregion
    }
}
