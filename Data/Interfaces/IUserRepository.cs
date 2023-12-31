﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using ShopProject.Data;
using ShopProject.Models;
namespace ShopProject.Data.Interfaces
{
    public interface IUserRepository: IGenericRepository<User>
    {
        public User GetByUserName(string Name);
        public  Task<User> CheckEmail(string Email);
        //public Task<User> TryLogin(User user);
        /// <summary>
        /// Trying to find user with defined password and Email
        /// </summary>
        /// <param name="model"></param>
        /// <returns> User, that was found or null</returns>
        public Task<User> TryLogin(LoginModel model);

    }
}
