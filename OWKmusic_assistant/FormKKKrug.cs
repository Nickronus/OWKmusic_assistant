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
    public partial class FormKKKrug : Form
    {
        public FormKKKrug()
        {
            InitializeComponent();
        }

        private static FormKKKrug intstance;
        public static FormKKKrug Instance
        {
            get
            {
                if (intstance == null || intstance.IsDisposed) intstance = new FormKKKrug();
                return intstance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
