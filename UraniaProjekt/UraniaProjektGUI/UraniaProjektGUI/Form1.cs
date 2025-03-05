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
using System.IO;

namespace UraniaProjektGUI
{
    public partial class Form1 : Form
    {
        readonly Mozi m = new Mozi();
        public int vetin = 0;
        List<Vetites> actVetites = new List<Vetites>();
        List<Film> kozosfilmek = new List<Film>();
        List<Film> vetitesek = new List<Film>();
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
            DaysFill(daysListbox);
            DaysFill(datesListbox);

            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false; 
            
            dgv.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;

            dgv.MultiSelect = false;
            foglalasbtn.Enabled = false;
            nyomtbtn.Enabled = false;

            katListbox.SelectedIndex = katListbox.Items.Count - 1;
            daysListbox.SelectedIndex = daysListbox.Items.Count - 1;

            dgv.ColumnHeadersVisible = false;
            dgv.RowHeadersVisible = false;
        }
        void VetitesFill()
        {
            vetitesListbox.Items.Clear();
            vetitesek.Clear();

            object o = datesListbox.Items[datesListbox.SelectedIndex];

            List<Vetites> vetszurt2 = new List<Vetites>();

            vetszurt2 = m.vetSzures2(o.ToString());

            actVetites = vetszurt2;
            vetszurt2.ForEach(x => vetitesListbox.Items.Add(x.Film.Nev+", "+x.Idopont.Hour+":"+Convert.ToString(x.Idopont.Minute).PadLeft(2,'0')+", "+x.Terem.Nev));
        }
        void CategoryFill()
        {
            List<string> s = new List<string>();
            foreach (Vetites v in m.musorlista.vetitesek)
            {
                if (!s.Contains(v.Film.Kategoria)) s.Add(v.Film.Kategoria);
            }
            s.ForEach(x => katListbox.Items.Add(x));
            katListbox.Items.Add("Bármelyik");
        }

        void DaysFill(ListBox lbox)
        {
            List<string> s = new List<string>();
            foreach (Vetites v in m.musorlista.vetitesek)
            {
                if(!s.Contains($"{v.Idopont.Month}. {v.Idopont.Day}.")) s.Add($"{v.Idopont.Month}. {v.Idopont.Day}.");
            }
            s.ForEach(x => lbox.Items.Add(x));
            if(lbox == daysListbox)
            {
                lbox.Items.Add("Bármelyik");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moviesListbox.Items.Clear();
            kozosfilmek.Clear();

            object o = katListbox.Items[katListbox.SelectedIndex];
            object o2 = daysListbox.Items[daysListbox.SelectedIndex];

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

            kozosfilmek.ForEach(x => moviesListbox.Items.Add(x.Nev));
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = kozosfilmek[moviesListbox.SelectedIndex].Nev +
                " (" + kozosfilmek[moviesListbox.SelectedIndex].Ev +
                "), Kategória: " + kozosfilmek[moviesListbox.SelectedIndex].Kategoria +
                ", Hossz: " + kozosfilmek[moviesListbox.SelectedIndex].Ido + " perc.";
            label3.Text = "Leírás: " + kozosfilmek[moviesListbox.SelectedIndex].Leiras;
        }

        private void datesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            VetitesFill();
        }

        private void vetitesListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foglalasbtn.Enabled = true;
            dgv.ScrollBars = ScrollBars.None;
            dgv.Columns.Clear();
            dgv.Rows.Clear();
            vetin = vetitesListbox.SelectedIndex;

            dgv.RowTemplate.Height = dgv.Height / actVetites[vetin].Terem.Ferohely.GetLength(1);


            for (int i = 0; i < actVetites[vetin].Terem.Ferohely.GetLength(0); i++)
            {
                dgv.Columns.Add("col","Oszlop");
            }
            for (int j = 0; j < actVetites[vetin].Terem.Ferohely.GetLength(1)-1; j++)
            {
                dgv.Rows.Add();
            }
            DgvFelt();
            foreach (DataGridViewColumn cell in dgv.Columns)
            {
                cell.Width = dgv.Width / actVetites[vetin].Terem.Ferohely.GetLength(0);
            }
        }
        private void DgvFelt()
        {
            for (int i = 0; i < actVetites[vetin].Terem.Ferohely.GetLength(0); i++)
            {
                for (int j = 0; j < actVetites[vetin].Terem.Ferohely.GetLength(1); j++)
                {
                    dgv.Rows[i].Cells[j].Value = actVetites[vetin].Terem.Ferohely[i, j];
                    if (dgv.Rows[i].Cells[j].Value.ToString() == "1")
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Red;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Green;
                        dgv.Rows[i].Cells[j].Style.ForeColor = Color.Green;
                    }
                }
            }
        }

        private void foglalasbtn_Click(object sender, EventArgs e)
        {
            int y = dgv.CurrentCell.ColumnIndex;
            int x = dgv.CurrentCell.RowIndex;
            
            if (actVetites[vetin].Terem.Ferohely[x,y] == 0)
            {
                nyomtbtn.Enabled = true;
                actVetites[vetin].Terem.Ferohely[x, y] = 1;
            }
            DgvFelt();
        }
        private void Jegy()
        {
            int y = dgv.CurrentCell.ColumnIndex;
            int x = dgv.CurrentCell.RowIndex;

            string sor1 = "Cím: " + actVetites[vetin].Film.Nev;
            string sor2 = "Dátum: " + actVetites[vetin].Idopont;
            string sor3 = (x+1) + ". sor, " + (y+1) + ". szék";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Jegy nyomtatás";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.FileName = "jegy.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName,sor1+"\n"+sor2+"\n"+sor3);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            nyomtbtn.Enabled = false;
        }

        private void nyomtbtn_Click(object sender, EventArgs e)
        {
            Jegy();
        }
    }
}
