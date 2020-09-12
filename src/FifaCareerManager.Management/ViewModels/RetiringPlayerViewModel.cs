using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using FifaCareerManager.Management.Models;
using FifaCareerManager.Management.Managers;

namespace FifaCareerManager.Management.ViewModels
{
    public class RetiringPlayerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<RetiringPlayer> RetiringPlayers { get; private set; }
        public PlayerManager<RetiringPlayer> PlayerManager { get; }

        private RetiringPlayer selectedPlayer;
        public RetiringPlayer SelectedPlayer
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

        public RetiringPlayerViewModel()
        {
            PlayerManager = new PlayerManager<RetiringPlayer>();
            RetiringPlayers = new ObservableCollection<RetiringPlayer>(PlayerManager.PlayerList);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
