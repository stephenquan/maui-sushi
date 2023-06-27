using System.ComponentModel;

namespace maui_sushi_app.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
#nullable enable
        private string? category;
        public string? Category
#nullable disable
        {
            get => category;
            set
            {
                if (category == value) return;
                category = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Category)));
            }
        }

#nullable enable
        private string? name;
        public string? Name
#nullable disable
        {
            get => name;
            set
            {
                if (name == value) return;
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
