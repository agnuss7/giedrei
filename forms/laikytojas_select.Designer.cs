namespace forms
{
    partial class laikytojas_select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laikytojas_select));
            this.select_laikytojas = new System.Windows.Forms.ListView();
            this.vardas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pavarde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adresas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefonas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.laikytojas_select_searchbox = new System.Windows.Forms.TextBox();
            this.laikytojas_select_ieskoti = new System.Windows.Forms.Button();
            this.laikytojas_select_select = new System.Windows.Forms.Button();
            this.laikytojas_select_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select_laikytojas
            // 
            this.select_laikytojas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vardas,
            this.pavarde,
            this.adresas,
            this.telefonas});
            this.select_laikytojas.FullRowSelect = true;
            this.select_laikytojas.HideSelection = false;
            this.select_laikytojas.Location = new System.Drawing.Point(33, 103);
            this.select_laikytojas.Margin = new System.Windows.Forms.Padding(4);
            this.select_laikytojas.Name = "select_laikytojas";
            this.select_laikytojas.Size = new System.Drawing.Size(579, 128);
            this.select_laikytojas.TabIndex = 1;
            this.select_laikytojas.UseCompatibleStateImageBehavior = false;
            this.select_laikytojas.View = System.Windows.Forms.View.Details;
            // 
            // vardas
            // 
            this.vardas.Text = "Vardas";
            this.vardas.Width = 119;
            // 
            // pavarde
            // 
            this.pavarde.Text = "Pavardė";
            this.pavarde.Width = 120;
            // 
            // adresas
            // 
            this.adresas.Text = "Adresas";
            this.adresas.Width = 137;
            // 
            // telefonas
            // 
            this.telefonas.Text = "Telefonas";
            this.telefonas.Width = 184;
            // 
            // laikytojas_select_searchbox
            // 
            this.laikytojas_select_searchbox.Location = new System.Drawing.Point(33, 43);
            this.laikytojas_select_searchbox.Name = "laikytojas_select_searchbox";
            this.laikytojas_select_searchbox.Size = new System.Drawing.Size(266, 26);
            this.laikytojas_select_searchbox.TabIndex = 2;
            // 
            // laikytojas_select_ieskoti
            // 
            this.laikytojas_select_ieskoti.Location = new System.Drawing.Point(326, 43);
            this.laikytojas_select_ieskoti.Name = "laikytojas_select_ieskoti";
            this.laikytojas_select_ieskoti.Size = new System.Drawing.Size(90, 26);
            this.laikytojas_select_ieskoti.TabIndex = 3;
            this.laikytojas_select_ieskoti.Text = "Ieškoti";
            this.laikytojas_select_ieskoti.UseVisualStyleBackColor = true;
            this.laikytojas_select_ieskoti.Click += new System.EventHandler(this.laikytojas_select_ieskoti_Click);
            // 
            // laikytojas_select_select
            // 
            this.laikytojas_select_select.Location = new System.Drawing.Point(379, 268);
            this.laikytojas_select_select.Name = "laikytojas_select_select";
            this.laikytojas_select_select.Size = new System.Drawing.Size(233, 29);
            this.laikytojas_select_select.TabIndex = 4;
            this.laikytojas_select_select.Text = "Pasirinkti pažymėtą savininką";
            this.laikytojas_select_select.UseVisualStyleBackColor = true;
            this.laikytojas_select_select.Click += new System.EventHandler(this.laikytojas_select_select_Click);
            // 
            // laikytojas_select_new
            // 
            this.laikytojas_select_new.Location = new System.Drawing.Point(152, 268);
            this.laikytojas_select_new.Name = "laikytojas_select_new";
            this.laikytojas_select_new.Size = new System.Drawing.Size(221, 29);
            this.laikytojas_select_new.TabIndex = 5;
            this.laikytojas_select_new.Text = "Užregistruoti naują savininką";
            this.laikytojas_select_new.UseVisualStyleBackColor = true;
            this.laikytojas_select_new.Click += new System.EventHandler(this.laikytojas_select_new_Click);
            // 
            // laikytojas_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 309);
            this.Controls.Add(this.laikytojas_select_new);
            this.Controls.Add(this.laikytojas_select_select);
            this.Controls.Add(this.laikytojas_select_ieskoti);
            this.Controls.Add(this.laikytojas_select_searchbox);
            this.Controls.Add(this.select_laikytojas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "laikytojas_select";
            this.Text = "Pasirinkti savininką";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView select_laikytojas;
        private System.Windows.Forms.ColumnHeader vardas;
        private System.Windows.Forms.ColumnHeader pavarde;
        private System.Windows.Forms.ColumnHeader adresas;
        private System.Windows.Forms.ColumnHeader telefonas;
        private System.Windows.Forms.TextBox laikytojas_select_searchbox;
        private System.Windows.Forms.Button laikytojas_select_ieskoti;
        private System.Windows.Forms.Button laikytojas_select_select;
        private System.Windows.Forms.Button laikytojas_select_new;
    }
}