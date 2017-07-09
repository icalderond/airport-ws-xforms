using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace airports_country.Model
{
    public interface IAirportService
    {
        List<Aeropuerto> GetDataAsync(string _country);
    }
}
