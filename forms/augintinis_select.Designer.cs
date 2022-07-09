namespace forms
{
    partial class augintinis_select
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
            this.augintinis_select_new = new System.Windows.Forms.Button();
            this.augintinis_select_select = new System.Windows.Forms.Button();
            this.augintinis_select_ieskoti = new System.Windows.Forms.Button();
            this.augintinis_select_searchbox = new System.Windows.Forms.TextBox();
            this.select_augintinis = new System.Windows.Forms.ListView();
            this.vardas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rusis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.veisle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zenk_nr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lytis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isvaizda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pasas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amzius = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // augintinis_select_new
            // 
            this.augintinis_select_new.Location = new System.Drawing.Point(218, 373);
            this.augintinis_select_new.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.augintinis_select_new.Name = "augintinis_select_new";
            this.augintinis_select_new.Size = new System.Drawing.Size(332, 45);
            this.augintinis_select_new.TabIndex = 10;
            this.augintinis_select_new.Text = "Užregistruoti naują augintinį";
            this.augintinis_select_new.UseVisualStyleBackColor = true;
            this.augintinis_select_new.Click += new System.EventHandler(this.augintinis_select_new_Click);
            // 
            // augintinis_select_select
            // 
            this.augintinis_select_select.Location = new System.Drawing.Point(559, 373);
            this.augintinis_select_select.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.augintinis_select_select.Name = "augintinis_select_select";
            this.augintinis_select_select.Size = new System.Drawing.Size(350, 45);
            this.augintinis_select_select.TabIndex = 9;
            this.augintinis_select_select.Text = "Pasirinkti pažymėtą augintinį";
            this.augintinis_select_select.UseVisualStyleBackColor = true;
            this.augintinis_select_select.Click += new System.EventHandler(this.augintinis_select_select_Click);
            // 
            // augintinis_select_ieskoti
            // 
            this.augintinis_select_ieskoti.Location = new System.Drawing.Point(489, 47);
            this.augintinis_select_ieskoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.augintinis_select_ieskoti.Name = "augintinis_select_ieskoti";
            this.augintinis_select_ieskoti.Size = new System.Drawing.Size(135, 40);
            this.augintinis_select_ieskoti.TabIndex = 8;
            this.augintinis_select_ieskoti.Text = "Ieškoti";
            this.augintinis_select_ieskoti.UseVisualStyleBackColor = true;
            this.augintinis_select_ieskoti.Click += new System.EventHandler(this.augintinis_select_ieskoti_Click);
            // 
            // augintinis_select_searchbox
            // 
            this.augintinis_select_searchbox.Location = new System.Drawing.Point(39, 54);
            this.augintinis_select_searchbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.augintinis_select_searchbox.Name = "augintinis_select_searchbox";
            this.augintinis_select_searchbox.Size = new System.Drawing.Size(397, 26);
            this.augintinis_select_searchbox.TabIndex = 7;
            // 
            // select_augintinis
            // 
            this.select_augintinis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vardas,
            this.rusis,
            this.veisle,
            this.zenk_nr,
            this.lytis,
            this.isvaizda,
            this.pasas,
            this.amzius});
            this.select_augintinis.FullRowSelect = true;
            this.select_augintinis.HideSelection = false;
            this.select_augintinis.Location = new System.Drawing.Point(39, 119);
            this.select_augintinis.Margin = new System.Windows.Forms.Padding(6);
            this.select_augintinis.Name = "select_augintinis";
            this.select_augintinis.Size = new System.Drawing.Size(866, 195);
            this.select_augintinis.TabIndex = 6;
            this.select_augintinis.UseCompatibleStateImageBehavior = false;
            this.select_augintinis.View = System.Windows.Forms.View.Details;
            // 
            // vardas
            // 
            this.vardas.Text = "Vardas";
            this.vardas.Width = 119;
            // 
            // rusis
            // 
            this.rusis.Text = "Rūšis";
            this.rusis.Width = 111;
            // 
            // veisle
            // 
            this.veisle.DisplayIndex = 6;
            this.veisle.Text = "Veislė";
            // 
            // zenk_nr
            // 
            this.zenk_nr.DisplayIndex = 2;
            this.zenk_nr.Text = "Ženklinimo numeris";
            this.zenk_nr.Width = 262;
            // 
            // lytis
            // 
            this.lytis.DisplayIndex = 3;
            this.lytis.Text = "Lytis";
            this.lytis.Width = 184;
            // 
            // isvaizda
            // 
            this.isvaizda.DisplayIndex = 4;
            this.isvaizda.Text = "Išvaizda";
            this.isvaizda.Width = 154;
            // 
            // pasas
            // 
            this.pasas.DisplayIndex = 5;
            this.pasas.Text = "Paso numeris";
            // 
            // amzius
            // 
            this.amzius.Text = "Amžius";
            // 
            // augintinis_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 486);
            this.Controls.Add(this.augintinis_select_new);
            this.Controls.Add(this.augintinis_select_select);
            this.Controls.Add(this.augintinis_select_ieskoti);
            this.Controls.Add(this.augintinis_select_searchbox);
            this.Controls.Add(this.select_augintinis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "augintinis_select";
            this.Text = "augintinis_select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button augintinis_select_new;
        private System.Windows.Forms.Button augintinis_select_select;
        private System.Windows.Forms.Button augintinis_select_ieskoti;
        private System.Windows.Forms.TextBox augintinis_select_searchbox;
        private System.Windows.Forms.ListView select_augintinis;
        private System.Windows.Forms.ColumnHeader vardas;
        private System.Windows.Forms.ColumnHeader rusis;
        private System.Windows.Forms.ColumnHeader zenk_nr;
        private System.Windows.Forms.ColumnHeader lytis;
        private System.Windows.Forms.ColumnHeader veisle;
        private System.Windows.Forms.ColumnHeader isvaizda;
        private System.Windows.Forms.ColumnHeader pasas;
        private System.Windows.Forms.ColumnHeader amzius;
    }
}