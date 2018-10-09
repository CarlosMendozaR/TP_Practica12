using System;

namespace LibAutos
{
    public class Auto
    {
        #region Atributos
        private string nombre;
        private string modelo;
        private int kilometraje;
        private string transmision;
        private int precio;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Kilometraje { get => kilometraje; set => kilometraje = value; }
        public string Transmision
        {
            get => transmision;
            set
            {
                if (value=="A")
                {
                    transmision = "Automática";
                }
                else if(value=="S")
                {
                    transmision = "Standard";
                }
                else
                {
                    transmision = "Semi";
                }
            }
        }
        public int Precio { get => precio; set => precio = value; }
        #endregion

        #region Constructor
        public Auto(string nombre, string modelo, int kilometraje, string transmision, int precio)
        {
            Nombre = nombre;
            Modelo = modelo;
            Kilometraje = kilometraje;
            Transmision = transmision;
            Precio = precio;
        }
        #endregion
    }
}
