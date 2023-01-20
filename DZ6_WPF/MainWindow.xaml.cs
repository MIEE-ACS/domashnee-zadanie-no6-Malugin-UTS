using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.Linq;
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

namespace DZ6_WPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            pets.Add(new Dogs("Mlek","Jack","For dogs", "8", "Budka", "Lai: 10"));
            pets.Add(new Cat("Mlek", "Dunia", "Kiticat", "2", "Room", "Kogti: ostrota 3"));
            pets.Add(new Krok("Pres", "Kroki", "Zebra", "2", "River", "Dead you"));
            pets.Add(new Vorobey("Bird", "Shpendel", "Zerno", "7", "Tree", "Tupoi"));
            pets.Add(new Shuka("Fish", "5kg", "Small fish", "2", "Rivaer", "Vkusno"));
        
            LoadPets(pets);
  
            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(animalList.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));


        }
        public List<Pets> pets = new List<Pets>();
       
        public void LoadPets(List<Pets> _pets)
        {
            animalList.Items.Clear();
            for (int i = 0; i < _pets.Count; i++)
            {
                animalList.Items.Add(_pets[i]);
            }

        }

        private void ActiveFilter(object sender, RoutedEventArgs e)
        {
            List<Pets> newPets = new List<Pets>();
            newPets = pets;
            if (typeFilter.SelectedIndex == 0)
                newPets = pets.FindAll(x => x.Type == "Mlek");
            else if (typeFilter.SelectedIndex == 1)
                newPets = pets.FindAll(x => x.Type == "Pres");
            else if (typeFilter.SelectedIndex == 2)
                newPets = pets.FindAll(x => x.Type == "Fish");
            else if (typeFilter.SelectedIndex == 3)
                newPets = pets.FindAll(x => x.Type == "Bird");
            LoadPets(newPets);

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(animalList.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));
        }






    }
    public abstract class Pets
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Korm { get; set; }
        public string Age { get; set; }
        public string Place { get; set; }
        public string Individ { get; set; }


    }
    class Mlek : Pets
    {
      
        
    }
    class Pres : Pets { }
    class Bird : Pets { }
    class Fish : Pets { }
    class Dogs : Mlek 
    {  
       
    public Dogs(string _Type, string _Name, string _Korm, string _Age, string _Place, string _Individ)
        {
            this.Korm = _Korm; this.Age = _Age; this.Place = _Place; this.Individ = _Individ; this.Type = _Type; this.Name = _Name; 
        }
    }
    class Cat : Mlek {
        public Cat(string _Type, string _Name, string _Korm, string _Age, string _Place, string _Individ)
        {
            this.Korm = _Korm; this.Age = _Age; this.Place = _Place; this.Individ = _Individ; this.Type = _Type; this.Name = _Name;
        }
    }

    class Krok : Pres 
    {

        public Krok(string _Type, string _Name, string _Korm, string _Age, string _Place, string _Individ)
        {
            this.Korm = _Korm; this.Age = _Age; this.Place = _Place; this.Individ = _Individ; this.Type = _Type; this.Name = _Name;
        }
    }
    class Vorobey : Bird 
    {
        public Vorobey(string _Type, string _Name, string _Korm, string _Age, string _Place, string _Individ)
        {
            this.Korm = _Korm; this.Age = _Age; this.Place = _Place; this.Individ = _Individ; this.Type = _Type; this.Name = _Name;
        }
    }
    class Shuka : Fish 
    {
        public Shuka(string _Type, string _Name, string _Korm, string _Age, string _Place, string _Individ)
        {
            this.Korm = _Korm; this.Age = _Age; this.Place = _Place; this.Individ = _Individ; this.Type = _Type; this.Name = _Name;
        }
    }
   

}
