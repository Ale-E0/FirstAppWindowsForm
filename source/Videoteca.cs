using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ColleoniWWF
{
    public class Videoteca
    {
        public bool create(List<SerieTV> series)
        {
            File.WriteAllText(Main.Path, "[]\n[]");
            series.Clear();

            return true;
        }

        public void LoadDB(List<SerieTV> series)
        {
            
            try
            {
                StreamReader sr = new StreamReader(Main.Path);
                string text = sr.ReadLine();
                foreach (var serieTv in (text != null ? JsonSerializer.Deserialize<List<SerieTV>>(text) : new List<SerieTV>()))
                {
                    series.Add(serieTv);
                }

                string text2 = sr.ReadLine();
                foreach (var serieTv in (text2 != null ? JsonSerializer.Deserialize<List<SerieTvInteractive>>(text2) : new List<SerieTvInteractive>()))
                {
                    Main.seriesInteractives.Add(serieTv);
                }
                
                sr.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File non trovato!", "Errore");
            }
        }
    }
}
