using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FifaCareerManager.Management.Models;
using FifaCareerManager.Management.Managers;

namespace FifaCareerManager.Management.ViewModels
{
    public class YouthPlayerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<YouthPlayer> YouthPlayers { get; private set; }
        public PlayerManager<YouthPlayer> PlayerManager { get; }

        private YouthPlayer selectedPlayer;
        public YouthPlayer SelectedPlayer
        {
            get
            {
                return selectedPlayer;
            }
            set
            {
                selectedPlayer = value;
                NotifyPropertyChanged(nameof(SelectedPlayer));
            }
        }

        public YouthPlayerViewModel()
        {
            PlayerManager = new PlayerManager<YouthPlayer>();
            YouthPlayers = new ObservableCollection<YouthPlayer>(PlayerManager.PlayerList);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
