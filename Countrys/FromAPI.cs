using Countrys.RegionForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countrys
{
    public class FromAPI
    {
        private readonly HttpClient _client;
        private readonly string _url;
        public FromAPI(HttpClient httpClient, string url)
        {
            _client = httpClient;
            _url = url; 
        }

        public async Task<List<Country>> Get()
        {
            var response = await _client.GetAsync(_url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var res = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Country>>(json);
                return res;
            }

            else
            {
                MessageBox.Show(response.ReasonPhrase);
                return null;
            }
        }

        public async Task<string> Delete(int id)
        {
            var response =  await _client.DeleteAsync(_url +"/"+id.ToString());
            
            return response.ReasonPhrase;
            
        }

        public async Task<string> Put(int id, CountryDto country)
        {
            var json = JsonConvert.SerializeObject(country);
            var data = new StringContent(json, Encoding.UTF8 , "application/json");
            var response = await _client.PutAsync(_url +"/"+id.ToString(), data);

            return response.ReasonPhrase;
        }

        public async  Task<string> Post (CountryDto country)
        {
            var json = JsonConvert.SerializeObject(country);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_url , data);

            return response.ReasonPhrase;
        }

        //Region
        public async Task<string> DeleteRegion(int id)
        {
            var response = await _client.DeleteAsync(_url + "/" + id.ToString());

            return response.ReasonPhrase;

        }

        public async Task<string> PostRegion(RegionDto reg)
        {
            var json = JsonConvert.SerializeObject(reg);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(_url, data);

            return response.ReasonPhrase;
        }


    }
}
