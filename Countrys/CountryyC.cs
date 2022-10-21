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
    public partial class CountryyC : UserControl
    {
        private readonly Country country1;
        private readonly HttpClient _client;
        private readonly string _url;
        private readonly FromAPI _fromAPI;
        public CountryyC(Country country)
        {
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Values";
            _fromAPI = new FromAPI(_client, _url);
            country1 = country;
            InitializeComponent();
            label1.Text = country1.Title.ToUpper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        
        }

        private void Click(object sender, EventArgs e)
        {
            new Form1().Close();
            new OneCountry(country1).Show();
        }

        private void Clik_edit(object sender, EventArgs e)
        {
            new Edit(country1).Show();
        }

        private async void Click_delete(object sender, EventArgs e)
        {
            MessageBox.Show("Rosdan ham "+country1.Title+"ni o'chirmoqchimisiz","Delete",MessageBoxButtons.OK, MessageBoxIcon.Information);
            string str = await _fromAPI.Delete(country1.Id);
            MessageBox.Show(str);

        }
    }
}
