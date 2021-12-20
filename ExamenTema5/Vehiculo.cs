using System.Collections.ObjectModel;

class Vehiculo
{
    private string _descripcion;

    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    private int _precio;

    public int Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    private string _tipo;

    public string Tipo
    {
        get { return _tipo; }
        set { _tipo = value; }
    }

    private string _foto;

    public string Foto
    {
        get { return _foto; }
        set { _foto = value; }
    }

    private bool _reservado;

    public bool Reservado
    {
        get { return _reservado; }
        set { _reservado = value; }
    }

    public static ObservableCollection<Vehiculo> GetSamples()
    {
        ObservableCollection<Vehiculo> lista = new ObservableCollection<Vehiculo>();
        lista.Add(new Vehiculo() { Descripcion = "Tesla Model S 75", Precio = 87400, Tipo = "Coche", Foto = "/assets/tesla.jpg", Reservado=false });
        lista.Add(new Vehiculo() { Descripcion = "Audi e-tron 50", Precio = 68000, Tipo = "Coche", Foto = "/assets/audi.jpeg", Reservado = true });
        lista.Add(new Vehiculo() { Descripcion = "Triumph Bonneville T120", Precio = 12990, Tipo = "Moto", Foto = "/assets/triumph.jpg", Reservado = false });
        return lista;
    }

    public static ObservableCollection<string> GetTipos()
    {
        ObservableCollection<string> lista = new ObservableCollection<string>();
        lista.Add("Coche");
        lista.Add("Moto");

        return lista;
    }

}

