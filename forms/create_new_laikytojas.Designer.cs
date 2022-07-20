namespace forms
{
    partial class create_new_laikytojas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_new_laikytojas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.new_laik_vardas = new System.Windows.Forms.TextBox();
            this.new_laik_pavarde = new System.Windows.Forms.TextBox();
            this.new_adresas = new System.Windows.Forms.TextBox();
            this.new_telefonas = new System.Windows.Forms.TextBox();
            this.new_create_laikytojas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pavardė";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefonas";
            // 
            // new_laik_vardas
            // 
            this.new_laik_vardas.Location = new System.Drawing.Point(139, 38);
            this.new_laik_vardas.Name = "new_laik_vardas";
            this.new_laik_vardas.Size = new System.Drawing.Size(200, 26);
            this.new_laik_vardas.TabIndex = 4;
            // 
            // new_laik_pavarde
            // 
            this.new_laik_pavarde.Location = new System.Drawing.Point(139, 76);
            this.new_laik_pavarde.Name = "new_laik_pavarde";
            this.new_laik_pavarde.Size = new System.Drawing.Size(200, 26);
            this.new_laik_pavarde.TabIndex = 5;
            // 
            // new_adresas
            // 
            this.new_adresas.Location = new System.Drawing.Point(139, 111);
            this.new_adresas.Name = "new_adresas";
            this.new_adresas.Size = new System.Drawing.Size(200, 26);
            this.new_adresas.TabIndex = 6;
            // 
            // new_telefonas
            // 
            this.new_telefonas.Location = new System.Drawing.Point(139, 150);
            this.new_telefonas.Name = "new_telefonas";
            this.new_telefonas.Size = new System.Drawing.Size(200, 26);
            this.new_telefonas.TabIndex = 7;
            // 
            // new_create_laikytojas
            // 
            this.new_create_laikytojas.Location = new System.Drawing.Point(264, 201);
            this.new_create_laikytojas.Name = "new_create_laikytojas";
            this.new_create_laikytojas.Size = new System.Drawing.Size(112, 35);
            this.new_create_laikytojas.TabIndex = 8;
            this.new_create_laikytojas.Text = "Kurti";
            this.new_create_laikytojas.UseVisualStyleBackColor = true;
            this.new_create_laikytojas.Click += new System.EventHandler(this.new_create_laikytojas_Click);
            // 
            // create_new_laikytojas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 257);
            this.Controls.Add(this.new_create_laikytojas);
            this.Controls.Add(this.new_telefonas);
            this.Controls.Add(this.new_adresas);
            this.Controls.Add(this.new_laik_pavarde);
            this.Controls.Add(this.new_laik_vardas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "create_new_laikytojas";
            this.Text = "Kurti naują savininką";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_laik_vardas;
        private System.Windows.Forms.TextBox new_laik_pavarde;
        private System.Windows.Forms.TextBox new_adresas;
        private System.Windows.Forms.TextBox new_telefonas;
        private System.Windows.Forms.Button new_create_laikytojas;
    }
}