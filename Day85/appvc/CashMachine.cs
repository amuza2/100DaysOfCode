using System;

namespace exercice1
{
    class CashMachine
    {
        private readonly Action<string> _logger;
        public CashMachine(Action<string> logger)
        {
            _logger = logger;
        }
        private void Log(string message)
        => _logger?.Invoke(message);

        public void VerifyPin(string pin)
        => Log($"VerifyPin called: PIN={pin}");

        public void ShowBalance()
        => Log("ShowBalance called: Balance=999");        
    }
    
    
}