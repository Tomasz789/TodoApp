using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Domain.Entities;
using TodoApp.DAL.DataContext;
using TodoApp.DAL.RepositoryContracts;
using TodoApp.Repositories.Repositories;

namespace TodoApp.Testing.RepositoryTests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        int quantity = 0;

        [Test]
        public void AddNewUserSuccessfully_Test()
        {
            var user = new User(Guid.NewGuid(), "testMockUser1", "testMockUser1@test.com", "T3stMo!5ckUser8R");
            
            // Arrange
            var contextMock = new Mock<AppDatabaseContext>();
            var userDbSetContext = new Mock<DbSet<User>>(Guid.NewGuid(), "testMockUser1", "testMockUser1@test.com", "T3stMo!5ckUser8R");
            contextMock.Setup(c => c.Set<User>()).Returns(userDbSetContext.Object);
            userDbSetContext.Setup(x => x.Add(It.IsAny<User>()).Entity).Returns(user);

            // Act
            var repo = new RepositoryWrapper(contextMock.Object);
            repo.UserRepository.Create(user);

            // Assert

            contextMock.Verify(x => x.Set<User>());
            userDbSetContext.Verify(x => x.Add(It.Is<User>(y => y == user)));
        }
    }
}
