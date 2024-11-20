﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    class TestButton : Button
    {
        Form1 _form1;

        
        public TestButton(Form1 form1,string strs,int x, int y,int width,int height)
        {
            _form1 = form1;

            Click += OnClick;

            Text = strs;
              
            Location = new Point(x, y); //表示させる　Location

            Size = new Size(width, height); //サイズ指定　Size

        }
        
        
        public void OnClick(object sender, EventArgs s)
        {
            string t =  _form1.ButtonLabelReplacement(Text);

            Text = t;

            _form1.LabelTextUpdate(Text);

        }

    }
}
