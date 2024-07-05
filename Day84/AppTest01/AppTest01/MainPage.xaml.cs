namespace AppTest01
{
    public partial class MainPage : ContentPage
    {
        int _person = 1;
        float _totalAmountToPayForEachPerson = 0;
        float _subtotalAmount = 0;
        float _tipAmount = 0;
        int _tipPersantage = 0;
        float _entryAmount = 0;
        float _tipPersantageDevidedByHundred = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            if(_person > 1) _person--;
            ChangePersonLabel(_person);
            CalculateResults();
        }

        private void btnPlus_Clicked(object sender, EventArgs e)
        {
            _person++;
            ChangePersonLabel(_person);
            CalculateResults();
        }
        private void ChangePersonLabel(int person)
        {
            lblPerson.Text = person.ToString();
        }
        private void txbBill_Completed(object sender, EventArgs e)
        {
            _entryAmount = float.Parse(txbBill.Text);
            CalculateResults();
        }
        // claculate total subtotal pet person
        private void CalculateResults()
        {
            _subtotalAmount = _entryAmount / _person;
            _totalAmountToPayForEachPerson = _subtotalAmount;
            CalculateTipAmount();
            _totalAmountToPayForEachPerson += _tipAmount;

            lblTotal.Text = "$" + _totalAmountToPayForEachPerson.ToString("F2");
            lblTipPerPerson.Text = "$" + _tipAmount.ToString("F2");
            lblSubtotal.Text = "$" + _subtotalAmount.ToString("F2");
            lblsldTip.Text = $"Tip: {_tipPersantage}%";
        }
        private void CalculateTipAmount()
        {
            _tipAmount = _tipPersantageDevidedByHundred * _subtotalAmount;
        }
        private void CalculateTipPersantage(float tipPersentage)
        {
            _tipPersantageDevidedByHundred = (tipPersentage / 100);
        }
        private void btnTip1_Pressed(object sender, EventArgs e)
        {
            _tipPersantage = 10;
            SetSliderValue(_tipPersantage);
            CalculateTipPersantage(_tipPersantage);
        }

        private void btnTip2_Pressed(object sender, EventArgs e)
        {
            _tipPersantage = 15;
            SetSliderValue(_tipPersantage);
            CalculateTipPersantage(_tipPersantage);
        }

        private void btnTip3_Pressed(object sender, EventArgs e)
        {
            _tipPersantage = 20;
            SetSliderValue(_tipPersantage);
            CalculateTipPersantage(_tipPersantage);
        }

        private void sliderTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _tipPersantage = (int)e.NewValue;
            CalculateTipPersantage(_tipPersantage);
            CalculateResults();
        }
        private void SetSliderValue(int persantage)
        {
            sliderTip.Value = persantage;
        }

        
    }

}
