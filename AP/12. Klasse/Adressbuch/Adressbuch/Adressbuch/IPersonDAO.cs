using System.Collections.Generic;

namespace Adressbuch
{
    interface IPersonDAO
    {
        List<Person> PList { get; }

        void LoadData();
        void NewData();
        void SaveData();
    }
}