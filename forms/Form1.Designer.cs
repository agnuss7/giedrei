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
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("id", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("id2", System.Windows.Forms.HorizontalAlignment.Left);
            this.zurnalas_list = new System.Windows.Forms.ListView();
            this.l = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.zurnalas_new_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.main_simp_data_2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.main_search_button = new System.Windows.Forms.Button();
            this.main_reg_data_2 = new System.Windows.Forms.DateTimePicker();
            this.main_simp_data_1 = new System.Windows.Forms.DateTimePicker();
            this.main_reg_data_1 = new System.Windows.Forms.DateTimePicker();
            this.main_search_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.siuntos_edit_button = new System.Windows.Forms.Button();
            this.siuntos_new_button = new System.Windows.Forms.Button();
            this.siuntos_list = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.siuntos_galiojimo_data_2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.siuntos_search_button = new System.Windows.Forms.Button();
            this.siuntos_gavimo_data_2 = new System.Windows.Forms.DateTimePicker();
            this.siuntos_galiojimo_data_1 = new System.Windows.Forms.DateTimePicker();
            this.siuntos_gavimo_data_1 = new System.Windows.Forms.DateTimePicker();
            this.siuntos_search_box = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vaistas_pavadinimas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vaistas_matas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gavimo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dokumentas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gautas_kiekis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.turimas_kiekis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.galiojimo_data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siuntos_empty_show = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // zurnalas_list
            // 
            this.zurnalas_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.zurnalas_list.AutoArrange = false;
            this.zurnalas_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.zurnalas_list.FullRowSelect = true;
            this.zurnalas_list.GridLines = true;
            listViewGroup1.Header = "id";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "id2";
            listViewGroup2.Name = "listViewGroup2";
            this.zurnalas_list.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.zurnalas_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.zurnalas_list.HideSelection = false;
            this.zurnalas_list.Location = new System.Drawing.Point(4, 23);
            this.zurnalas_list.Margin = new System.Windows.Forms.Padding(4);
            this.zurnalas_list.MultiSelect = false;
            this.zurnalas_list.Name = "zurnalas_list";
            this.zurnalas_list.Size = new System.Drawing.Size(1125, 343);
            this.zurnalas_list.TabIndex = 0;
            this.zurnalas_list.UseCompatibleStateImageBehavior = false;
            this.zurnalas_list.View = System.Windows.Forms.View.Details;
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
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(70, 20);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 604);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1141, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Žurnalas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Edit_button);
            this.groupBox2.Controls.Add(this.zurnalas_new_button);
            this.groupBox2.Controls.Add(this.zurnalas_list);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1133, 436);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pagrindinis ";
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(36, 374);
            this.Edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(134, 51);
            this.Edit_button.TabIndex = 4;
            this.Edit_button.Text = "Redaguoti pasirinktą";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // zurnalas_new_button
            // 
            this.zurnalas_new_button.Location = new System.Drawing.Point(239, 374);
            this.zurnalas_new_button.Margin = new System.Windows.Forms.Padding(4);
            this.zurnalas_new_button.Name = "zurnalas_new_button";
            this.zurnalas_new_button.Size = new System.Drawing.Size(172, 49);
            this.zurnalas_new_button.TabIndex = 6;
            this.zurnalas_new_button.Text = "Naujas įrašas";
            this.zurnalas_new_button.UseVisualStyleBackColor = true;
            this.zurnalas_new_button.Click += new System.EventHandler(this.zurnalas_new_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.main_simp_data_2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.main_search_button);
            this.groupBox1.Controls.Add(this.main_reg_data_2);
            this.groupBox1.Controls.Add(this.main_simp_data_1);
            this.groupBox1.Controls.Add(this.main_reg_data_1);
            this.groupBox1.Controls.Add(this.main_search_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1133, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paieška";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "-";
            // 
            // main_simp_data_2
            // 
            this.main_simp_data_2.Checked = false;
            this.main_simp_data_2.CustomFormat = "yyyy-MM-dd";
            this.main_simp_data_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_simp_data_2.Location = new System.Drawing.Point(432, 79);
            this.main_simp_data_2.Margin = new System.Windows.Forms.Padding(4);
            this.main_simp_data_2.Name = "main_simp_data_2";
            this.main_simp_data_2.ShowCheckBox = true;
            this.main_simp_data_2.Size = new System.Drawing.Size(200, 26);
            this.main_simp_data_2.TabIndex = 10;
            this.main_simp_data_2.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(728, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kitų laukų paieška";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Simptomų pastebėjimo data";
            // 
            // main_search_button
            // 
            this.main_search_button.Location = new System.Drawing.Point(976, 44);
            this.main_search_button.Name = "main_search_button";
            this.main_search_button.Size = new System.Drawing.Size(108, 36);
            this.main_search_button.TabIndex = 7;
            this.main_search_button.Text = "Ieškoti";
            this.main_search_button.UseVisualStyleBackColor = true;
            this.main_search_button.Click += new System.EventHandler(this.main_search_button_Click);
            // 
            // main_reg_data_2
            // 
            this.main_reg_data_2.Checked = false;
            this.main_reg_data_2.CustomFormat = "yyyy-MM-dd";
            this.main_reg_data_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_reg_data_2.Location = new System.Drawing.Point(432, 28);
            this.main_reg_data_2.Name = "main_reg_data_2";
            this.main_reg_data_2.ShowCheckBox = true;
            this.main_reg_data_2.Size = new System.Drawing.Size(200, 26);
            this.main_reg_data_2.TabIndex = 5;
            this.main_reg_data_2.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // main_simp_data_1
            // 
            this.main_simp_data_1.Checked = false;
            this.main_simp_data_1.CustomFormat = "yyyy-MM-dd";
            this.main_simp_data_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_simp_data_1.Location = new System.Drawing.Point(211, 79);
            this.main_simp_data_1.Name = "main_simp_data_1";
            this.main_simp_data_1.ShowCheckBox = true;
            this.main_simp_data_1.Size = new System.Drawing.Size(200, 26);
            this.main_simp_data_1.TabIndex = 4;
            this.main_simp_data_1.Value = new System.DateTime(2022, 7, 20, 0, 0, 0, 0);
            // 
            // main_reg_data_1
            // 
            this.main_reg_data_1.Checked = false;
            this.main_reg_data_1.CustomFormat = "yyyy-MM-dd";
            this.main_reg_data_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_reg_data_1.Location = new System.Drawing.Point(211, 28);
            this.main_reg_data_1.Name = "main_reg_data_1";
            this.main_reg_data_1.ShowCheckBox = true;
            this.main_reg_data_1.Size = new System.Drawing.Size(200, 26);
            this.main_reg_data_1.TabIndex = 3;
            this.main_reg_data_1.Value = new System.DateTime(2022, 7, 16, 19, 28, 17, 0);
            // 
            // main_search_box
            // 
            this.main_search_box.Location = new System.Drawing.Point(659, 54);
            this.main_search_box.Name = "main_search_box";
            this.main_search_box.Size = new System.Drawing.Size(286, 26);
            this.main_search_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registravimo data";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1141, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vaistų siuntos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.siuntos_edit_button);
            this.groupBox3.Controls.Add(this.siuntos_new_button);
            this.groupBox3.Controls.Add(this.siuntos_list);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 136);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1133, 436);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pagrindinis ";
            // 
            // siuntos_edit_button
            // 
            this.siuntos_edit_button.Location = new System.Drawing.Point(36, 374);
            this.siuntos_edit_button.Margin = new System.Windows.Forms.Padding(4);
            this.siuntos_edit_button.Name = "siuntos_edit_button";
            this.siuntos_edit_button.Size = new System.Drawing.Size(134, 51);
            this.siuntos_edit_button.TabIndex = 4;
            this.siuntos_edit_button.Text = "Redaguoti pasirinktą";
            this.siuntos_edit_button.UseVisualStyleBackColor = true;
            this.siuntos_edit_button.Click += new System.EventHandler(this.siuntos_edit_button_Click);
            // 
            // siuntos_new_button
            // 
            this.siuntos_new_button.Location = new System.Drawing.Point(239, 374);
            this.siuntos_new_button.Margin = new System.Windows.Forms.Padding(4);
            this.siuntos_new_button.Name = "siuntos_new_button";
            this.siuntos_new_button.Size = new System.Drawing.Size(172, 49);
            this.siuntos_new_button.TabIndex = 6;
            this.siuntos_new_button.Text = "Naujas įrašas";
            this.siuntos_new_button.UseVisualStyleBackColor = true;
            this.siuntos_new_button.Click += new System.EventHandler(this.siuntos_new_button_Click);
            // 
            // siuntos_list
            // 
            this.siuntos_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.siuntos_list.AutoArrange = false;
            this.siuntos_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.vaistas_pavadinimas,
            this.vaistas_matas,
            this.gavimo_data,
            this.dokumentas,
            this.serija,
            this.gautas_kiekis,
            this.turimas_kiekis,
            this.galiojimo_data});
            this.siuntos_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.siuntos_list.FullRowSelect = true;
            this.siuntos_list.GridLines = true;
            listViewGroup3.Header = "id";
            listViewGroup3.Name = "listViewGroup1";
            listViewGroup4.Header = "id2";
            listViewGroup4.Name = "listViewGroup2";
            this.siuntos_list.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup3,
            listViewGroup4});
            this.siuntos_list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.siuntos_list.HideSelection = false;
            this.siuntos_list.Location = new System.Drawing.Point(4, 23);
            this.siuntos_list.Margin = new System.Windows.Forms.Padding(4);
            this.siuntos_list.MultiSelect = false;
            this.siuntos_list.Name = "siuntos_list";
            this.siuntos_list.Size = new System.Drawing.Size(1125, 343);
            this.siuntos_list.TabIndex = 0;
            this.siuntos_list.UseCompatibleStateImageBehavior = false;
            this.siuntos_list.View = System.Windows.Forms.View.Details;
            this.siuntos_list.DoubleClick += new System.EventHandler(this.siuntos_edit_button_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.siuntos_empty_show);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.siuntos_galiojimo_data_2);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.siuntos_search_button);
            this.groupBox4.Controls.Add(this.siuntos_gavimo_data_2);
            this.groupBox4.Controls.Add(this.siuntos_galiojimo_data_1);
            this.groupBox4.Controls.Add(this.siuntos_gavimo_data_1);
            this.groupBox4.Controls.Add(this.siuntos_search_box);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1133, 132);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paieška";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "-";
            // 
            // siuntos_galiojimo_data_2
            // 
            this.siuntos_galiojimo_data_2.Checked = false;
            this.siuntos_galiojimo_data_2.CustomFormat = "yyyy-MM-dd";
            this.siuntos_galiojimo_data_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.siuntos_galiojimo_data_2.Location = new System.Drawing.Point(432, 79);
            this.siuntos_galiojimo_data_2.Margin = new System.Windows.Forms.Padding(4);
            this.siuntos_galiojimo_data_2.Name = "siuntos_galiojimo_data_2";
            this.siuntos_galiojimo_data_2.ShowCheckBox = true;
            this.siuntos_galiojimo_data_2.Size = new System.Drawing.Size(200, 26);
            this.siuntos_galiojimo_data_2.TabIndex = 10;
            this.siuntos_galiojimo_data_2.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(728, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Kitų laukų paieška";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(128, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Galioja iki";
            // 
            // siuntos_search_button
            // 
            this.siuntos_search_button.Location = new System.Drawing.Point(976, 44);
            this.siuntos_search_button.Name = "siuntos_search_button";
            this.siuntos_search_button.Size = new System.Drawing.Size(108, 36);
            this.siuntos_search_button.TabIndex = 7;
            this.siuntos_search_button.Text = "Ieškoti";
            this.siuntos_search_button.UseVisualStyleBackColor = true;
            this.siuntos_search_button.Click += new System.EventHandler(this.siuntos_search_button_Click);
            // 
            // siuntos_gavimo_data_2
            // 
            this.siuntos_gavimo_data_2.Checked = false;
            this.siuntos_gavimo_data_2.CustomFormat = "yyyy-MM-dd";
            this.siuntos_gavimo_data_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.siuntos_gavimo_data_2.Location = new System.Drawing.Point(432, 28);
            this.siuntos_gavimo_data_2.Name = "siuntos_gavimo_data_2";
            this.siuntos_gavimo_data_2.ShowCheckBox = true;
            this.siuntos_gavimo_data_2.Size = new System.Drawing.Size(200, 26);
            this.siuntos_gavimo_data_2.TabIndex = 5;
            this.siuntos_gavimo_data_2.Value = new System.DateTime(2022, 7, 16, 0, 0, 0, 0);
            // 
            // siuntos_galiojimo_data_1
            // 
            this.siuntos_galiojimo_data_1.Checked = false;
            this.siuntos_galiojimo_data_1.CustomFormat = "yyyy-MM-dd";
            this.siuntos_galiojimo_data_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.siuntos_galiojimo_data_1.Location = new System.Drawing.Point(211, 79);
            this.siuntos_galiojimo_data_1.Name = "siuntos_galiojimo_data_1";
            this.siuntos_galiojimo_data_1.ShowCheckBox = true;
            this.siuntos_galiojimo_data_1.Size = new System.Drawing.Size(200, 26);
            this.siuntos_galiojimo_data_1.TabIndex = 4;
            this.siuntos_galiojimo_data_1.Value = new System.DateTime(2022, 7, 20, 0, 0, 0, 0);
            // 
            // siuntos_gavimo_data_1
            // 
            this.siuntos_gavimo_data_1.Checked = false;
            this.siuntos_gavimo_data_1.CustomFormat = "yyyy-MM-dd";
            this.siuntos_gavimo_data_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.siuntos_gavimo_data_1.Location = new System.Drawing.Point(211, 28);
            this.siuntos_gavimo_data_1.Name = "siuntos_gavimo_data_1";
            this.siuntos_gavimo_data_1.ShowCheckBox = true;
            this.siuntos_gavimo_data_1.Size = new System.Drawing.Size(200, 26);
            this.siuntos_gavimo_data_1.TabIndex = 3;
            this.siuntos_gavimo_data_1.Value = new System.DateTime(2022, 7, 17, 0, 0, 0, 0);
            // 
            // siuntos_search_box
            // 
            this.siuntos_search_box.Location = new System.Drawing.Point(659, 49);
            this.siuntos_search_box.Name = "siuntos_search_box";
            this.siuntos_search_box.Size = new System.Drawing.Size(286, 26);
            this.siuntos_search_box.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(105, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Gavimo data";
            // 
            // vaistas_pavadinimas
            // 
            this.vaistas_pavadinimas.Text = "Pavadinimas";
            this.vaistas_pavadinimas.Width = 150;
            // 
            // vaistas_matas
            // 
            this.vaistas_matas.Text = "Matas";
            // 
            // gavimo_data
            // 
            this.gavimo_data.Text = "Gavimo data";
            this.gavimo_data.Width = 150;
            // 
            // dokumentas
            // 
            this.dokumentas.Text = "Dokumento numeris";
            this.dokumentas.Width = 150;
            // 
            // serija
            // 
            this.serija.Text = "Serijos numeris";
            this.serija.Width = 150;
            // 
            // gautas_kiekis
            // 
            this.gautas_kiekis.Text = "Gautas kiekis";
            this.gautas_kiekis.Width = 150;
            // 
            // turimas_kiekis
            // 
            this.turimas_kiekis.Text = "Turimas kiekis";
            this.turimas_kiekis.Width = 150;
            // 
            // galiojimo_data
            // 
            this.galiojimo_data.Text = "Galioja iki";
            this.galiojimo_data.Width = 150;
            // 
            // siuntos_empty_show
            // 
            this.siuntos_empty_show.AutoSize = true;
            this.siuntos_empty_show.Checked = true;
            this.siuntos_empty_show.CheckState = System.Windows.Forms.CheckState.Checked;
            this.siuntos_empty_show.Location = new System.Drawing.Point(688, 83);
            this.siuntos_empty_show.Name = "siuntos_empty_show";
            this.siuntos_empty_show.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.siuntos_empty_show.Size = new System.Drawing.Size(225, 24);
            this.siuntos_empty_show.TabIndex = 14;
            this.siuntos_empty_show.Text = "Nerodyti pasibaigusių siuntų";
            this.siuntos_empty_show.UseVisualStyleBackColor = true;
            // 
            // Zurnalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 604);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.l);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Zurnalas";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Button zurnalas_new_button;
        private System.Windows.Forms.TextBox main_search_box;
        private System.Windows.Forms.DateTimePicker main_reg_data_2;
        private System.Windows.Forms.DateTimePicker main_simp_data_1;
        private System.Windows.Forms.DateTimePicker main_reg_data_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button main_search_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker main_simp_data_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button siuntos_edit_button;
        private System.Windows.Forms.Button siuntos_new_button;
        private System.Windows.Forms.ListView siuntos_list;
        private System.Windows.Forms.ColumnHeader vaistas_pavadinimas;
        private System.Windows.Forms.ColumnHeader vaistas_matas;
        private System.Windows.Forms.ColumnHeader gavimo_data;
        private System.Windows.Forms.ColumnHeader dokumentas;
        private System.Windows.Forms.ColumnHeader serija;
        private System.Windows.Forms.ColumnHeader gautas_kiekis;
        private System.Windows.Forms.ColumnHeader turimas_kiekis;
        private System.Windows.Forms.ColumnHeader galiojimo_data;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker siuntos_galiojimo_data_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button siuntos_search_button;
        private System.Windows.Forms.DateTimePicker siuntos_gavimo_data_2;
        private System.Windows.Forms.DateTimePicker siuntos_galiojimo_data_1;
        private System.Windows.Forms.DateTimePicker siuntos_gavimo_data_1;
        private System.Windows.Forms.TextBox siuntos_search_box;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox siuntos_empty_show;
    }
}

