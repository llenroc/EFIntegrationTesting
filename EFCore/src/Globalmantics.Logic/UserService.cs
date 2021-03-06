﻿using Globalmantics.DAL;
using Globalmantics.DAL.Entities;
using System;
using System.Linq;

namespace Globalmantics.Logic
{
    public class UserService
    {
        private GlobalmanticsContext _context;

        public UserService(GlobalmanticsContext context)
        {
            _context = context;
        }

        public User GetUserByEmail(string emailAddress)
        {
            var user = _context.User.Add(new User
            {
                Email = emailAddress
            }).Entity;

            return user;
        }
    }
}