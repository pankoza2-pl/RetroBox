using System;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Interactivity;
using RetroBox.API;
using RetroBox.API.Update;
using RetroBox.Manager.ViewCore;
using RetroBox.Manager.ViewModels;
using RetroBox.Update;

namespace RetroBox.Manager.Views
{
    public partial class EmuUpdateWindow : FixWindow
    {
        private readonly IReleaseFetcher _github;

        public EmuUpdateWindow()
        {
            InitializeComponent();
            _github = new GithubFetcher();
        }

        private void BtnCancel_OnClick(object? sender, RoutedEventArgs e)
        {
            Close(false);
        }

        private void BtnDownload_OnClick(object? sender, RoutedEventArgs e)
        {
            var emus = ViewHelper.GetChecked<Release>(lvEmus).ToArray();
            var roms = ViewHelper.GetChecked<Release>(lvRoms).ToArray();

            // TODO Download and extract ?!

            Close(true);
        }

        private async void TopLevel_OnOpened(object? sender, EventArgs e)
        {
            var allEmus = new List<Release>();
            await foreach (var release in _github.FetchEmuReleases())
                allEmus.Add(release);
            var allRoms = new List<Release>();
            await foreach (var release in _github.FetchRomReleases())
                allRoms.Add(release);
            allEmus = allEmus.FindMatch();
            allRoms = allRoms.FindMatch(ignoreSrc: false);

            var model = (EmuUpdateViewModel)DataContext!;
            foreach (var release in allEmus)
                model.Emus.Add(release);
            foreach (var release in allRoms)
                model.Roms.Add(release);
        }
    }
}