namespace forms
{
    partial class Zurnalas
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("id", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("id2", System.Windows.Forms.HorizontalAlignment.Left);
            this.zurnalas_list = new System.Windows.Forms.ListView();
            this.l = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.zurnalas_new_button = new System.Windows.Forms.Button();
            this.reload_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // zurnalas_list
            // 
            this.zurnalas_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.zurnalas_list.AutoArrange = false;
            this.zurnalas_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zurnalas_list.FullRowSelect = true;
            this.zurnalas_list.GridLines = true;
            listViewGroup1.Header = "id";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "id2";
            listViewGroup2.Name = "listViewGroup2";
            this.zurnalas_list.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.zurnalas_list.HideSelection = false;
            this.zurnalas_list.Location = new System.Drawing.Point(4, 23);
            this.zurnalas_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zurnalas_list.MultiSelect = false;
            this.zurnalas_list.Name = "zurnalas_list";
            this.zurnalas_list.Size = new System.Drawing.Size(1281, 388);
            this.zurnalas_list.TabIndex = 0;
            this.zurnalas_list.UseCompatibleStateImageBehavior = false;
            this.zurnalas_list.View = System.Windows.Forms.View.Details;
            this.zurnalas_list.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.zurnalas_list_ColumnClick);
            this.zurnalas_list.SelectedIndexChanged += new System.EventHandler(this.zurnalas_list_SelectedIndexChanged);
            this.zurnalas_list.DoubleClick += new System.EventHandler(this.zurnalas_list_DoubleClick);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(163, 416);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(15, 20);
            this.l.TabIndex = 2;
            this.l.Text = "ll";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1308, 733);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.zurnalas_new_button);
            this.tabPage1.Controls.Add(this.reload_button);
            this.tabPage1.Controls.Add(this.Edit_button);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1300, 705);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Žurnalas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // zurnalas_new_button
            // 
            this.zurnalas_new_button.Location = new System.Drawing.Point(481, 503);
            this.zurnalas_new_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zurnalas_new_button.Name = "zurnalas_new_button";
            this.zurnalas_new_button.Size = new System.Drawing.Size(172, 49);
            this.zurnalas_new_button.TabIndex = 6;
            this.zurnalas_new_button.Text = "Naujas įrašas";
            this.zurnalas_new_button.UseVisualStyleBackColor = true;
            this.zurnalas_new_button.Click += new System.EventHandler(this.zurnalas_new_button_Click);
            // 
            // reload_button
            // 
            this.reload_button.Location = new System.Drawing.Point(231, 503);
            this.reload_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reload_button.Name = "reload_button";
            this.reload_button.Size = new System.Drawing.Size(152, 49);
            this.reload_button.TabIndex = 5;
            this.reload_button.Text = "Perkrauti";
            this.reload_button.UseVisualStyleBackColor = true;
            this.reload_button.Click += new System.EventHandler(this.reload_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(13, 503);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(134, 51);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Redaguoti";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.zurnalas_list);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(4, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1290, 416);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagrindinis ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1290, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(4, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1300, 705);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vaistų siuntos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Zurnalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.l);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Zurnalas";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zurnalas_list;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button reload_button;
        private System.Windows.Forms.Button zurnalas_new_button;
    }
}

