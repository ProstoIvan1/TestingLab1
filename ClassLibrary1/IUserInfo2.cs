using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IUserInfo2 : IUserInfo
    {
        Gender Gender { get; set; }
        string PlaceOfResidence { get; set; }
    }
}
