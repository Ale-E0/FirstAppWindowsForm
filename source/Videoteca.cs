using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColleoniWWF
{
    public class Videoteca
    {
        public bool create()
        {
            string text = "Titolo;N°Stagioni;N°Episodi;Genere;Paese;Anno_Pub";
            File.WriteAllText(Main.Path, text);
            return true;
        }

        public void LoadDB(List<SerieTV> series)
        {
            try
            {
                string[] lines = File.ReadAllLines(Main.Path);
                lines = lines.Skip(1).ToArray();
                foreach (string line in lines)
                {
                    string[] columns = line.Split(';');
                    series.Add(new SerieTV()
                    {
                        Titolo = columns[0],
                        Stagioni = Convert.ToInt32(columns[1]),
                        Episodi = Convert.ToInt32(columns[2]),
                        Genere = columns[3],
                        Paese = columns[4],
                        Anno = columns[5],
                    });
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File non trovato!", "Errore");
            }
           
        }
    }
}
