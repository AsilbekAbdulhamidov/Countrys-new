using Countrys.RegionForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countrys
{
    public partial class OneCountry : Form
    {
        private readonly Country _country;
        public OneCountry(Country country)
        {
            _country=country;
            InitializeComponent();
            lblCode.Text = _country.Code;
            lblCountry.Text = _country.Title;
            lblSHort.Text = _country.ShortTitle;
            pictureBox1.ImageLocation = _country.ImageURl;
            

            foreach (var item in _country.Regions)
            {
                addPanel(item,item.Id);
            }
        }

        private void addPanel(Region region, int id)
        {
           
            RegionCon usr = new RegionCon(region, id);
            usr.Dock = DockStyle.Top;
            pnl1.Controls.Add(usr);
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            new PostRegion(_country.Id).Show();
        }
    }
}
