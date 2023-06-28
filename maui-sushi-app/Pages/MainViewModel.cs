using maui_sushi_app.ViewModels;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text.Json;

namespace maui_sushi_app.Pages
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            Reset();
        }

        private ObservableCollection<string> categories;

        public ObservableCollection<string> Categories
        {
            get => categories;
            set
            {
                if (categories == value) return;
                categories = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Categories)));
                SelectedCategory = null;
            }
        }

#nullable enable
        private string? selectedCategory = null;
        public string? SelectedCategory
#nullable disable
        {
            get => selectedCategory;
            set
            {
                if (selectedCategory == value) return;
                selectedCategory = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedCategory)));
                SelectedProducts = GetProductsByCategory(SelectedCategory);
            }
        }

        private ObservableCollection<ProductViewModel> products;

        public ObservableCollection<ProductViewModel> Products
        {
            get => products;
            set
            {
                if (products == value) return;
                products = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Products)));
            }
        }

        private ObservableCollection<ProductViewModel> selectedProducts = new ObservableCollection<ProductViewModel>();
        public ObservableCollection<ProductViewModel> SelectedProducts
        {
            get => selectedProducts;
            set
            {
                selectedProducts = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedProducts)));
            }
        }

#nullable enable
        public ObservableCollection<ProductViewModel> GetProductsByCategory(string? category)
#nullable disable
        {
            if ((category is null) || (category == "All"))
            {
                return products;
            }
            return new ObservableCollection<ProductViewModel>(
                products.Where(p => p.Category == category)
            );
        }

        public string ProductsAsText
        {
            get => JsonSerializer.Serialize<List<ProductViewModel>>(Products.ToList());
            set
            {
                Products = new ObservableCollection<ProductViewModel>(JsonSerializer.Deserialize<List<ProductViewModel>>(value));
            }
        }

#nullable enable
        public string? Name => null;
        public string? Category => null;
#nullable disable

        public void Reset()
        {
            Categories = new ObservableCollection<string>(
            new List<string>(new string[] {
                "All"
                ,"Platter"
                ,"Sashimi & Salad"
                ,"Roll Boxes"
                ,"Nigiri Boxes"
                //,"Mini Rolls"
                //,"Handrolls"
                //,"Hot Food"
                //,"Udon"
                //,"Poke Bowl & Chirashi"
            }));

            ProductsAsText =
"""
[
    {"Category":"Platter","Name":"Chef's Favourite Platter"},
    {"Category":"Platter","Name":"Salmon Lover Platter"},
    {"Category":"Platter","Name":"Rock & Roll Platter"},
    {"Category":"Platter","Name":"Nori Aburi Platter"},
    {"Category":"Platter","Name":"Omakase Platter"},
    {"Category":"Platter","Name":"Sushi Deluxe Platter"},
    {"Category":"Platter","Name":"Premium Selection Platter"},
    {"Category":"Platter","Name":"Chef's Sashimi Platter"},
    {"Category":"Platter","Name":"Veggie Delight Platter"},
    {"Category":"Roll Boxes","Name":"Chicken Katsu Maki Box"},
    {"Category":"Roll Boxes","Name":"Aburi Teriyaki Mayo Salmon Roll Box"},
    {"Category":"Roll Boxes","Name":"Lion King Roll Box"},
    {"Category":"Roll Boxes","Name":"Salmon Delight Roll Box"},
    {"Category":"Roll Boxes","Name":"Tuna Delight Roll Box"},
    {"Category":"Roll Boxes","Name":"Dragon Roll Box"},
    {"Category":"Roll Boxes","Name":"Himalaya Roll Box"},
    {"Category":"Roll Boxes","Name":"Futomaki"},
    {"Category":"Roll Boxes","Name":"Fresh Salmon Maki Box"},
    {"Category":"Roll Boxes","Name":"California Maki Box"},
    {"Category":"Roll Boxes","Name":"Nacho Cheese Tuna Roll Box"},
    {"Category":"Roll Boxes","Name":"Tuna Salad Maki Box"},
    {"Category":"Roll Boxes","Name":"Teriyaki Chicken Maki Box"},
    {"Category":"Roll Boxes","Name":"Tempura Prawn Maki Box"},
    {"Category":"Roll Boxes","Name":"Prawn Katsu Maki Box"},
    {"Category":"Roll Boxes","Name":"Vegie Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Fresh Salmon Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Fresh Tuna Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Tuna Salad Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Teriyaki Chicken Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Chicken Katsu Maki Box"},
    {"Category":"Roll Boxes","Name":"Avocado Cucumber Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Tempura Prawn Maki Box"},
    {"Category":"Roll Boxes","Name":"Spicy Prawn Katsu Maki Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Prawn Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Assorted Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Nigiri Roll Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Assorted Nigiri Roll Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Tuna Nigiri Roll Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Tuna Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Deluxe Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Tuna Deluxe Box"},
    {"Category":"Nigiri Boxes","Name":"Assorted Deluxe Box"},
    {"Category":"Nigiri Boxes","Name":"Salmon Scallop Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Chef's Premium Box"},
    {"Category":"Nigiri Boxes","Name":"Chef's Gourmet Box"},
    {"Category":"Nigiri Boxes","Name":"Tamago Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Unagi Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Teriyaki Mayo Salmon Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Cheese Crabstick Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Rainbow Aburi Salmon Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Spicy Prawn Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Cheese Prawn Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Rainbow Aburi Scallop Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Rainbow Aburi Prawn Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Spicy Scallop Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Aburi Cheese Scallop Nigiri Box"},
    {"Category":"Nigiri Boxes","Name":"Rainbow Aburi Crabstick Nigiri Box"},
    {"Category":"Sashimi & Salad","Name":"Salmon Sashimi (15pcs)"},
    {"Category":"Sashimi & Salad","Name":"Salmon Sashimi (7pcs)"},
    {"Category":"Sashimi & Salad","Name":"Salmon Tuna Sashimi (7pcs)"},
    {"Category":"Sashimi & Salad","Name":"Salmon Tuna Sashimi (15pcs)"},
    {"Category":"Sashimi & Salad","Name":"Assorted Sashimi (7pcs)"},
    {"Category":"Sashimi & Salad","Name":"Premium Sashimi (16pcs)"},
    {"Category":"Sashimi & Salad","Name":"Seaweed Salad"},
    {"Category":"Sashimi & Salad","Name":"Mushroom Salad"},
    {"Category":"Sashimi & Salad","Name":"Jellyfish Salad"},
    {"Category":"Sashimi & Salad","Name":"Lobster Salad"},
    {"Category":"Sashimi & Salad","Name":"Abalone Salad"},
    {"Category":"Sashimi & Salad","Name":"Octopus Salad"}
]
""";

            SelectedCategory = "All";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
