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
    public partial class EventEditPage : ContentPage
    {
        public @event eventOnPage;
        public EventEditPage(@event eventOnPage = null)
        {
            InitializeComponent();
            if(eventOnPage != null)
            {
                eventName.Text = eventOnPage.name;
                location.Text = eventOnPage.location;
                this.eventOnPage = eventOnPage;
            }
            this.people.ItemsSource = settings.friendData;
            people.ItemDisplayBinding = new Binding("fullName");
            this.recipes.ItemsSource = settings.recipesData;
            recipes.ItemDisplayBinding = new Binding("name");
        }

        private void addEvent_Clicked(object sender, EventArgs e)
        {
            List<@event> Events = settings.eventData;

            if (Events == null)
            {
                Events = new List<@event>();
            }

            if (eventOnPage != null)
            {
                @event eventToUpdate = Events.Where(rec => rec.eventID == eventOnPage.eventID).First();
                eventToUpdate.name = eventName.Text;
              
                eventToUpdate.location = location.Text;
               
            }
            else
            {
                eventOnPage = new @event();

                eventOnPage.name = eventName.Text;
              
                eventOnPage.location = location.Text;
              
                eventOnPage.eventID = Guid.NewGuid().ToString();
                Events.Add(eventOnPage);
            }
            settings.eventData = Events;
            Navigation.PopAsync();
        }

        private void recipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;

            if (selectedIndex != -1)
            {
                selectedRecipes.Text += ((recipe)picker.ItemsSource[selectedIndex]).name + ",";
                picker.SelectedIndex = -1;
            }
        }
    }
}