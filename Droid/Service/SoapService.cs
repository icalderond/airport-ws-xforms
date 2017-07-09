using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using airports_country.Model;

namespace airports_country.Droid.Service
{
    public class SoapService : IAirportService
    {
        WSAeropuerto.airport service;
        public List<Aeropuerto> GetDataAsync(string _country)
        {
            var result = service.GetAirportInformationByCountry(_country);
            var lista = from item in result.ToList()
                        select item;
            return new List<Aeropuerto>();
        }
    }
}
