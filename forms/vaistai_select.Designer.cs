namespace forms
{
    partial class vaistai_select
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
            this.vaistai_list = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vaistai_select_pick_button = new System.Windows.Forms.Button();
            this.vaistai_select_new_button = new System.Windows.Forms.Button();
            this.vaistai_select_search_button = new System.Windows.Forms.Button();
            this.vaistai_select_search_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vaistai_list
            // 
            this.vaistai_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.vaistai_list.FullRowSelect = true;
            this.vaistai_list.HideSelection = false;
            this.vaistai_list.Location = new System.Drawing.Point(18, 93);
            this.vaistai_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaistai_list.MultiSelect = false;
            this.vaistai_list.Name = "vaistai_list";
            this.vaistai_list.ShowGroups = false;
            this.vaistai_list.Size = new System.Drawing.Size(433, 181);
            this.vaistai_list.TabIndex = 0;
            this.vaistai_list.UseCompatibleStateImageBehavior = false;
            this.vaistai_list.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Pavadinimas";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Matas";
            this.columnHeader2.Width = 100;
            // 
            // vaistai_select_pick_button
            // 
            this.vaistai_select_pick_button.Location = new System.Drawing.Point(216, 300);
            this.vaistai_select_pick_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaistai_select_pick_button.Name = "vaistai_select_pick_button";
            this.vaistai_select_pick_button.Size = new System.Drawing.Size(220, 35);
            this.vaistai_select_pick_button.TabIndex = 1;
            this.vaistai_select_pick_button.Text = "Priskirti pažymėtą vaistą";
            this.vaistai_select_pick_button.UseVisualStyleBackColor = true;
            this.vaistai_select_pick_button.Click += new System.EventHandler(this.vaistai_select_pick_button_Click);
            // 
            // vaistai_select_new_button
            // 
            this.vaistai_select_new_button.Location = new System.Drawing.Point(74, 300);
            this.vaistai_select_new_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaistai_select_new_button.Name = "vaistai_select_new_button";
            this.vaistai_select_new_button.Size = new System.Drawing.Size(134, 35);
            this.vaistai_select_new_button.TabIndex = 2;
            this.vaistai_select_new_button.Text = "Naujas vaistas";
            this.vaistai_select_new_button.UseVisualStyleBackColor = true;
            this.vaistai_select_new_button.Click += new System.EventHandler(this.vaistai_select_new_button_Click);
            // 
            // vaistai_select_search_button
            // 
            this.vaistai_select_search_button.Location = new System.Drawing.Point(339, 27);
            this.vaistai_select_search_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaistai_select_search_button.Name = "vaistai_select_search_button";
            this.vaistai_select_search_button.Size = new System.Drawing.Size(112, 35);
            this.vaistai_select_search_button.TabIndex = 3;
            this.vaistai_select_search_button.Text = "Ieškoti";
            this.vaistai_select_search_button.UseVisualStyleBackColor = true;
            this.vaistai_select_search_button.Click += new System.EventHandler(this.vaistai_select_search_button_Click);
            // 
            // vaistai_select_search_box
            // 
            this.vaistai_select_search_box.Location = new System.Drawing.Point(18, 31);
            this.vaistai_select_search_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vaistai_select_search_box.Name = "vaistai_select_search_box";
            this.vaistai_select_search_box.Size = new System.Drawing.Size(288, 26);
            this.vaistai_select_search_box.TabIndex = 4;
            // 
            // vaistai_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 357);
            this.Controls.Add(this.vaistai_select_search_box);
            this.Controls.Add(this.vaistai_select_search_button);
            this.Controls.Add(this.vaistai_select_new_button);
            this.Controls.Add(this.vaistai_select_pick_button);
            this.Controls.Add(this.vaistai_list);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "vaistai_select";
            this.Text = "vaistai_select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vaistai_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button vaistai_select_pick_button;
        private System.Windows.Forms.Button vaistai_select_new_button;
        private System.Windows.Forms.Button vaistai_select_search_button;
        private System.Windows.Forms.TextBox vaistai_select_search_box;
    }
}