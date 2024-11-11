using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinButNum
{
    public partial class ClickButton : Button
    {

        int mClicks;
        public int Clicks
        {
            get { return mClicks; }
        }


    }
}
