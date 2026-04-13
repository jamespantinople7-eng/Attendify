using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace Attendify;

public partial class Events : ContentPage
{
    public class EventModel
    {
        public string Category { get; set; } = "";
        public string CategoryColor { get; set; } = "#3B82F6";
        public string Title { get; set; } = "";
        public string DateText { get; set; } = "";
        public string Location { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string ActionText { get; set; } = "Register";
        public string ActionColor { get; set; } = "#3B82F6";
    }

    public ObservableCollection<EventModel> EventsCollection { get; } = new();

    public Events()
    {
        InitializeComponent();

        // sample items (match provided preview)
        EventsCollection.Add(new EventModel
        {
            Category = "ACADEMIC",
            CategoryColor = "#3B82F6",
            Title = "Annual Science Fair 2024",
            DateText = "Oct 25, 10:00 AM",
            Location = "Main Hall, Science Building",
            ImageUrl = "https://placehold.co/96x96",
            ActionText = "Register",
            ActionColor = "#3B82F6"
        });

        EventsCollection.Add(new EventModel
        {
            Category = "SPORTS",
            CategoryColor = "#10B981",
            Title = "Inter-College Basketball Finals",
            DateText = "Oct 28, 04:30 PM",
            Location = "Campus Arena",
            ImageUrl = "https://placehold.co/96x96",
            ActionText = "Register",
            ActionColor = "#3B82F6"
        });

        EventsCollection.Add(new EventModel
        {
            Category = "CULTURAL",
            CategoryColor = "#A855F7",
            Title = "Spring Music Festival",
            DateText = "Nov 02, 06:00 PM",
            Location = "East Campus Plaza",
            ImageUrl = "https://placehold.co/96x96",
            ActionText = "Waitlist Full",
            ActionColor = "#E2E8F0"
        });

        EventsList.ItemsSource = EventsCollection;
    }

    private async void Back_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Filter_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Filter", "Filter tapped.", "OK");
    }

    private async void Register_Clicked(object sender, EventArgs e)
    {
        if (sender is Button btn && btn.CommandParameter is EventModel item)
        {
            // simple behavior: show message (replace with real register logic)
            await DisplayAlert(item.Title, $"{item.ActionText} clicked.", "OK");
        }
    }
}