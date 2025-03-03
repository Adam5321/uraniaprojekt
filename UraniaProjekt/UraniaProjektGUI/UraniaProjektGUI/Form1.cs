using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using roziamoziba;

namespace UraniaProjektGUI
{
    public partial class Form1 : Form
    {
        readonly Mozi m = new Mozi();
        List<Film> filmek = Filmfajlkezelo.BeolvasFilmeket("movies.txt");
        public Form1()
        {
            InitializeComponent();
            DefaultSettings();
        }
        void DefaultSettings()
        {
            m.feladat();
            m.musorlista.musorKiir();
            CategoryFill();
            DaysFill();

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            listBox2.SelectedIndex = listBox2.Items.Count - 1;
        }
        void CategoryFill()
        {
            List<string> s = new List<string>();
            foreach (Vetites v in m.musorlista.vetitesek)
            {
                if (!s.Contains(v.Film.Kategoria)) s.Add(v.Film.Kategoria);
            }
            s.ForEach(x => listBox1.Items.Add(x));
            listBox1.Items.Add("Bármelyik");
        }

        void DaysFill()
        {
            List<string> s = new List<string>();
            foreach (Vetites v in m.musorlista.vetitesek)
            {
                if(!s.Contains($"{v.Idopont.Month}. {v.Idopont.Day}.")) s.Add($"{v.Idopont.Month}. {v.Idopont.Day}.");
            }
            s.ForEach(x => listBox2.Items.Add(x));
            listBox2.Items.Add("Bármelyik");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            List<Film> kozosfilmek = new List<Film>();

            object o = listBox1.Items[listBox1.SelectedIndex];
            object o2 = listBox2.Items[listBox2.SelectedIndex];

            List<Film> katszurt = new List<Film>();
            List<Film> vetszurt = new List<Film>();

            katszurt = m.katSzures(o.ToString());
            vetszurt = m.vetSzures(o2.ToString());

            for(int i = 0; i < vetszurt.Count; i++)
            {
                if (katszurt.Contains(vetszurt[i]))
                {
                    kozosfilmek.Add(vetszurt[i]);
                }
            }

            kozosfilmek.ForEach(x => listBox3.Items.Add(x));
        }
    }
}
