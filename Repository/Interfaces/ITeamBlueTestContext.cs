using System;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.Interfaces
{
    public interface ITeamBlueTestContext : IDisposable
    {
        DbSet<UserInput> UserInputs { get; set; }
        DbSet<WatchListWord> WatchListWords { get; set; }
        int SaveChanges();
    }
}