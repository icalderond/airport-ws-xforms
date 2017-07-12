using System;
using System.Collections.Generic;

namespace airports_country.Model
{
    public class ServiceAeropuerto
    {
        IAirportService airportService;
        public event EventHandler<GenericEventArgs<Aeropuerto>> ObtenerAeropuertoByCountry_Completed;
        public ServiceAeropuerto(IAirportService _airportService)
        {
            airportService = _airportService;
            airportService.GetData_Completed += (s, a) =>
                  ObtenerAeropuertoByCountry_Completed?.Invoke(this, new GenericEventArgs<Aeropuerto>(a.Result))
        }

        public void ObtenerAeropuertoByCountry(string _country)
        {
            airportService.GetDataAsync(_country);
        }
    }
}