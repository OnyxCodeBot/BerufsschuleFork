using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Adressbuch
{
    [Serializable()]
    public class Person : ISerializable
    {
        private string name;
        private string vorname;
        private string strasse;
        private string hausnummer;
        private string plz;
        private string ort;
        private string telefon;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public string Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Plz { get => plz; set => plz = value; }
        public string Ort { get => ort; set => ort = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }

        public Person()
        {
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = info.GetString("name");
            Vorname = info.GetString("vorname");
            Strasse = info.GetString("strasse");
            Hausnummer = info.GetString("hausnummer");
            Plz = info.GetString("plz");
            Ort = info.GetString("ort");
            Telefon = info.GetString("telefon");
            Email = info.GetString("email");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("name", Name, typeof(string));
            info.AddValue("vorname", Vorname, typeof(string));
            info.AddValue("strasse", Strasse, typeof(string));
            info.AddValue("hausnummer", Hausnummer, typeof(string));
            info.AddValue("plz", Plz, typeof(string));
            info.AddValue("ort", Ort, typeof(string));
            info.AddValue("telefon", Telefon, typeof(string));
            info.AddValue("email", Email, typeof(string));
        }
    }
}
