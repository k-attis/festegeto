using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace festegeto
{
    public partial class Form2 : Form
    {
        public String szoveg;

        public Form2(String pszoveg)
        {
            InitializeComponent();

            szoveg = pszoveg;

            Text = szoveg;
        }
    }
}
