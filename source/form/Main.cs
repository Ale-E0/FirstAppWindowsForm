﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public partial class Main : Form
    {
        private List<SerieTV> series = new List<SerieTV>();
        private Videoteca v = new Videoteca();
        public Main()
        {
            InitializeComponent();
            v.LoadDB(series); 
        }

        private bool created;
        public const string Path = "videoteca.csv";

        private void create_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Sicuro di voler creare un nuovo archivio?", "Create", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                created = v.create();
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

        private void read_Click(object sender, EventArgs e)
        {
            if (series.Count == 0)
                MessageBox.Show("Archivio vuoto o non trovato!", "ColleoniWWF");

            Hide();
            Read r = new Read(series);
            r.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Hide();
            Update u = new Update(series);
            u.Show();
        }
        
        private void delete_Click(object sender, EventArgs e)
        {
            Hide();
            Update d = new Update(series);
            d.Show();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Hide();
            Add a = new Add();
            a.Show();
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}