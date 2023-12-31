﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Command;
using WpfApp3.Model;
using WpfApp3.Views;





namespace WpfApp16.ViewModels
{
    public class viewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> markaNames { get; set; }
        public ObservableCollection<string> modelNames { get; set; } = new ObservableCollection<string>();

        private string selectedMarka;
        public string SelectedMarka
        {
            get { return selectedMarka; }
            set
            {
                if (selectedMarka != value)
                {
                    selectedMarka = value;
                    OnPropertyChanged(nameof(SelectedMarka));
                    UpdateModelNames();
                }
            }
        }
        public string SelectedModel { get; set; }

        public viewModel()
        {


        markaNames = new ObservableCollection<string>
            {
                "Mercedes",
                "BMW",
                "Toyota",
                "Wolksvagen",
                "dodge",
                "vaz",
                "lada",
                "Abarth"
            };

            modelNames = new ObservableCollection<string>();

    }

    private void UpdateModelNames()
        {
            
            modelNames.Clear();
            if (SelectedMarka == "Mercedes")
            {
                modelNames.Add("E320");
                modelNames.Add("S300");
                modelNames.Add("G-63");

            }
            else if (SelectedMarka == "BMW")
            {
                modelNames.Add("e60");
                modelNames.Add("e36");

            }

            else if (SelectedMarka == "Toyota")
            {
                modelNames.Add("camry");
                modelNames.Add("prius");

            }

            else if (SelectedMarka == "Wolksvagen")
            {
                modelNames.Add("tuareg");
            }

            else if (SelectedMarka == "dodge")
            {
                modelNames.Add("challenger");
            }

            else if (SelectedMarka == "vaz")
            {
                modelNames.Add("2107");
            }

            else if (SelectedMarka == "lada")
            {
                modelNames.Add("priora");
            }

            else if (SelectedMarka == "Abarth")
            {
                modelNames.Add("595");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}