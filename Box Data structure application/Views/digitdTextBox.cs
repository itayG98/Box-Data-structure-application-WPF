using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Box_Data_structure_application.Views
{
    public class DigitdTextBox : TextBox 
    {
        private static readonly Regex regex = new Regex("^[0-9]+$");

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            if (!regex.IsMatch(e.Text))
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }
    }
}
