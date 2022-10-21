using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countrys
{
    public partial class Edit : Form
    {
        private readonly Country country1;
        private readonly HttpClient _client;
        private readonly string _url;
        private readonly FromAPI _fromAPI;
        
        public Edit(Country _country)
        {
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Values";
            _fromAPI = new FromAPI(_client, _url);
            country1 = _country;
            InitializeComponent();
            lblID.Text = country1.Id.ToString();
            txtCode.Text = country1.Code;
            txtShort.Text = country1.ShortTitle;
            txtTitle.Text = country1.Title;
            txtURL.Text = country1.ImageURl;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CountryDto country = new CountryDto();
            country.Title = txtTitle.Text;
            country.Code = txtCode.Text;
            country.ShortTitle = txtShort.Text;
            country.ImageURl = txtURL.Text;

            string str = await _fromAPI.Put(int.Parse(lblID.Text),country);
            MessageBox.Show(str);
            

        }
    }
}
