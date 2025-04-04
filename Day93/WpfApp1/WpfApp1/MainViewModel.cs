using System.ComponentModel;
using System.Speech.Synthesis;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<int> _numbers;
        private string _displayText;
        private string _sound;

        public ICommand ShowEvenCommand { get;}
        public ICommand ShowOddCommand { get;}
        public ICommand ResetCommand { get;}
        public ICommand AceCommand { get; set; }
        public ICommand DescCommand { get; set; }
        public ICommand SoundCommand { get; set; }

        private SpeechSynthesizer _speechSynthesizer;

        public MainViewModel()
        {
            _numbers = new List<int>() { 2,3,9,8,5,6,7,4,2,1};
            ShowEvenCommand = new RelayCommand(async () => await ShowEven());
            ShowOddCommand = new RelayCommand(async () => await ShowOdd());
            ResetCommand = new RelayCommand(async () => await Reset());
            AceCommand = new RelayCommand(async () => await OrderAscending());
            DescCommand = new RelayCommand(async () => await OrderDescending());
            SoundCommand = new RelayCommand(async () => await HearSoundAsync());
            Reset();

            _speechSynthesizer = new SpeechSynthesizer();
            _speechSynthesizer.Volume = 100;
            _speechSynthesizer.Rate = 0;
        }

        private async Task HearSoundAsync()
        {
            if(string.IsNullOrEmpty(_sound))
            {
                MessageBox.Show("Empry field");
                return;
            }
            await Task.Run(() => _speechSynthesizer.SpeakAsync(Sound));
        }

        private async Task OrderDescending()
        {
            var orderDescending = await Task.Run(() => Numbers.OrderDescending().ToList());
            DisplayText = FillContent(orderDescending);
        }

        private async Task OrderAscending()
        {
            var orderAscending = await Task.Run(() => Numbers.Order().ToList());
            DisplayText = FillContent(orderAscending);
        }

        private async Task Reset()
        {
            DisplayText = await Task.Run(() => FillContent(Numbers));
        }

        private string FillContent(List<int> numbers)
        {
            return string.Join(',', numbers); 
        }

        private async Task ShowOdd()
        {
            var oddNumbers = await Task.Run(() => Numbers.Where(n => n % 2 != 0).ToList());
            DisplayText = FillContent(oddNumbers);
        }

        private async Task ShowEven()
        {
            var evenNumbers = await Task.Run(() => Numbers.Where(n => n % 2 == 0).ToList());
            DisplayText = FillContent(evenNumbers);
        }

        public List<int> Numbers
        {
            get => _numbers;
            private set
            {
                _numbers = value;
                OnPropertyChanged(nameof(Numbers));
            }
        }

        public string DisplayText
        {
            get => _displayText;
            private set
            {
                _displayText = value;
                OnPropertyChanged(nameof(DisplayText));
            }
        }
        public string Sound
        {
            get => _sound;
            set
            {
                if (value != _sound)
                {
                    _sound = value;
                    OnPropertyChanged(nameof(Sound));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
