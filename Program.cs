using API_REST_SDA.Models;
using API_REST_SDA.Services;

var countryService = new CountryService();

var countries = await countryService.GetAll();

countries.ForEach(country =>
{
    Console.WriteLine(country.name.common + "    " + country.name.official + "   ");
});

