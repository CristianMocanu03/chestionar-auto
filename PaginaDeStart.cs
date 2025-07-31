using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chestionar_auto
{
    public partial class PaginaDeStart : Form
    {
       
        public PaginaDeStart()
        {
            InitializeComponent();
            
        }

        public void btnStartExamen_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            var minutes = 26;
            var start = DateTime.UtcNow; 
            form1.endTime = start.AddMinutes(minutes); 
            form1.tmrCountdown.Enabled = true;


        }
    }
}




