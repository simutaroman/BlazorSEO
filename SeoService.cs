using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSEO
{
    public class SeoService
    {
        private string currentUri;

        public string CurrentUri { 
            get => currentUri;
            set
            {
                currentUri = value;
                OnChanged();
            } 
        }

        public event Action OnChanged;
    }
}
