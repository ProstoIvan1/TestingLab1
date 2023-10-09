using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

namespace ClassLibary1Test
{
    [TestClass]
    public class UserInfoPresenter2Test
    {
        private readonly string _unexpectedAttributeValueMessage = "Unexpected attribute value: ";
        private readonly string _errorMessageIsNotCorrectMessage = "Error message isn't correct: ";
        private readonly string _errorWasNotIdentifyedMessage = "Error was not identifyed";

        private TestUser GetUser() 
        { 
            var user = new TestUser()
            { 
                FirstName = "Test",
                LastName = "Test",
                Phone = "8Test",
                Email = "Test@",
            };
            new UserInfoPresenter2(user);
            return user; 
        }


        [TestMethod]
        public void CorrectResidenceTest()
        {
            TestUser user = GetUser();

            user.PlaceOfResidence = "Russia";
            user.Save();

            Assert.IsTrue(string.IsNullOrEmpty(user.ErrorMessage), user.ErrorMessage);
            Assert.IsFalse(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.AreEqual(user.PlaceOfResidence, "Russia", _unexpectedAttributeValueMessage + user.PlaceOfResidence);
        }

        [TestMethod]
        public void NullResidenceTest()
        {
            TestUser user = GetUser();

            user.Save();

            Assert.AreEqual(user.ErrorMessage, "\nPlace of residence cannot be empty", _errorMessageIsNotCorrectMessage + user.ErrorMessage);
            Assert.IsTrue(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.IsNull(user.PlaceOfResidence, "The Residence attribute isn't null");
        }

        [TestMethod]
        public void IncorrectResidenceTest()
        {
            TestUser user = GetUser();

            user.PlaceOfResidence = "Test";
            user.Save();

            Assert.AreEqual(user.ErrorMessage, "\nPlace of residentce sould be Russia", _errorMessageIsNotCorrectMessage + user.ErrorMessage);
            Assert.IsTrue(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.AreEqual(user.PlaceOfResidence, "Test", _unexpectedAttributeValueMessage + user.PlaceOfResidence);
        }

        [TestMethod]
        public void EmptyResidenceTest()
        {
            TestUser user = GetUser();

            user.PlaceOfResidence = "";
            user.Save();

            Assert.AreEqual(user.ErrorMessage, "\nPlace of residence cannot be empty", _errorMessageIsNotCorrectMessage + user.ErrorMessage);
            Assert.IsTrue(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.AreEqual(user.PlaceOfResidence, "", _unexpectedAttributeValueMessage + user.PlaceOfResidence);
        }
        [TestMethod]
        public void GenderMaleTest()
        {
            TestUser user = GetUser();

            user.PlaceOfResidence = "Russia";
            user.Gender = Gender.Male;
            user.Save();

            Assert.IsTrue(string.IsNullOrEmpty(user.ErrorMessage), user.ErrorMessage);
            Assert.IsFalse(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.AreEqual(user.Gender, Gender.Male, _unexpectedAttributeValueMessage + user.Gender);
        }

        public void GenderFemaleTest()
        {
            TestUser user = GetUser();

            user.PlaceOfResidence = "Russia";
            user.Gender = Gender.Female;
            user.Save();

            Assert.IsTrue(string.IsNullOrEmpty(user.ErrorMessage), user.ErrorMessage);
            Assert.IsFalse(user.ShowFormErrors, _errorWasNotIdentifyedMessage);
            Assert.AreEqual(user.Gender, Gender.Female, _unexpectedAttributeValueMessage + user.Gender);
        }
    }
}
