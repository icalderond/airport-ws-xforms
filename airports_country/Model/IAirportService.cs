using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace airports_country.Model
{
    public interface IAirportService
    {
        event EventHandler<GenericEventArgs<Aeropuerto>> GetData_Completed;
        void GetDataAsync(string _country);
    }
}
