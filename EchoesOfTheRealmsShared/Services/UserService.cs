using EchoesOfTheRealms;
using EchoesOfTheRealmsShared.DTO;
using EchoesOfTheRealmsShared.Entities.UserFiles;
using EotR.App.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace EchoesOfTheRealmsShared.Services
{
    public class UserService (EotRContext _db)
    {

        public User Login(string username, string password)
        {

            User us = _db.Users
                .Include(u => u.UserRoles)
                .SingleOrDefault(u => EF.Functions.Like(u.NickName, username)) ?? 
                throw new AuthenticationException();

            if (!PasswordUtils.CheckPassword(password, us.Password))
            {
                throw new AuthenticationException();
            }
            return us;

        }

        public User Create(RegisterDTO dto)
        {
            if(_db.Users.Any(u => u.NickName == dto.NickName || u.Mail == dto.Mail))
            {
                throw new ArgumentException();
            }

            User user = new User();
            user.NickName = dto.NickName;
            user.Password = PasswordUtils.HashPassword(dto.Password, Guid.NewGuid());
            user.FirstName = dto.FirstName;
            user.LastName = dto.LastName;
            user.Mail = dto.Mail;
            user.UserRoles = [_db.UserRoles.Single(r => r.Id == 1)];

            _db.Users.Add(user);
            _db.SaveChanges();

            return user;
        }

    }
}
