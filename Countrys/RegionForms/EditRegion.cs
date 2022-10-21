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
    public partial class EditRegion : Form
    {
        private readonly int _idCon;
        private readonly string _url;
        private readonly FromAPI _fromAPI;
        private readonly HttpClient _client;
        private readonly Region _region;
       

        public EditRegion(int id, Region region)
        {
            _region = region;
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Region";
            _fromAPI = new FromAPI(_client, _url);
            _idCon = id;
            lblIDCon.Text = _idCon.ToString();
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            RegionDto dto = new RegionDto();
            dto.Title = txtTitle.Text;
            dto.Code = txtShort.Text;
            dto.CountryId = _idCon;

            string str = await _fromAPI.PutRegion(_region.Id, dto);
            MessageBox.Show(str);

        }
    }
}
