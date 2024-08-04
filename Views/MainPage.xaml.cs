﻿namespace OrganizationApp.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        DueDate.Date = DateTime.Today.AddDays(1);
    }

    private void OnSubmit(object sender, EventArgs e)
    {
        string enteredString = Task.Text;
        if (!string.IsNullOrEmpty(enteredString))
        {
            App.MainViewModel.AddTask(enteredString, DueDate.Date);
            Task.Text = "";
            DueDate.Date = DateTime.Today.AddDays(1);
        }
        else
        {
            Task.Text = "Please enter a valid string";
        }
    }
    
    private void OnButtonPressed(object sender, EventArgs e)
    {
        Button btnsender = (Button)sender;
        btnsender.BackgroundColor = Colors.Green;
    }

    private void OnButtonReleased(object sender, EventArgs e)
    {
        Button btnsender = (Button)sender; 
        btnsender.BackgroundColor = Color.FromArgb("#512BD4");
    }

    private void AddTemplate(object sender, EventArgs e)
    {
        string enteredString = Task.Text;
        if (!string.IsNullOrEmpty(enteredString))
        {
            App.MainViewModel.TemplatesViewModel.AddTemplate(enteredString);
            Task.Text = "";
        }
        else
        {
            Task.Text = "Please enter a valid string";
        }
    }
}