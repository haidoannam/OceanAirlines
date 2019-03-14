using NC.OS.Data.Infrastructure;
using NC.OS.Data.Repositories;
using NC.OS.Entites;
using NC.OS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC.OS.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IEntityBaseRepository<User> _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IEntityBaseRepository<User> userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public User Login(string userName, string passWord)
        {
            //var userTest = _userRepository.GetAll();
            var user = _userRepository.FindBy(x => x.Username == userName && x.Password == passWord).FirstOrDefault();

            if (user != null)
                return user;
            return null;
        }
    }
}
