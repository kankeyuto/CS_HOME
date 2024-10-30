using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_Form
{
    class TestButton : Button
    {

        
        public TestButton()
        {
            Click += OnClick;
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("あいうえお");
        }

    }
}
