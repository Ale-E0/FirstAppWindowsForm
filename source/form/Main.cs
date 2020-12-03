using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Main : Form
    {
        #region Declaration
        
        private List<SerieTV> series = new List<SerieTV>();
        public static List<SerieTvInteractive> seriesInteractives = new List<SerieTvInteractive>();
        private Videoteca v = new Videoteca();
        private bool created;
        public const string Path = "videoteca.json";
        #endregion
        
        #region Initialize
        public Main()
        {
            InitializeComponent();
            v.LoadDB(series);
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Click Create
        private void create_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Sicuro di voler creare un nuovo archivio?", "Create", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                created = v.create(series);
                if (created)
                {
                    MessageBox.Show("Archivio creato con successo", "ColleoniWWF");
                }
                else
                {
                    MessageBox.Show("Qualcosa è andato storto", "ColleoniWWF");
                }
            }
        }
        #endregion

        #region Click Read
        private void read_Click(object sender, EventArgs e)
        {
            if (series.Count == 0)
                MessageBox.Show("Archivio vuoto o non trovato!", "ColleoniWWF");
            else
            {
                Read r = new Read(series);
                r.Show();
                Hide();
            }
        }
        #endregion

        #region Click Update
        private void update_Click(object sender, EventArgs e)
        {
            Update u = new Update(series);
            u.Show();
            Hide();
        }
        #endregion

        #region Click Delete
        private void delete_Click(object sender, EventArgs e)
        {
            Update d = new Update(series);
            d.Show();
            Hide();
        }
        #endregion
        
        #region Click Add
        private void addButton_Click(object sender, EventArgs e)
        {
            Add a = new Add(series);
            a.Show();
            Hide();
        }
        #endregion
        
        #region Click Exit
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        
    }
}