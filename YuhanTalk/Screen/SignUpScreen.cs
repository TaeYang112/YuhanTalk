using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuhanTalk.Screen
{
    public partial class SignUpScreen : UserControl
    {
        private MainForm mainForm;
        public SignUpScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
