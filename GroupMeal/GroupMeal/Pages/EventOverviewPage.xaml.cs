using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMeal.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroupMeal.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventOverviewPage : ContentPage
    {
        public @event eventOnPage;
        public EventOverviewPage(@event Events)
        {
            InitializeComponent();
            nameOfEvent.Text = Events.name;
            listOfPeople.Text = Events.people;
            finalTime.Text = Events.time;
            finalLocation.Text = Events.location;
            allRecipes.Text = Events.recipes;
            eventOnPage = Events;
        }

        private void editButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventEditPage(eventOnPage));
        }
    }
}