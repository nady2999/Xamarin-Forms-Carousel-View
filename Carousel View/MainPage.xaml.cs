using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carousel_View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            Vegetables = new ObservableCollection<Vegetable>
{
new Vegetable{Image = "corn.jpg",Name="Corn"},
new Vegetable{Image = "carrot.jpg",Name="Carrot"},
new Vegetable{Image = "pepper.jpg",Name="Pepper"},
new Vegetable{Image = "tomato.jpg",Name="Tomato"},
new Vegetable{Image = "lemon.jpg",Name="Lemon"}
};
            Fruits = new ObservableCollection<Fruit>
{
new Fruit{Image = "apple.jpg",Name="Apple"},
new Fruit{Image = "banana.jpg",Name="Banana"},
new Fruit{Image = "mango.jpg",Name="Mango"},
new Fruit{Image = "orange.jpg",Name="Orange"},
new Fruit{Image = "strawberry.jpg",Name="Strawberry"}
};
        }
        public class Vegetable
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
        }
        private ObservableCollection<Vegetable> vegetables;
        public ObservableCollection<Vegetable> Vegetables
        {
            get { return vegetables; }
            set
            {
                vegetables = value;
                OnPropertyChanged();
            }
        }
        public class Fruit
        {
            public ImageSource Image { get; set; }
            public String Name { get; set; }
        }
        private ObservableCollection<Fruit> fruits;
        public ObservableCollection<Fruit> Fruits
        {
            get { return fruits; }
            set
            {
                fruits = value;
                OnPropertyChanged();
            }
        }
    }
}
