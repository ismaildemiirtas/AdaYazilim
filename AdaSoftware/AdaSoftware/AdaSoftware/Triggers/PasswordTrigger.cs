using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AdaSoftware.Triggers
{
    public class PasswordTrigger : TriggerAction<Entry>

    {
        Entry firstPassword;

        public Entry FirstPassword { get => firstPassword; set => firstPassword = value; }

        protected override void Invoke(Entry sender)
        {
            if (sender.Text.Equals(FirstPassword.Text))
                sender.TextColor = Color.AliceBlue;
            else
                sender.TextColor = Color.Red;

        }
    }
}