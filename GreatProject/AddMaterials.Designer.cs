﻿
namespace GreatProject
{
    partial class AddMaterials
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
            this.textBox_for_name = new System.Windows.Forms.TextBox();
            this.textBox_for_capacity = new System.Windows.Forms.TextBox();
            this.textBox_for_weight = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_for_sort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_for_name
            // 
            this.textBox_for_name.Location = new System.Drawing.Point(85, 58);
            this.textBox_for_name.Name = "textBox_for_name";
            this.textBox_for_name.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_name.TabIndex = 0;
            this.textBox_for_name.TextChanged += new System.EventHandler(this.textBox_for_name_TextChanged);
            // 
            // textBox_for_capacity
            // 
            this.textBox_for_capacity.Location = new System.Drawing.Point(85, 84);
            this.textBox_for_capacity.Name = "textBox_for_capacity";
            this.textBox_for_capacity.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_capacity.TabIndex = 2;
            this.textBox_for_capacity.TextChanged += new System.EventHandler(this.textBox_for_capacity_TextChanged);
            // 
            // textBox_for_weight
            // 
            this.textBox_for_weight.Location = new System.Drawing.Point(85, 110);
            this.textBox_for_weight.Name = "textBox_for_weight";
            this.textBox_for_weight.Size = new System.Drawing.Size(121, 20);
            this.textBox_for_weight.TabIndex = 3;
            this.textBox_for_weight.TextChanged += new System.EventHandler(this.textBox_for_weight_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "wood",
            "paint",
            "oil",
            "brick"});
            this.comboBox1.Location = new System.Drawing.Point(85, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(328, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 186);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_for_add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_for_home_Click);
            // 
            // button_for_sort
            // 
            this.button_for_sort.Location = new System.Drawing.Point(384, 219);
            this.button_for_sort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_for_sort.Name = "button_for_sort";
            this.button_for_sort.Size = new System.Drawing.Size(73, 24);
            this.button_for_sort.TabIndex = 12;
            this.button_for_sort.Text = "Sort";
            this.button_for_sort.UseVisualStyleBackColor = true;
            this.button_for_sort.Click += new System.EventHandler(this.button_for_sort_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 278);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 32);
            this.button3.TabIndex = 13;
            this.button3.Text = "Write in warehouse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_for_materials);
            // 
            // AddMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 406);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_for_sort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_for_weight);
            this.Controls.Add(this.textBox_for_capacity);
            this.Controls.Add(this.textBox_for_name);
            this.Name = "AddMaterials";
            this.Text = "AddMaterials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_for_name;
        private System.Windows.Forms.TextBox textBox_for_capacity;
        private System.Windows.Forms.TextBox textBox_for_weight;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_for_sort;
        private System.Windows.Forms.Button button3;
    }
}