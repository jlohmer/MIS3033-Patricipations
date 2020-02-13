using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _P__JSON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = "https://pokeapi.co/api/v2/pokemon?offset-0&limit=1000";

            AllPokemonAPI pokemonAPI;
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(path).Result;

                pokemonAPI = JsonConvert.DeserializeObject<AllPokemonAPI>(json);
            }

            foreach (var pokie in pokemonAPI.results)
            {
                lst_Pokemon.Items.Add(pokie);
            }
        }
        private void lst_Pokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPokemonFromList = (pokieInfo)lst_Pokemon.SelectedItem;

            img_Pokemon.Source = new BitmapImage(new Uri(selectedPokemonFromList.image));
        }
    }
}
