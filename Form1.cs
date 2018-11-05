﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace security
{
    
    
    public partial class securitytech : Form
    {
        public securitytech()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text); 
            string message = textBox2.Text ;   
            textBox3.Text = ceasercipher.encrypt(message,x); //pass the data to output text 
            
        }
        
        //************   close the window   ********************************8
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        //**********   clear all data ****************************
        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();           
            textBox2.Clear();
            textBox3.Clear();
        }

       }
}

public class ceasercipher
{
    public static string encrypt(string text ,int key)
    {
        string result = " ";
        
        for (int i=0;i<text.Length;i++)
        {
            if(char.IsUpper(text[i]))
            {
                 
                result +=Convert.ToChar(Convert.ToInt32(text[i]+key-65) %26 +65);
            }
            else
            {
                result += Convert.ToChar(Convert.ToInt32(text[i] + key - 97) % 26 + 97);
            }

        } return result;
    }
}

    
