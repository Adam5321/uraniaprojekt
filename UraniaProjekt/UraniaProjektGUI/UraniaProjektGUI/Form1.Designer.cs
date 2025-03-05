namespace UraniaProjektGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.moviesListbox = new System.Windows.Forms.ListBox();
            this.daysListbox = new System.Windows.Forms.ListBox();
            this.katListbox = new System.Windows.Forms.ListBox();
            this.movies = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.categories = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.foglalasbtn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vetitesListbox = new System.Windows.Forms.ListBox();
            this.datesListbox = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nyomtbtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPages.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Location = new System.Drawing.Point(13, 25);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(767, 399);
            this.tabPages.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.moviesListbox);
            this.tabPage1.Controls.Add(this.daysListbox);
            this.tabPage1.Controls.Add(this.katListbox);
            this.tabPage1.Controls.Add(this.movies);
            this.tabPage1.Controls.Add(this.days);
            this.tabPage1.Controls.Add(this.categories);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(759, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film lekérés";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Film leírás:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // moviesListbox
            // 
            this.moviesListbox.FormattingEnabled = true;
            this.moviesListbox.Location = new System.Drawing.Point(306, 42);
            this.moviesListbox.Name = "moviesListbox";
            this.moviesListbox.Size = new System.Drawing.Size(224, 95);
            this.moviesListbox.TabIndex = 5;
            this.moviesListbox.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // daysListbox
            // 
            this.daysListbox.FormattingEnabled = true;
            this.daysListbox.Location = new System.Drawing.Point(141, 42);
            this.daysListbox.Name = "daysListbox";
            this.daysListbox.Size = new System.Drawing.Size(120, 95);
            this.daysListbox.TabIndex = 4;
            // 
            // katListbox
            // 
            this.katListbox.FormattingEnabled = true;
            this.katListbox.Location = new System.Drawing.Point(6, 42);
            this.katListbox.Name = "katListbox";
            this.katListbox.ScrollAlwaysVisible = true;
            this.katListbox.Size = new System.Drawing.Size(120, 95);
            this.katListbox.TabIndex = 3;
            // 
            // movies
            // 
            this.movies.AutoSize = true;
            this.movies.Location = new System.Drawing.Point(303, 26);
            this.movies.Name = "movies";
            this.movies.Size = new System.Drawing.Size(37, 13);
            this.movies.TabIndex = 2;
            this.movies.Text = "Filmek";
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(179, 26);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(39, 13);
            this.days.TabIndex = 1;
            this.days.Text = "Napok";
            // 
            // categories
            // 
            this.categories.AutoSize = true;
            this.categories.Location = new System.Drawing.Point(46, 26);
            this.categories.Name = "categories";
            this.categories.Size = new System.Drawing.Size(58, 13);
            this.categories.TabIndex = 0;
            this.categories.Text = "Kategóriák";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nyomtbtn);
            this.tabPage2.Controls.Add(this.foglalasbtn);
            this.tabPage2.Controls.Add(this.dgv);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.vetitesListbox);
            this.tabPage2.Controls.Add(this.datesListbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(759, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hely foglalás";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // foglalasbtn
            // 
            this.foglalasbtn.Location = new System.Drawing.Point(417, 281);
            this.foglalasbtn.Name = "foglalasbtn";
            this.foglalasbtn.Size = new System.Drawing.Size(75, 23);
            this.foglalasbtn.TabIndex = 5;
            this.foglalasbtn.Text = "Foglalás";
            this.foglalasbtn.UseVisualStyleBackColor = true;
            this.foglalasbtn.Click += new System.EventHandler(this.foglalasbtn_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(26, 157);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(362, 183);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Vetítések";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dátumok";
            // 
            // vetitesListbox
            // 
            this.vetitesListbox.FormattingEnabled = true;
            this.vetitesListbox.Location = new System.Drawing.Point(166, 38);
            this.vetitesListbox.Name = "vetitesListbox";
            this.vetitesListbox.Size = new System.Drawing.Size(222, 95);
            this.vetitesListbox.TabIndex = 1;
            this.vetitesListbox.SelectedIndexChanged += new System.EventHandler(this.vetitesListbox_SelectedIndexChanged);
            // 
            // datesListbox
            // 
            this.datesListbox.FormattingEnabled = true;
            this.datesListbox.Location = new System.Drawing.Point(26, 38);
            this.datesListbox.Name = "datesListbox";
            this.datesListbox.Size = new System.Drawing.Size(120, 95);
            this.datesListbox.TabIndex = 0;
            this.datesListbox.SelectedIndexChanged += new System.EventHandler(this.datesListbox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(759, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Heti filmek megtekintése";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nyomtbtn
            // 
            this.nyomtbtn.Location = new System.Drawing.Point(417, 310);
            this.nyomtbtn.Name = "nyomtbtn";
            this.nyomtbtn.Size = new System.Drawing.Size(75, 23);
            this.nyomtbtn.TabIndex = 6;
            this.nyomtbtn.Text = "Nyomtatás";
            this.nyomtbtn.UseVisualStyleBackColor = true;
            this.nyomtbtn.Click += new System.EventHandler(this.nyomtbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabPages);
            this.Name = "Form1";
            this.Text = "Mozi";
            this.tabPages.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label movies;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label categories;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox daysListbox;
        private System.Windows.Forms.ListBox katListbox;
        private System.Windows.Forms.ListBox moviesListbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox datesListbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox vetitesListbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button foglalasbtn;
        private System.Windows.Forms.Button nyomtbtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

