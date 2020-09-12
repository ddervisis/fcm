namespace FifaCareerManager.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            //var jsonString = File.ReadAllText(@"C:\Users\Dennis\Desktop\youth_players.json");
            ////var jsonString = ReadResource("youth_players.json");
            //var playerList = PlayerSerializer.DeserializePlayers<List<YouthPlayer>>(jsonString);
            //foreach (var item in playerList)
            //{
            //    item.Age = 99;
            //    Console.WriteLine("{0}, {1}-{2}, {3}-{4}, {5}, {6}, {7}", item.Name, item.MinRating, item.MaxRating, item.MinPotential, item.MaxPotential, item.Age, item.Position, item.Rating);
            //}
            //var newJson = PlayerSerializer.SerializePlayers(playerList);
            //File.WriteAllText(@"C:\Users\Dennis\Desktop\new_players.json", newJson);
        }

        private void OpenGithub(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
