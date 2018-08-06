using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace DivisasMVVM1.Model
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region Atributos
        private decimal dolares { get; set; }
        private decimal euros { get; set; }
        private decimal libras { get; set; }

        #endregion

        #region Propiedades

        public decimal Pesos { get; set; }

        public decimal Dolares
        {
            set
            {
                if (dolares != value)
                {
                    dolares = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dolares"));
                }
            }
            get
            {
                return dolares;
            }
        }

        public decimal Euros
        {
            set
            {
                if (euros != value)
                {
                    euros = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Euros"));
                }
            }
            get
            {
                return euros;
            }
        }
        public decimal Libras
        {
            set
            {
                if (libras != value)
                {
                    libras = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Libras"));
                }
            }
            get
            {
                return libras;
            }
        }
        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Comandos
        public ICommand ConvertCommand { get { return new RelayCommand(ConverdMony); } }


        private async void ConverdMony()
        {
            if (Pesos <= 0)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Debe ingresar un valor mayor a 0", "Aceptar");
                return;
            }
            Dolares = Pesos / 19.120M;
            Euros = Pesos / 23.60M;
            Libras = Pesos / 35.748M;
        } 
        #endregion
    }
}
