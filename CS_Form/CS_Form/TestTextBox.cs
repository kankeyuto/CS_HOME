﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CS_Form
{
    class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {

            Text = str;

            Location = new Point(x, y); //表示させる　Location

            Size = new Size(width, height); //サイズ指定　Size


        }
        //public void TextBoxUpdate(string str)
        //{
        //    Text = str;
        //}
    }



}