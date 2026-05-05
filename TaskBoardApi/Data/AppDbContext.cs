using Microsoft.EntityFrameworkCore;
using TaskBoardApi.Models;

namespace TaskBoardApi.Data;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options) { }
    public DbSet<TaskItem> Tasks { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TaskItem>().HasData(
new TaskItem {
    Id = 1,
    Title = "Изучить APP.NET Core",
    Description = "Контроллеры, маршруты, middleware",
    IsCompleted = true,
    CreatedAt = new DateTime(2026, 1, 1, 0, 0, 0, DateTimeKind.Utc)
},
new TaskItem {
    Id = 2,
    Title = "Подключить SQLLite",
    Description = "EF Core, миграции,   DbContext",
    IsCompleted = true,
    CreatedAt = new DateTime(2026, 1, 2, 0, 0, 0, DateTimeKind.Utc)
},
new TaskItem {
    Id = 3,
    Title = "Написать фронтенд",
    Description = "HTML, CSS, JavaScript, fetch",
    IsCompleted = false,
    CreatedAt = new DateTime(2026, 1, 3, 0, 0, 0, DateTimeKind.Utc)
},
new TaskItem {
    Id = 4,
    Title = "Сдать итоговый проект",
    Description = "Показать преподавателю работающие приложение",
    IsCompleted = true,
    CreatedAt = new DateTime(2026, 1, 4, 0, 0, 0, DateTimeKind.Utc)
}
        );
    }
}