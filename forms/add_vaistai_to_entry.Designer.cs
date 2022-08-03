namespace forms
{
    partial class add_vaistai_to_entry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_vaistai_to_entry));
            this.add_selected_vaistai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vaistai_add_search = new System.Windows.Forms.TextBox();
            this.vaistai_entry_search = new System.Windows.Forms.Button();
            this.vaistai_to_add = new System.Windows.Forms.ListView();
            this.pavadinimas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.matas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.galiojaiki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kiekis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sveikas_kiekis = new System.Windows.Forms.NumericUpDown();
            this.pirmas_kiekis = new System.Windows.Forms.NumericUpDown();
            this.antras_kiekis = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.selected_vaistas = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sveikas_kiekis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirmas_kiekis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antras_kiekis)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_selected_vaistai
            // 
            this.add_selected_vaistai.Location = new System.Drawing.Point(620, 334);
            this.add_selected_vaistai.Name = "add_selected_vaistai";
            this.add_selected_vaistai.Size = new System.Drawing.Size(186, 37);
            this.add_selected_vaistai.TabIndex = 0;
            this.add_selected_vaistai.Text = "Skirti pasirinktą vaistą";
            this.add_selected_vaistai.UseVisualStyleBackColor = true;
            this.add_selected_vaistai.Click += new System.EventHandler(this.add_selected_vaistai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vaistai_add_search);
            this.groupBox1.Controls.Add(this.vaistai_entry_search);
            this.groupBox1.Location = new System.Drawing.Point(19, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paieška";
            // 
            // vaistai_add_search
            // 
            this.vaistai_add_search.Location = new System.Drawing.Point(24, 30);
            this.vaistai_add_search.Name = "vaistai_add_search";
            this.vaistai_add_search.Size = new System.Drawing.Size(565, 26);
            this.vaistai_add_search.TabIndex = 1;
            // 
            // vaistai_entry_search
            // 
            this.vaistai_entry_search.Location = new System.Drawing.Point(612, 28);
            this.vaistai_entry_search.Name = "vaistai_entry_search";
            this.vaistai_entry_search.Size = new System.Drawing.Size(152, 31);
            this.vaistai_entry_search.TabIndex = 0;
            this.vaistai_entry_search.Text = "Ieškoti";
            this.vaistai_entry_search.UseVisualStyleBackColor = true;
            this.vaistai_entry_search.Click += new System.EventHandler(this.vaistai_entry_search_Click);
            // 
            // vaistai_to_add
            // 
            this.vaistai_to_add.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pavadinimas,
            this.matas,
            this.galiojaiki,
            this.kiekis,
            this.serija,
            this.columnHeader1});
            this.vaistai_to_add.FullRowSelect = true;
            this.vaistai_to_add.HideSelection = false;
            this.vaistai_to_add.Location = new System.Drawing.Point(19, 130);
            this.vaistai_to_add.Name = "vaistai_to_add";
            this.vaistai_to_add.Size = new System.Drawing.Size(787, 171);
            this.vaistai_to_add.TabIndex = 2;
            this.vaistai_to_add.UseCompatibleStateImageBehavior = false;
            this.vaistai_to_add.View = System.Windows.Forms.View.Details;
            this.vaistai_to_add.SelectedIndexChanged += new System.EventHandler(this.vaistai_to_add_SelectedIndexChanged);
            // 
            // pavadinimas
            // 
            this.pavadinimas.Text = "Pavadinimas";
            this.pavadinimas.Width = 162;
            // 
            // matas
            // 
            this.matas.Text = "Matas";
            this.matas.Width = 105;
            // 
            // galiojaiki
            // 
            this.galiojaiki.Text = "Galioja iki";
            this.galiojaiki.Width = 139;
            // 
            // serija
            // 
            this.serija.Text = "Serijos Nr";
            this.serija.Width = 129;
            // 
            // kiekis
            // 
            this.kiekis.Text = "Likęs kiekis";
            this.kiekis.Width = 114;
            // 
            // sveikas_kiekis
            // 
            this.sveikas_kiekis.Location = new System.Drawing.Point(14, 23);
            this.sveikas_kiekis.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.sveikas_kiekis.Name = "sveikas_kiekis";
            this.sveikas_kiekis.Size = new System.Drawing.Size(62, 26);
            this.sveikas_kiekis.TabIndex = 3;
            // 
            // pirmas_kiekis
            // 
            this.pirmas_kiekis.Location = new System.Drawing.Point(89, 23);
            this.pirmas_kiekis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.pirmas_kiekis.Name = "pirmas_kiekis";
            this.pirmas_kiekis.ReadOnly = true;
            this.pirmas_kiekis.Size = new System.Drawing.Size(32, 26);
            this.pirmas_kiekis.TabIndex = 4;
            // 
            // antras_kiekis
            // 
            this.antras_kiekis.Location = new System.Drawing.Point(126, 23);
            this.antras_kiekis.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.antras_kiekis.Name = "antras_kiekis";
            this.antras_kiekis.ReadOnly = true;
            this.antras_kiekis.Size = new System.Drawing.Size(32, 26);
            this.antras_kiekis.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = ",";
            // 
            // selected_vaistas
            // 
            this.selected_vaistas.AutoSize = true;
            this.selected_vaistas.Location = new System.Drawing.Point(23, 25);
            this.selected_vaistas.Name = "selected_vaistas";
            this.selected_vaistas.Size = new System.Drawing.Size(21, 20);
            this.selected_vaistas.TabIndex = 7;
            this.selected_vaistas.Text = "   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.antras_kiekis);
            this.groupBox2.Controls.Add(this.pirmas_kiekis);
            this.groupBox2.Controls.Add(this.sveikas_kiekis);
            this.groupBox2.Location = new System.Drawing.Point(443, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 65);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiekis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.selected_vaistas);
            this.groupBox3.Location = new System.Drawing.Point(16, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(415, 65);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pasirinktas vaistas";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dokumento nr";
            this.columnHeader1.Width = 129;
            // 
            // add_vaistai_to_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.vaistai_to_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.add_selected_vaistai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "add_vaistai_to_entry";
            this.Text = "Vaistų skyrimas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sveikas_kiekis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirmas_kiekis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antras_kiekis)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_selected_vaistai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView vaistai_to_add;
        private System.Windows.Forms.TextBox vaistai_add_search;
        private System.Windows.Forms.Button vaistai_entry_search;
        private System.Windows.Forms.ColumnHeader pavadinimas;
        private System.Windows.Forms.ColumnHeader matas;
        private System.Windows.Forms.ColumnHeader galiojaiki;
        private System.Windows.Forms.ColumnHeader serija;
        private System.Windows.Forms.ColumnHeader kiekis;
        private System.Windows.Forms.NumericUpDown sveikas_kiekis;
        private System.Windows.Forms.NumericUpDown pirmas_kiekis;
        private System.Windows.Forms.NumericUpDown antras_kiekis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selected_vaistas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}