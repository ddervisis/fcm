using System.Collections.ObjectModel;
using System.Collections.Specialized;
using FifaCareerManager.Management.Models;
using FifaCareerManager.Management.Managers;

namespace FifaCareerManager.Management.ViewModels
{
    public class YouthPlayerViewModel : BaseViewModel
    {
        private ObservableCollection<YouthPlayer> youthPlayers;
        private YouthPlayer selectedPlayer;

        public PlayerManager<YouthPlayer> PlayerManager { get; }
        public ObservableCollection<YouthPlayer> YouthPlayers
        {
            get => youthPlayers;
            set
            {
                youthPlayers = value;
                NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// The currently selected Player in the View.
        /// 
        /// When the player selection changes, i.e. if you press Enter when editing a player,
        /// the selection changes and the current player list gets automatically saved on file.
        /// </summary>
        public YouthPlayer SelectedPlayer
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

        public YouthPlayerViewModel()
        {
            PlayerManager = new PlayerManager<YouthPlayer>();
            YouthPlayers = new ObservableCollection<YouthPlayer>(PlayerManager.PlayerList);
            YouthPlayers.CollectionChanged += YouthPlayers_CollectionChanged;
        }

        /// <summary>
        /// This method is called when a player gets removed or added to the DataGrid in the View.
        /// It will then add or remove players from the <paramref name="PlayerList"/>.
        /// </summary>
        private void YouthPlayers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
                foreach (YouthPlayer player in e.NewItems)
                    PlayerManager.AddPlayer(player);

            if (e.OldItems != null)
                foreach (YouthPlayer player in e.OldItems)
                    PlayerManager.RemovePlayer(player);

            PlayerManager.SavePlayers();
        }
    }
}
