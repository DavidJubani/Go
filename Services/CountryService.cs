﻿using API_REST_SDA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace API_REST_SDA.Services
{
    public class CountryService
    {
        private const string serverUrl = " https://restcountries.com/v3.1";

        public async Task<List<Country>> GetAll()
        {
            try
            {
                var url = serverUrl + "/all";
                var httpClient = new HttpClient();
                var response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception("Error in getting data");
                }
            }

            

            catch { }
            return new List<Country>();
        }

       
    }

}