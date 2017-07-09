using System;
using System.Collections.Generic;

namespace airports_country.Model
{
    public class ServiceAeropuerto
    {
        IAirportService airportService;
        public ServiceAeropuerto(IAirportService _airportService)
        {
            airportService = _airportService;
        }
        public List<Aeropuerto> ObtenerAeropuertoByCountry(string _country)
        {
            return airportService.GetDataAsync(_country);
        }
    }
}
