using JoesAutoSalesApp.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JoesAutoSalesApp.Pages
{
    public partial class Inventory 
    {
        private readonly HttpClient client = new HttpClient();

        [Inject]
        private IConfiguration config { get; set; }

        public List<InventoryItem> InventoryList { get; set; }

        public string ErrorMessage { get; set; }

        public bool HideError { get; set; }

        public Inventory()
        {
            InventoryList = new List<InventoryItem>();
            HideError = true;
        }
        
        public async Task LoadData()
        {            
            string InventoryAPI = Environment.GetEnvironmentVariable("InventoryAPI");
            if(InventoryAPI == null)
            {
                InventoryList.Clear();
                ErrorMessage = "Environment Variable for Inventory API is not available.";
                HideError = false;
                return;
            }

            string InventoryURL = string.Empty;
            HideError = true;
            try
            {
                InventoryURL = "http://" + InventoryAPI + "/" + config.GetValue<string>("InventoryEndpoint");
                HttpResponseMessage ResponseMessage  = await client.GetAsync(InventoryURL);
                var responsestring = ResponseMessage.Content.ReadAsStringAsync();                                
                InventoryList = JsonConvert.DeserializeObject<List<InventoryItem>>(responsestring.Result);

                if(InventoryList == null)
                {
                    InventoryList = new List<InventoryItem>();
                    ErrorMessage = "The Inventroy List is null.";
                    HideError = false;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = "ERROR: " + ex.Message + "URL " + InventoryURL;
                HideError = false;
                InventoryList.Clear();                    
            }
            
        }
    }
}
