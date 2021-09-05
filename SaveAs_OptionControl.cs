using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class SaveAs_OptionControl : UserControl
    {
        public SaveAs_OptionControl()
        {
            InitializeComponent();
        }

        private void optionButton1_Click(object sender, EventArgs e)
        {
            optionButton1.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton1.ChangeColorMouseHC = false;
            optionButton2.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton4.BZBackColor = Color.White;
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            optionButton2.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton2.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.BZBackColor = Color.White;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            optionButton3.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton3.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.White;
            optionButton2.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton2.ChangeColorMouseHC = true;
            optionButton4.BZBackColor = Color.White;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void OptionButton6_Click(object sender, EventArgs e)
        {

        }

        private void OptionButton4_Click(object sender, EventArgs e)
        {
            optionButton4.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton4.ChangeColorMouseHC = false;
            optionButton2.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton1.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
        }

        private void SaveAs_OptionControl_Load(object sender, EventArgs e)
        {

        }
    }
}
