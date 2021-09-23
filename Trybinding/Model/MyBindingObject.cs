using System;
using System.Collections.Generic;
using System.Text;
using tryHeaderFoder;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace Trybinding
{
    public class MyBindingObject /*: INotifyPropertyChanged*/  /*: BaseViewModel*/
    {
        public string Description { get; set; } = "Hvad sker der";

        public int SomeNumbers { get; set; } = 50;
        public double SomeDouble { get; set; } = 13.37d;
        public string ImagUrl { get; set; } = null;


        public string Tryheader { get; set; }
        public object HeaderModel { get; set; } = "Binding to header";
        public object FooterModel { get; set; } = "Binding to Footer";
        // det her er listvuew
        public List<object> ListItems { get; set; }


        //private string _enterteams;
        //public string Enterteams
        //{
        //    get => _enterteams;
        //    set
        //    {
        //        _enterteams = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Enterteams)));




        //    }

        //}

       
        //private string _teams = string.Empty;
        //public string Teams
        //{
        //    get => _teams;
        //    set => SetProberty(ref _teams, value);
        //}

    }
}
