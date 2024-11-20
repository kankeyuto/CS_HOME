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

        TestTextBox _txetBox;

        KadaiButton _kadaiButton;

        KadaiTextBox _kadaiTextBox;

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

            _txetBox = new TestTextBox("テキストボックス1",150,400,500,100);
            Controls.Add(_txetBox) ;

            _kadaiTextBox = 
                new KadaiTextBox("テキストボックス2", 150, 450, 500, 100);
            Controls.Add(_kadaiTextBox) ;

            _kadaiButton = new KadaiButton(this,"入れ替える", 150, 500, 100, 100);
            Controls.Add(_kadaiButton) ;

            //Label label = new Label();
            //label.Location = new Point(30, 400);
            //label.Text = "ラベルです。";
            //Controls.Add(label);


        }
        public void LabelTextUpdate(string str)
        {
            _testlabel.LabelTextUpdate(str);
        }
        
        //public void TextBoxUpdate(string str)
        //{
        //    _txetBox.TextBoxUpdate(str);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}