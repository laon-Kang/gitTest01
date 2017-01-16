using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JenKinsTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sample_Test()
        {
            int i;
            int number = 0; 
            for( i = 0; i < 10; i++)
            {
                number += i; 
            }
        }
    }
}
