using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngRus
{
    
    public partial class FullStat : Form
    {
        mainForm f;
        public FullStat(mainForm f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void FullStat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            f.Show();
        }

        private void FullStat_Load(object sender, EventArgs e)
        {
            countEngWord.Text = mainForm.countEngWord.ToString();
            possitiveWord.Text = testOnlineForm.possitiveCount.ToString();
            negativeWord.Text = testOnlineForm.negativeCount.ToString();
        }
    }
}
