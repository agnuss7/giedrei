namespace forms
{
    partial class tyrimai_index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tyrimai_index));
            this.label1 = new System.Windows.Forms.Label();
            this.kiti_tyrimai_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kiti_tyrimai_zym = new System.Windows.Forms.TextBox();
            this.kiti_tyrimai_antraste = new System.Windows.Forms.TextBox();
            this.kiti_tyrimai_kodas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kodas";
            // 
            // kiti_tyrimai_button
            // 
            this.kiti_tyrimai_button.Location = new System.Drawing.Point(339, 176);
            this.kiti_tyrimai_button.Name = "kiti_tyrimai_button";
            this.kiti_tyrimai_button.Size = new System.Drawing.Size(88, 33);
            this.kiti_tyrimai_button.TabIndex = 1;
            this.kiti_tyrimai_button.Text = "Saugoti";
            this.kiti_tyrimai_button.UseVisualStyleBackColor = true;
            this.kiti_tyrimai_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Antraštė";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tyrimo žymuo";
            // 
            // kiti_tyrimai_zym
            // 
            this.kiti_tyrimai_zym.Location = new System.Drawing.Point(163, 31);
            this.kiti_tyrimai_zym.Name = "kiti_tyrimai_zym";
            this.kiti_tyrimai_zym.Size = new System.Drawing.Size(178, 26);
            this.kiti_tyrimai_zym.TabIndex = 4;
            // 
            // kiti_tyrimai_antraste
            // 
            this.kiti_tyrimai_antraste.Location = new System.Drawing.Point(163, 76);
            this.kiti_tyrimai_antraste.Name = "kiti_tyrimai_antraste";
            this.kiti_tyrimai_antraste.Size = new System.Drawing.Size(241, 26);
            this.kiti_tyrimai_antraste.TabIndex = 5;
            // 
            // kiti_tyrimai_kodas
            // 
            this.kiti_tyrimai_kodas.Location = new System.Drawing.Point(163, 122);
            this.kiti_tyrimai_kodas.Name = "kiti_tyrimai_kodas";
            this.kiti_tyrimai_kodas.Size = new System.Drawing.Size(178, 26);
            this.kiti_tyrimai_kodas.TabIndex = 6;
            // 
            // tyrimai_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 240);
            this.Controls.Add(this.kiti_tyrimai_kodas);
            this.Controls.Add(this.kiti_tyrimai_antraste);
            this.Controls.Add(this.kiti_tyrimai_zym);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kiti_tyrimai_button);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tyrimai_index";
            this.Text = "Tyrimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kiti_tyrimai_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kiti_tyrimai_zym;
        private System.Windows.Forms.TextBox kiti_tyrimai_antraste;
        private System.Windows.Forms.TextBox kiti_tyrimai_kodas;
    }
}