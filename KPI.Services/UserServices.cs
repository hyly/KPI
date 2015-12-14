using KPI.BusinessObjects;
using KPI.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KPI.DomainModel.Entities;
namespace KPI.Services
{
    public class UserServices : IUserServices
    {
        private IUnitOfWork unitOfWork = null;
        private IUserRepository userRepository = null;
        public UserServices(IUnitOfWork unitOfWork, IUserRepository userRepository)
        {
            this.unitOfWork = unitOfWork;
            this.userRepository = userRepository;
        }
        public List<UserDto> GetAllUsers()
        {
            var entities = userRepository.GetAll("Profile").ToList();
            return entities.Select(user => Mapper.Map<UserDto>(user)).ToList();
        }

        public UserDto GetUser(int userId) {
            var user = userRepository.GetById(userId, "Profile");
            return Mapper.Map<UserDto>(user);
        }

        public void UpdateUser(UserDto user) {
            var entity = this.userRepository.GetById(user.UserId);
            entity.UserName = user.UserName;
            entity.IsActived = user.IsActived;
            entity.ProfileId = user.Profile.ProfileId;
            entity.UserName = user.UserName;
            this.userRepository.Update(entity);
            this.unitOfWork.SaveChanges();
        }

        //public void CreateUser(UserDto user) {
        //    var entity = new User()
        //    {
        //        IsActived = user.IsActived,
        //        Password = Encryptor.Encrypt(user.Password),
        //        ProfileId = user.Profile.ProfileId,
        //        UserName = user.UserName
        //    };
        //    this.userRepository.Add(entity);
        //    this.unitOfWork.SaveChanges();
        //}

        public bool ValidateUser(string userName, string password)
        {
            var entity = userRepository.Get(user => user.UserName.Equals(userName));
            if (entity!=null && entity.IsActived && entity.Password.Equals(password))
            {
                return true;
            }
            return false;
        }
    }
}
