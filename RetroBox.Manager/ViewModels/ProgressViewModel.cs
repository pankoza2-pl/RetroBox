﻿using ReactiveUI;

namespace RetroBox.Manager.ViewModels
{
    public class ProgressViewModel : ViewModelBase
    {
        private int _paperCol;

        public int PaperCol
        {
            get => _paperCol;
            set => this.RaiseAndSetIfChanged(ref _paperCol, value);
        }

        private bool _paperVis;

        public bool PaperVis
        {
            get => _paperVis;
            set => this.RaiseAndSetIfChanged(ref _paperVis, value);
        }

        private string _currentTitle;

        public string CurrentTitle
        {
            get => _currentTitle;
            set => this.RaiseAndSetIfChanged(ref _currentTitle, value);
        }

        private int _currentValue;

        public int CurrentValue
        {
            get => _currentValue;
            set => this.RaiseAndSetIfChanged(ref _currentValue, value);
        }

        private string _allTitle;

        public string AllTitle
        {
            get => _allTitle;
            set => this.RaiseAndSetIfChanged(ref _allTitle, value);
        }

        private int _allValue;

        public int AllValue
        {
            get => _allValue;
            set => this.RaiseAndSetIfChanged(ref _allValue, value);
        }

        public ProgressViewModel()
        {
            _paperCol = 2;
            _paperVis = true;
            _currentTitle = "Downloading Wikipedia...";
            _currentValue = 34;
            _allTitle = "Saving the Internet itself...";
            _allValue = 77;
        }
    }
}