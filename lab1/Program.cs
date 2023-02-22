using System.Collections.Generic;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
class Persona
{
    public string nombre;
    public int edad;
    public Departamento departamento;


}
class Municipio
{
    public string nombre;
    public Departamento departamento;

}
class Departamento
{
    public string nombre;
    public List<Municipio> Municipios;

}
class Program
{
    public string nombre;

    Dictionary<string, Departamento> departamentos = new Dictionary<string, Departamento>();

    string[] nombresDepartamentos = { "Ahuachapan", "Santa Ana", "Chalatenango", "La Libertad", "San Salavdor", "Cuscatlan", "La Paz", "La Union", "Morazan", "San Miguel", " San Vicente", "Sonsonate", "Usulutan", "Cabanas",

}     private string[][] value =
{
        new string[] { "Ahuachapán", "Apaneca", "Atiquizaya", "Concepción de Ataco", "El Refugio", "Guaymango", "Jujutla", "San Francisco Menéndez" },
        new string[] { "Sensuntepeque", "Dolores", "Guacotecti", "Ilobasco", "Jutiapa", "San Isidro", "Tejutepeque", "Victoria" },
        new string[] { "Chalatenango", "Agua Caliente", "Arcatao", "Azacualpa", "Citalá", "Comalapa", "Concepción Quezaltepeque", "Dulce Nombre de María" },
        new string[] { "Cojutepeque", "Candelaria", "El Carmen", "El Rosario", "Monte San Juan", "Oratorio de Concepción", "San Bartolomé Perulapía", "San Rafael Cedros" },
        new string[] { "Santa Tecla", "Antiguo Cuscatlán", "Chiltiupán", "Ciudad Arce", "Colón", "Comasagua", "Huizúcar", "Jayaque" },
        new string[] { "Zacatecoluca", "Cuyultitán", "El Rosario", "Jerusalén", "Mercedes La Ceiba", "Olocuilta", "Paraíso de Osorio", "San Juan Nonualco" },
        new string[] { "La Unión", "Anamorós", "Bolívar", "Concepción de Oriente", "Conchagua", "El Carmen", "El Sauce", "Intipucá" },
        new string[] { "San Francisco Gotera", "Arambala", "Corinto", "Delicias de Concepción", "El Divisadero", "El Rosario", "Gualococti", "Joateca" },
        new string[] { "San Miguel", "Carolina", "Chapeltique", "Chinameca", "Ciudad Barrios", "Comacarán", "El Tránsito", "Lolotique" },
        new string[] { "San Salvador", "Aguilares", "Apopa", "Ayutuxtepeque", "Cuscatancingo", "Delgado", "Ilopango", "Mejicanos" },
};

    string[][] nombresMunicipios = Value;

    public static string[][] Value => Value;



}
