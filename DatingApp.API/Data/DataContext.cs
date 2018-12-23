using System.Collections.Generic;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

 base.OnModelCreating(modelBuilder);


            List<User> users;
            List<Photo> photos;
            GetUsersDataFromJsonFile(out users, out photos);
            modelBuilder.Entity<User>().HasData(

users.ToArray()
            )
            ;

            modelBuilder.Entity<Photo>().HasData(

photos.ToArray()
           )
           ;
        }

        private void GetUsersDataFromJsonFile(out List<User> usersList, out List<Photo> photoList)
        {
            var usersData = System.IO.File.ReadAllText("Data/UserSeedData.json");
            var users = JsonConvert.DeserializeObject<List<User>>(usersData);
            usersList = new List<User>();
            photoList = new List<Photo>();

            int x = 0;
            foreach (var user in users)
            {
                x++;
                byte[] passwordHash, passwordSalt;
                AuthRepository.CreatePasswordHash("password", out passwordHash, out passwordSalt);

                user.Id = x;
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Username = user.Username.ToLower();

                usersList.Add(user);
                foreach (var photo in user.Photos)
                {
                    photo.Id = x;
                    photo.UserId = x;
                }


                photoList.AddRange(user.Photos);

                user.Photos = null;
            }




        }

        public DbSet<Value> Values { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Photo> Photos { get; set; }
    }
}