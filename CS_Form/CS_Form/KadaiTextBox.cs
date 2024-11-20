using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CS_Form
{
    internal class KadaiTextBox : TextBox
    {
        public KadaiTextBox(string strs, int x, int y, int width, int height)
        {

            Text = strs;

            Location = new Point(x, y); //表示させる　Location

            Size = new Size(width, height); //サイズ指定　Size


        }
    }
}
