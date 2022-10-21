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
    public partial class Post : Form
    {
        
        private readonly HttpClient _client;
        private readonly string _url;
        private readonly FromAPI _fromAPI;


        public Post()
        {
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Values";
            _fromAPI = new FromAPI(_client, _url);
           
            InitializeComponent();
            
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CountryDto country = new CountryDto();
            country.Title = txtTitle.Text;
            country.Code = txtShort.Text;
            country.ShortTitle = txtCode.Text;
            country.ImageURl = txtURL.Text;

            string str = await _fromAPI.Post(country);
            MessageBox.Show(str);
            this.Close();

        }



    }
}
