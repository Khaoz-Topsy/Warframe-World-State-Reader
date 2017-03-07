using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarframeWorldStateReadSave.Data.Repositories;

namespace WarframeWorldStateReadSave
{
    public partial class WarframeWorldStateForm : Form
    {
        public WarframeWorldStateForm()
        {
            InitializeComponent();
        }

        private void BtnReadData_Click(object sender, EventArgs e)
        {
            WarframeRepository WarRepo = new WarframeRepository();

            //WarframeWorldStateData WorldState = WarRepo.getAllData();

            //richDisplay.Text = WorldState.ToString();

            richDisplay.Text = WarRepo.getAllDataFormatted();
        }
    }
}
