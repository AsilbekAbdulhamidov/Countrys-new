using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countrys.RegionForms
{
    public partial class RegionCon : UserControl
    {
        private readonly Region _region;
        private readonly HttpClient _client;
        private readonly string _url;
        private readonly FromAPI _fromAPI;
        private readonly int conunrtyId;


        public RegionCon(Region region, int id)
        {
            conunrtyId = id;
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Region";
            _fromAPI = new FromAPI(_client, _url);
            InitializeComponent();
            _region = region;
            label1.Text = _region.Title.ToUpper();


        }

        private void panel_clik(object sender, EventArgs e)
        {

        }

        private void Clik_edit(object sender, EventArgs e)
        {
            new EditRegion(conunrtyId, _region).Show();
        }

        private async void clik_delete(object sender, EventArgs e)
        {
            MessageBox.Show("Rosdan ham " + _region.Title.ToUpper() + "ni o'chirmoqchimisiz", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string str = await _fromAPI.DeleteRegion(_region.Id);
            MessageBox.Show(str);

        }
    }
}
