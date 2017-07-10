using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using airports_country.Model;

namespace airports_country.Droid.Service
{
    public class SoapService : IAirportService
    {
        WSAeropuerto.airport service;
        public SoapService()
        {
            service = new WSAeropuerto.airport();
        }
        public List<Aeropuerto> GetDataAsync(string _country)
        {
            var result = service.GetAirportInformationByCountry(_country);
            XDocument doc;

            using (var s = new StringReader(result))
                doc = XDocument.Load(result);

            XNamespace general = "http://www.webserviceX.NET";

            //XNameSpace n;
            var lista = from item in doc.Descendants(general + "newdataset")
                                        .Descendants(general + "table")
                        select item.Element(general + "cityorairportname").Value;
            return new List<Aeropuerto>();
        }
    }
}
