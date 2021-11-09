using System;
using System.Runtime.Serialization;

namespace TPFinal

/*Cliente: Debe contener mínimamente nacionalidad,provincia, dirección y teléfono de contacto. 
    Existen clientes particulares que tendrán dni, apellido y nombre, y corporativo que 
ademas del apellido, nombre y dni del viajante tiene cuit y razón social de la empresa*/
{
    [Flags] public enum Provincias
    {
       
        [EnumMember(Value = "Buenos Aires")]
        bsas = 0,
        Catamarca = 1,
        Chaco = 2,
        Chubut = 3,
        Córdoba = 4,
        Corrientes = 5,
        [EnumMember(Value = "Entre Ríos")]
        EntreRios = 6,
        Formosa = 7,
        Jujuy = 8,
        [EnumMember(Value = "La Pampa")]
        LaPampa = 9,
        [EnumMember(Value = "La Rioja")]
        LaRioja = 10,
        Mendoza = 11,
        Misiones = 12,
        Neuquén = 13,
        [EnumMember(Value = "Río Negro")]
        RíoNegro = 14,
        Salta = 15,
        [EnumMember(Value = "San Juan")]
        SanJuan = 16,
        [EnumMember(Value = "San Luis")]
        SanLuis = 17,
        [EnumMember(Value = "Santa Cruz")]
        SantaCruz = 18,
        [EnumMember(Value = "Santa Fe")]
        SantaFe = 19,
        [EnumMember(Value = "Santiago del Estero")]
        SantiagodelEstero = 20,
        [EnumMember(Value = "Tierra del Fuego Antártida e Islas del Atlántico Sur,")]
        TierradelFuego = 21,
        Tucumán = 22
    }
    public class Cliente
    {
        private string _nacionalidad;
        private string _provincia;
        private string _direccion;
        private long _telefono;
        
        //Constructor vacio/por defecto
        public Cliente(){}

        //Constructor para probar enum
        public Cliente(string nacionalidad)
        {
            _nacionalidad = nacionalidad;
        }

        public string Nacionalidad
        {
            get => _nacionalidad;
            set => _nacionalidad = value;
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }
            set
            {
                if (Enum.IsDefined(typeof(Provincias),value))
                {
                    _provincia = value;
                }
            }
        }

        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }

        public long Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }
    }
}