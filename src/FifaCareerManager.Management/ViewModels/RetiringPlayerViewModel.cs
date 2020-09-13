using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FifaCareerManager.Management.Models;
using FifaCareerManager.Management.Managers;

namespace FifaCareerManager.Management.ViewModels
{
    public class RetiringPlayerViewModel : BaseViewModel
    {
        private ObservableCollection<RetiringPlayer> retiringPlayers;
        private RetiringPlayer selectedPlayer;

        public PlayerManager<RetiringPlayer> PlayerManager { get; }
        public ObservableCollection<RetiringPlayer> RetiringPlayers
        {
            get => retiringPlayers;
            set
            {
                retiringPlayers = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The currently selected Player in the View.
        /// 
        /// When the player selection changes, i.e. if you press Enter when editing a player,
        /// the selection changes and the current player list gets automatically saved on file.
        /// </summary>
        public RetiringPlayer SelectedPlayer
        {
            get
            {
                return selectedPlayer;
            }
            set
            {
                selectedPlayer = value;
                NotifyPropertyChanged();
                PlayerManager.SavePlayers();
            }
        }

        public RetiringPlayerViewModel()
        {
            PlayerManager = new PlayerManager<RetiringPlayer>();
            RetiringPlayers = new ObservableCollection<RetiringPlayer>(PlayerManager.PlayerList);
            RetiringPlayers.CollectionChanged += RetiringPlayers_CollectionChanged;
        }

        /// <summary>
        /// This method is called when a player gets removed or added to the DataGrid in the View.
        /// It will then add or remove players from the <paramref name="PlayerList"/>.
        /// </summary>
        private void RetiringPlayers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach(RetiringPlayer player in e.NewItems)
                    PlayerManager.AddPlayer(player);

            if (e.OldItems != null)
                foreach (RetiringPlayer player in e.OldItems)
                    PlayerManager.RemovePlayer(player);

            PlayerManager.SavePlayers();
        }
    }
}
