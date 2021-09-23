using System;
using System.Collections.Generic;
using System.Text;
using tryHeaderFoder;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;

namespace Trybinding.Model
{
    class Person : INotifyPropertyChanged
    {


        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnpropertyChanged("Name");
                OnpropertyChanged("Fullname");


            }
        }

        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set
            {
                lastname = value;

                OnpropertyChanged("Lastname");
                OnpropertyChanged("Fullname");

            }
        }

        private string fullname;
        public string Fullname
        {
            get { return name + " " +  lastname; }
            set
            {
                fullname = value;


                OnpropertyChanged("Fullname");

            }
        }

        // det her er en konstructor
        public Person()
        {
            if (DesignMode.IsDesignModeEnabled)
            {

                this.Name = "Jimmi";
                this.Lastname = "Grønbech";

            }

        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void OnpropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
