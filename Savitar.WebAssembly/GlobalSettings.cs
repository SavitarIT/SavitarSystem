using System;

namespace Savitar.WebAssembly
{
    public class GlobalSettings
    {
        public delegate void OnIsLoggedInChangedDelegate(bool isLoggedIn);
        public event OnIsLoggedInChangedDelegate OnIsLoggedInChanged;

        bool isLoggedIn;

        public bool IsLoggedIn {
            get => isLoggedIn;
            set
            {
                if (isLoggedIn == value)
                    return;

                isLoggedIn = value;
                OnIsLoggedInChanged?.Invoke(value);
            } 
        }
    }    
}
