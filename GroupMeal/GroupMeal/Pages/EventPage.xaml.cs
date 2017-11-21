using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GroupMeal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventPage : ContentPage
    {
        public ObservableCollection<@event> Events { get; set; }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (settings.recipesData != null)
            {
                this.Events = new ObservableCollection<@event>(settings.eventData);
            }
            else
            {
                this.Events = new ObservableCollection<@event>();
            }
            this.eventListView.ItemsSource = this.Events;
        }
        public EventPage()
        {
            InitializeComponent();
        }

        private void eventListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}