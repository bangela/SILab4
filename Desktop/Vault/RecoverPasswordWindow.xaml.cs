using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Vault.Core.Models;

namespace Vault
{
    /// <summary>
    /// Interaction logic for RecoverPasswordWindow.xaml
    /// </summary>
    public partial class RecoverPasswordWindow : Window
    {
        private readonly Profile _profile;
        public RecoverPasswordWindow(Profile profile)
        {
            _profile = profile;
            InitializeComponent();
        }

        private void GetPassword_Click(object sender, RoutedEventArgs e)
        {
            var recoveryCode = this.RecoveryCodeTextBox.Text;
            var password = _profile.PasswordRecovery(recoveryCode);
            this.RecoveryCodePassword.Text = password;
        }
    }
}
