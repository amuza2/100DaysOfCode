﻿namespace MauiUIDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TextToSpeechTest();
        }
    }
}