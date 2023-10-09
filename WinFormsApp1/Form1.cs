using ClassLibrary1;

namespace WinFormsApp1
{
    public partial class Form1 : Form, IUserInfo2
    {
        private UserInfoPresenter _presenter;
        public Form1()
        {
            InitializeComponent();
            _presenter = new UserInfoPresenter2(this);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveAttempted?.Invoke(this, EventArgs.Empty);
        }

        string IUserInfo.FirstName { get => FirstName.Text; set => FirstName.Text = value; }
        string IUserInfo.LastName { get => LastName.Text; set => LastName.Text = value; }
        string IUserInfo.Email { get => Email.Text; set => Email.Text = value; }
        string IUserInfo.Phone { get => Phone.Text; set => Phone.Text = value; }
        string IUserInfo.ErrorMessage { get => ErrorMessage.Text; set => ErrorMessage.Text = value; }
        bool IUserInfo.ShowFormErrors { get => ErrorMessage.Visible; set => ErrorMessage.Visible = value; }
        Gender IUserInfo2.Gender { get => (Gender) GenderComboBox.SelectedItem; set => GenderComboBox.SelectedItem = value; }
        string IUserInfo2.PlaceOfResidence { get => PlaceOfResidenceTextBox.Text; set => PlaceOfResidenceTextBox.Text = value; }

        public event EventHandler? SaveAttempted;
    }
}