using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;
using TodoApp.DAL.DataContext;
using TodoApp.DAL.RepositoryContracts;

namespace TodoApp.Repositories.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDatabaseContext context) : base(context)
        {
        }

        public User GetById(Guid id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == id);
        }

        public bool Login(string userNameOrEmail, string password)
        {
            var user = Context.Users.SingleOrDefault(x => x.Email.Contains(userNameOrEmail));

            if (user == null)
            {
                return false;
            }

            if (user.Password != password)
            {
                return false;
            }

            return true;
        }
    }
}
