using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using SZTGUI_MintaZH.Logic;
using SZTGUI_MintaZH.Model;

namespace SZTGUI_MintaZH.ViewModel
{
    public class MainWindowViewModel
    {
        private VersenyzoLogic logic;
        private Versenyzo selectedVersenyzo;

        public ObservableCollection<Versenyzo> Versenyzok { get; set; }

        public Versenyzo SelectedVersenyzo 
        { 
            get => selectedVersenyzo;
            set
            {
                selectedVersenyzo = value;
                (EditVersenyzo as RelayCommand).NotifyCanExecuteChanged();
                (DeleteVersenyzo as RelayCommand).NotifyCanExecuteChanged();
            }
        }

        public ICommand CreateVersenyzo { get; set; }
        public ICommand EditVersenyzo { get; set; }
        public ICommand DeleteVersenyzo { get; set; }

        public MainWindowViewModel()
        {
            logic = new VersenyzoLogic();
            Versenyzok = new ObservableCollection<Versenyzo>();
            CreateVersenyzo = new RelayCommand(() => AddVersenyzo());
            EditVersenyzo = new RelayCommand(() => this.logic.EditVersenyzo(SelectedVersenyzo), () => SelectedVersenyzo != null);
            DeleteVersenyzo = new RelayCommand(() => this.logic.DeleteVersenyzo(Versenyzok, SelectedVersenyzo), () => SelectedVersenyzo != null);
        }

        private void AddVersenyzo()
        {
            try
            {
                this.logic.AddVersenyzo(Versenyzok);
            } catch(IdUtkozesException)
            {
                MessageBox.Show("ID utkozes!");
            }
        }
    }
}
