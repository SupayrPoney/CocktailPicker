using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CocktailPicker.Model
{
    public class AlcoholType : INotifyPropertyChanged
    {

        public String AlcoholName { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
