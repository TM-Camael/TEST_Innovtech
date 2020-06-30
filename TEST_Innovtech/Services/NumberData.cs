// Classe permettant de récupérer les données du nombre modifié grâce au timer d'une page Razor à une autre

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEST_Innovtech.Services
{
    public class NumberData
    {
        private int _number;
        public int Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
                NotifyDataChanged();
            }
        }
        public event Action OnChange;
        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}
