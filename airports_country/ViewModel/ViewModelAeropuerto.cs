using System;
using System.Collections.ObjectModel;
using airports_country;
using airports_country.Model;

namespace airports_country.ViewModel
{
    public class ViewModelAeropuerto : NotificationEnabledObject
    {

        public ViewModelAeropuerto()
        {
            App.servicio.ObtenerAeropuertoByCountry_Completed += (s, a) =>
            {
                ListaAeropuerto = new ObservableCollection<Aeropuerto>(a.Result);

            };
            App.servicio.ObtenerAeropuertoByCountry("puerto rico");
        }
        private ObservableCollection<Aeropuerto> _listaAeropuerto;
        public ObservableCollection<Aeropuerto> ListaAeropuerto
        {
            get { return _listaAeropuerto; }
            set
            {
                _listaAeropuerto = value;
                OnPropertyChanged();
            }
        }
    }
}