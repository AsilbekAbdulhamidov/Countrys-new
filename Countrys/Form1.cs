using Newtonsoft.Json;
using Newtonsoft;
namespace Countrys
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _client;
        private readonly string _url;   
        private readonly FromAPI _fromAPI;
        public Form1()
        {
            _client = new HttpClient();
            _url = "https://localhost:7276/api/Values";
            _fromAPI = new FromAPI(_client,_url);
            InitializeComponent();
            
           
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            var res = await _fromAPI.Get();

            foreach (var item in res)
            {
                addPanel(item);
            }
           
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void addPanel(Country country)
        {
            CountryyC usr = new CountryyC(country);
            usr.Dock = DockStyle.Top;
            panel1.Controls.Add(usr);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Post().Show();
        }
    }
}