using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Runtime.CompilerServices;

namespace ViewModel
{
    public class Class1 : INotifyPropertyChanged
    {

        private ObservableCollection<Player> _player;
        private Player _selectedPlayer;
        //private string NamePlayer;
      
            public Player SelectedPlayer
        {
            get { return _selectedPlayer; }
            set { _selectedPlayer = value; }
        }
        public ObservableCollection<Player> Players
        {
            get { return _player; }
            set
            {
                _player = value;
            }
        }



        public Player SelectedStudent
        {
            get { return _selectedPlayer; }
            set { _selectedPlayer = value; }
        }

       public string NamePlayer { get; set; }
       /* {
            get { return NamePlayer; }
            set { NamePlayer = value; }
        }*/

        public RelayCommand AddNamePlayerCommand { get; set; }
        public Class1()
        {
            Players = new ObservableCollection<Player>();
            AddNamePlayerCommand = new RelayCommand(AddPlayerName);
            
        }

        public void AddPlayerName()
        {
            if (NamePlayer != null)
            {
                Player player = new Player
                {
                    Name = NamePlayer,
                    

                };
                Players.Add(player);

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
    }
}
