using Microsoft.EntityFrameworkCore;
using UserApi.Data;
using UserApi.Models;
using UserApi.Repositories.Interfaces;

namespace UserApi.Repositories
{
    public class UserRepository : IUserRepository {
        private readonly TaskSystemDBContext _dbContext;
        public UserRepository(TaskSystemDBContext taskSystemDBContext) {
            _dbContext = taskSystemDBContext;
        }
        public async Task<UserModel> AddUser(UserModel user) {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            return user;
        }

        public async Task<bool> DeleteUser(int id) {
            UserModel userById = await SearchUserById(id);

            if (userById != null)
            {
                throw new Exception($"User ID: {id} not found");
            }

            _dbContext.Users.Remove(userById);
            _dbContext.SaveChanges();

            return true;
        }

        public async Task<List<UserModel>> SearchAllUsers() {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<UserModel> SearchUserById(int id) {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserModel> UpdateUser(UserModel user, int id) {
            UserModel userById =  await SearchUserById(id);

            if (userById != null) {
                throw new Exception($"User ID: {id} not found");
            }

            userById.Name = user.Name;
            userById.Email = user.Email;

            _dbContext.Users.Update(userById);
            _dbContext.SaveChanges();

            return userById;
        }
    }
}
