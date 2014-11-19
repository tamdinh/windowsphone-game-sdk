using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using APTCallback;
using APTPaymentService;
using APTPaymentResult;

namespace AppotaSDKSample
{
    public partial class MainPage : PhoneApplicationPage, AppotaSDKCallback
    {
        AppotaGameSDK gameSDK;
        public MainPage()
        {
            InitializeComponent();
            gameSDK = new AppotaGameSDK(this);
        }

        private void btnShowLogin_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.ShowLogin();
        }

        private void btnShowPayment_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.MakePayment();
        }

        private void btnSwitchAccount_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.SwitchAccount();
        }

        private void btnShowUserInfo_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.ShowUserInfo();
        }

        private void btnLogoutAccount_Click(object sender, RoutedEventArgs e)
        {
            gameSDK.LogoutAccount();
        }

        #region SDK CALLBACK

        public void OnLogoutAccountSuccess()
        {
            //throw new NotImplementedException();
        }

        public void OnPaymentError(string message)
        {
            //throw new NotImplementedException();
        }

        public void OnPaymentSuccess(TransactionResult result)
        {
            //throw new NotImplementedException();
        }

        public void OnSwitchAccountSuccess(UserLoginResult result)
        {
            //throw new NotImplementedException();
        }

        public void OnUserLoginError(string message)
        {
            //throw new NotImplementedException();
        }

        public void OnUserLoginSuccess(UserLoginResult result)
        {
            //throw new NotImplementedException();
        }

        public void OnUserRegisterError(string message)
        {
            //throw new NotImplementedException();
        }

        public void OnUserRegisterSuccess(UserLoginResult result)
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}