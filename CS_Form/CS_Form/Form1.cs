using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testlabel;

        TestTextBox _textBox;

        public Form1()
        {
            InitializeComponent();

             string[] strs = 
            {
                "あか",
                "あお",
                "きいろ",
                "みどり",
                "くろ",
                "しろ",
                "ちゃいろ",
                "ぴんく",
                "むらさき",
                "きみどり",
            };



            for(int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(this, strs[i],(i%5) * 100,(i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            _testlabel =
                new TestLabel("ラベルです。", 10, 300,100, 500);
            Controls.Add(_testlabel) ;

            _textBox = new TestTextBox("テキストボックス1",150,400,500,100);
            Controls.Add(_textBox) ;

            

            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです。";
            //Controls.Add(label);


        }
        public void LabelTextUpdate(string str)
        {
            _testlabel.LabelTextUpdate(str);
        }
        
        public string ButtonLabelReplacement(string str)
        {
            string s = _textBox.ButtonLabelReplacement(str);

            return s;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}