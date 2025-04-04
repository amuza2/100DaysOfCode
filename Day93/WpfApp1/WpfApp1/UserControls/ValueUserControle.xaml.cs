using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for ValueUserControle.xaml
    /// </summary>
    public partial class ValueUserControle : UserControl
    {
        private int _value = 10;
        public delegate void OnMinThresHoldReached(int value);
        public event OnMinThresHoldReached MinTreasHoldReached;
        private int _currentValue;

        public ValueUserControle()
        {
            InitializeComponent();

            _currentValue = 0;
            UpdateTextBox();

            MinTreasHoldReached += OnValueChanged;

            btnIncrease.Click += (s, e) => ChangeValue(_value);
            btnDecrease.Click += (s, e) => ChangeValue(-_value);
        }

        private void ChangeValue(int value)
        {
            int newValue = _currentValue + value;

            if (newValue > 100)
            {
                MessageBox.Show("can't go beyond that");
                return;
            }
            else if (newValue < 0)
            {
                MessageBox.Show("Can't go below that");
                return;
            }

            _currentValue = newValue;
            MinTreasHoldReached?.Invoke(_currentValue);
        }

        private void OnValueChanged(int value)
        {
            UpdateTextBox();
        }

        private void UpdateTextBox()
        {
            txbValue.Text = _currentValue.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
