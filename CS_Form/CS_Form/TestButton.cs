using System;
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

        
        public TestButton(int id,int x, int y,int width,int height)
        {
            Click += OnClick;
            
            Text = id.ToString();
              
            Location = new Point(x, y); //表示させる　Location

            Size = new Size(width, height); //サイズ指定　Size

              

            
            

            
        }
        
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(Text);
        }

    }
}
