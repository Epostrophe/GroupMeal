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
                people.Text = eventOnPage.name;
                time.Text = eventOnPage.name;
                location.Text = eventOnPage.name;
                recipes.Text = eventOnPage.name;
                this.eventOnPage = eventOnPage;
            }
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
                eventToUpdate.people = people.Text;
                eventToUpdate.time = time.Text;
                eventToUpdate.location = location.Text;
                eventToUpdate.recipes = recipes.Text;
            }
            else
            {
                eventOnPage = new @event();

                eventOnPage.name = eventName.Text;

                eventOnPage.eventID = Guid.NewGuid().ToString();
                Events.Add(eventOnPage);
            }
            settings.eventData = Events;
            Navigation.PopAsync();
        }
    }
}