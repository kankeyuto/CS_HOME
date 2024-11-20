using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    class KadaiButton : Button
    {

        Form1 _form1;

        public KadaiButton(Form1 form1,string strs, int a, int b, int width, int height)
        {
            _form1 = form1;

            Click += OnClick;

            Text = strs;

            Location = new Point(a, b); //表示させる　Location

            Size = new Size(width, height); //サイズ指定　Size


        }

        public void OnClick(object sender, EventArgs s)
        {
            //_form1.LabelTextUpdate(Text);
            //string temp = _textBox;
            //Text = 
            
        }
    }
}
