using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OWKmusic_assistant
{
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private static FormInfo instance = null;
        public static FormInfo Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed){ instance = new FormInfo(); }  
                return instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }


    }
}
