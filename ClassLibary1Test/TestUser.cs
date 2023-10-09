using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibary1Test
{
    public class TestUser : IUserInfo2
    {
        public Gender Gender { get; set; }
        public string PlaceOfResidence { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowFormErrors { get; set; }

        public event EventHandler SaveAttempted;
        public void Save() => SaveAttempted.Invoke(this, EventArgs.Empty);
    }
}
