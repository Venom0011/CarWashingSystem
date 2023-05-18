﻿using CarWashSystem.Models;

namespace CarWashSystem.Interfaces
{
    public interface IUser
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(int id);
        Task<User> CreateUser(User user);
       
        Task<User> DeleteUser(int id);
    }
}
