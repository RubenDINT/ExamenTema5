using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenTema5
{
    class VehiculoVM : ObservableObject
    {
        private ObservableCollection<Vehiculo> listaVehículos;

        public ObservableCollection<Vehiculo> ListaVehiculos
        {
            get { return listaVehículos; }
            set { SetProperty(ref listaVehículos, value); }
        }

        private ObservableCollection<string> tipos;

        public ObservableCollection<string> Tipos
        {
            get { return tipos; }
            set { SetProperty(ref tipos, value); }
        }

        private Vehiculo vehiculoActual;

        public Vehiculo VehiculoActual
        {
            get { return vehiculoActual; }
            set { SetProperty(ref vehiculoActual, value); }
        }

        public VehiculoVM()
        {
            ListaVehiculos = Vehiculo.GetSamples();
            Tipos = Vehiculo.GetTipos();
        }

        public void EliminarSeleccion()
        {
            ListaVehiculos.Remove(VehiculoActual);

        }
    }
}
