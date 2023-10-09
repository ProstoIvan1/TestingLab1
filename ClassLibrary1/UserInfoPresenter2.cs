using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserInfoPresenter2 : UserInfoPresenter
    {
        protected readonly IUserInfo2 _form;
        public UserInfoPresenter2(IUserInfo2 form) : base(form)
        {
            _form = form;
            form.SaveAttempted += _form_SaveAttempted;
        }

        protected void AddError(string message, char splitter = '\n')
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += splitter + message;
        }

        private void _form_SaveAttempted(object? sender, EventArgs e)
        {
            CheckName();
            CheckPhone();
            CheckResidence();
        }

        private void CheckName()
        {
            if (string.IsNullOrEmpty(_form.LastName))
            {
                AddError("LastName cannot be empty");
            }
            else
            {
                if (!string.IsNullOrEmpty(_form.FirstName))
                {
                    if (!(char.IsUpper(_form.FirstName[0]) || char.IsUpper(_form.LastName[0])))
                        AddError("Name sould starts with a capital letter");
                }
            }
        }

        private void CheckPhone()
        {
            if (string.IsNullOrEmpty(_form.Phone))
                AddError("Phone cannot be empty");
            else
            {
                if (!(_form.Phone.StartsWith("+7") || _form.Phone.StartsWith("8")))
                    AddError("Phone sould starts with \"+7\" or \"8\"");
            }
        }

        private void CheckResidence()
        {
            if (string.IsNullOrEmpty(_form.PlaceOfResidence))
                AddError("Place of residence cannot be empty");
            else
            {
                if (_form.PlaceOfResidence != "Russia")
                    AddError("Place of residentce sould be Russia");
            }
        }
    }
}
