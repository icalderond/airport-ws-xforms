using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using airports_country.Model;

namespace airports_country.iOS.Service
{
    public class SoapService : IAirportService
    {
        const string urlflag = "http://www.geognos.com/api/en/countries/flag/{FLAG_CODE}.png";
        readonly WSAeropuerto.airport service;
        public SoapService()
        {
            service = new WSAeropuerto.airport();
        }
        public List<Aeropuerto> GetDataAsync(string _country)
        {
            var result = service.GetAirportInformationByCountry(_country);
            XDocument doc = XDocument.Parse(result);

            var lista = (from item in doc.Descendants("NewDataSet").Descendants("Table")
                         select new Aeropuerto()
                         {
                             Name = item.Element("CityOrAirportName").Value,
                             Country = item.Element("Country").Value,
                             AirportCode = item.Element("AirportCode").Value,
                             RunwayElevationFeet = item.Element("RunwayElevationFeet").Value,
                             UrlFlagCountry = urlflag.Replace("{FLAG_CODE}", item.Element("CountryAbbrviation").Value)
                         })
               .ToList();

            return lista;
        }
    }
}