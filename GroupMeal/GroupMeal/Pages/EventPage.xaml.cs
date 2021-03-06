﻿using System;
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

            if (settings.eventData != null)
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
            if (e.SelectedItem == null)
            {
                return;
            }

            @event selectedEvent = e.SelectedItem as @event;

            (sender as ListView).SelectedItem = null;

             
              Navigation.PushAsync(new EventOverviewPage(selectedEvent)); 

        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            Events.Remove(Events.Where(x => x.eventID == mi.CommandParameter.ToString()).FirstOrDefault());
            this.eventListView.ItemsSource = this.Events;
            settings.eventData = this.Events.ToList();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventEditPage());
        }
    }
}