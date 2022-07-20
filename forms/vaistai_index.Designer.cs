namespace forms
{
    partial class vaistai_index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vaistai_index));
            this.kiti_vaistai_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kiti_vaistai_matas = new System.Windows.Forms.TextBox();
            this.kiti_vaistai_pav = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kiti_vaistai_button
            // 
            this.kiti_vaistai_button.Location = new System.Drawing.Point(313, 136);
            this.kiti_vaistai_button.Name = "kiti_vaistai_button";
            this.kiti_vaistai_button.Size = new System.Drawing.Size(99, 33);
            this.kiti_vaistai_button.TabIndex = 0;
            this.kiti_vaistai_button.Text = "Saugoti";
            this.kiti_vaistai_button.UseVisualStyleBackColor = true;
            this.kiti_vaistai_button.Click += new System.EventHandler(this.kiti_vaistai_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pavadinimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Matas";
            // 
            // kiti_vaistai_matas
            // 
            this.kiti_vaistai_matas.Location = new System.Drawing.Point(143, 86);
            this.kiti_vaistai_matas.Name = "kiti_vaistai_matas";
            this.kiti_vaistai_matas.Size = new System.Drawing.Size(203, 26);
            this.kiti_vaistai_matas.TabIndex = 3;
            // 
            // kiti_vaistai_pav
            // 
            this.kiti_vaistai_pav.Location = new System.Drawing.Point(143, 34);
            this.kiti_vaistai_pav.Name = "kiti_vaistai_pav";
            this.kiti_vaistai_pav.Size = new System.Drawing.Size(203, 26);
            this.kiti_vaistai_pav.TabIndex = 4;
            // 
            // vaistai_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 208);
            this.Controls.Add(this.kiti_vaistai_pav);
            this.Controls.Add(this.kiti_vaistai_matas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kiti_vaistai_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "vaistai_index";
            this.Text = "Vaistas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kiti_vaistai_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kiti_vaistai_matas;
        private System.Windows.Forms.TextBox kiti_vaistai_pav;
    }
}