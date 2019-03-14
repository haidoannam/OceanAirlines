using NC.OS.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Services.Interface
{
    public interface IUserService
    {
        User Login(string userName, string passWord);
    }
}
