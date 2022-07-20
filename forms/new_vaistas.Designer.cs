namespace forms
{
    partial class new_vaistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_vaistas));
            this.new_vaistas_saugoti = new System.Windows.Forms.Button();
            this.new_vaistas_pavadinimas = new System.Windows.Forms.TextBox();
            this.new_vaistas_matas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_vaistas_saugoti
            // 
            this.new_vaistas_saugoti.Location = new System.Drawing.Point(251, 129);
            this.new_vaistas_saugoti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_vaistas_saugoti.Name = "new_vaistas_saugoti";
            this.new_vaistas_saugoti.Size = new System.Drawing.Size(112, 35);
            this.new_vaistas_saugoti.TabIndex = 0;
            this.new_vaistas_saugoti.Text = "Saugoti";
            this.new_vaistas_saugoti.UseVisualStyleBackColor = true;
            this.new_vaistas_saugoti.Click += new System.EventHandler(this.new_vaistas_saugoti_Click);
            // 
            // new_vaistas_pavadinimas
            // 
            this.new_vaistas_pavadinimas.Location = new System.Drawing.Point(119, 39);
            this.new_vaistas_pavadinimas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_vaistas_pavadinimas.Name = "new_vaistas_pavadinimas";
            this.new_vaistas_pavadinimas.Size = new System.Drawing.Size(160, 26);
            this.new_vaistas_pavadinimas.TabIndex = 1;
            // 
            // new_vaistas_matas
            // 
            this.new_vaistas_matas.Location = new System.Drawing.Point(119, 82);
            this.new_vaistas_matas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_vaistas_matas.Name = "new_vaistas_matas";
            this.new_vaistas_matas.Size = new System.Drawing.Size(160, 26);
            this.new_vaistas_matas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matas";
            // 
            // new_vaistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.new_vaistas_matas);
            this.Controls.Add(this.new_vaistas_pavadinimas);
            this.Controls.Add(this.new_vaistas_saugoti);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "new_vaistas";
            this.Text = "Kurti naują vaistą";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_vaistas_saugoti;
        private System.Windows.Forms.TextBox new_vaistas_pavadinimas;
        private System.Windows.Forms.TextBox new_vaistas_matas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}