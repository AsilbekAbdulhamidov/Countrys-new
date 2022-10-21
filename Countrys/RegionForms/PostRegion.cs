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
    public partial class PostRegion : Form
    {
        private readonly int _id;
        private readonly string _url;
        private readonly FromAPI _fromAPI;
        private readonly HttpClient _client;
        public PostRegion(int id)
        {
            _client= new HttpClient();
            _url = "https://localhost:7276/api/Region";
            _fromAPI = new FromAPI(_client, _url);
            _id = id;
            InitializeComponent();
            lblIDCon.Text = _id.ToString();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RegionDto dto = new RegionDto();
            dto.Title = txtTitle.Text;
            dto.Code = txtShort.Text;
            dto.CountryId = _id;

            string str = await _fromAPI.PostRegion(dto);
            MessageBox.Show(str);


        }
    }
}
