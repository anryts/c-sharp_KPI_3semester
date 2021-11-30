﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatProject
{
   

    public partial class OurWarehouse : Form
    {        
      //static  warehouse_for_food mini_dream_food = new warehouse_for_food();

      

        string type_item;
        public OurWarehouse()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void go_to_exit_form_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                ForUpdates temp = new ForUpdates();
                temp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            if(type_item == "Food")
            {
               
                AddFood temp = new AddFood();
                temp.Show();
            }
            else if(type_item == "Materials")
            {
                AddMaterials temp = new AddMaterials();
                temp.Show();
            }
            else
            {
                ForUpdates temp = new ForUpdates();
                temp.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            type_item = comboBox1.SelectedItem.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {         
            // The password character is an asterisk.
            textBox1.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            textBox1.MaxLength = 14;
        }

        private void button_for_Chief_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "0123456789")
            {
                MessageBox.Show("Welcome!");
                ChiefForm temp = new();
                temp.Show();
            }
        }
    }

    static class Date
    {
        static warehouse_for_food mini_dream_warehouse = new();

      // static 
        static public warehouse_for_food Property_for_warehouse { get { return mini_dream_warehouse; } }

        static public Dictionary<string, DateTime> Property_for_dictionary
        {
            get { return dictionary_for_logs; }
        }

        

        static Dictionary<string, DateTime> dictionary_for_logs = new();
    }
}
