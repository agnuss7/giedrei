namespace forms
{
    partial class laikytojai_index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(laikytojai_index));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kiti_laikytojai_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kiti_laikytojai_vardas = new System.Windows.Forms.TextBox();
            this.kiti_laikytojai_pavarde = new System.Windows.Forms.TextBox();
            this.kiti_laikytojai_adresas = new System.Windows.Forms.TextBox();
            this.kiti_laikytojai_tel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pavardė";
            // 
            // kiti_laikytojai_button
            // 
            this.kiti_laikytojai_button.Location = new System.Drawing.Point(292, 208);
            this.kiti_laikytojai_button.Name = "kiti_laikytojai_button";
            this.kiti_laikytojai_button.Size = new System.Drawing.Size(81, 30);
            this.kiti_laikytojai_button.TabIndex = 2;
            this.kiti_laikytojai_button.Text = "Saugoti";
            this.kiti_laikytojai_button.UseVisualStyleBackColor = true;
            this.kiti_laikytojai_button.Click += new System.EventHandler(this.kiti_laikytojai_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefonas";
            // 
            // kiti_laikytojai_vardas
            // 
            this.kiti_laikytojai_vardas.Location = new System.Drawing.Point(131, 27);
            this.kiti_laikytojai_vardas.Name = "kiti_laikytojai_vardas";
            this.kiti_laikytojai_vardas.Size = new System.Drawing.Size(195, 26);
            this.kiti_laikytojai_vardas.TabIndex = 5;
            // 
            // kiti_laikytojai_pavarde
            // 
            this.kiti_laikytojai_pavarde.Location = new System.Drawing.Point(131, 70);
            this.kiti_laikytojai_pavarde.Name = "kiti_laikytojai_pavarde";
            this.kiti_laikytojai_pavarde.Size = new System.Drawing.Size(195, 26);
            this.kiti_laikytojai_pavarde.TabIndex = 6;
            // 
            // kiti_laikytojai_adresas
            // 
            this.kiti_laikytojai_adresas.Location = new System.Drawing.Point(131, 113);
            this.kiti_laikytojai_adresas.Name = "kiti_laikytojai_adresas";
            this.kiti_laikytojai_adresas.Size = new System.Drawing.Size(195, 26);
            this.kiti_laikytojai_adresas.TabIndex = 7;
            // 
            // kiti_laikytojai_tel
            // 
            this.kiti_laikytojai_tel.Location = new System.Drawing.Point(131, 157);
            this.kiti_laikytojai_tel.Name = "kiti_laikytojai_tel";
            this.kiti_laikytojai_tel.Size = new System.Drawing.Size(195, 26);
            this.kiti_laikytojai_tel.TabIndex = 8;
            // 
            // laikytojai_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 267);
            this.Controls.Add(this.kiti_laikytojai_tel);
            this.Controls.Add(this.kiti_laikytojai_adresas);
            this.Controls.Add(this.kiti_laikytojai_pavarde);
            this.Controls.Add(this.kiti_laikytojai_vardas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kiti_laikytojai_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "laikytojai_index";
            this.Text = "Savininkas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kiti_laikytojai_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kiti_laikytojai_vardas;
        private System.Windows.Forms.TextBox kiti_laikytojai_pavarde;
        private System.Windows.Forms.TextBox kiti_laikytojai_adresas;
        private System.Windows.Forms.TextBox kiti_laikytojai_tel;
    }
}