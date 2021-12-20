using System.Data.Entity;

namespace StudentResidence.BL
{
    class MyDbContext : DbContext
    {
        // задаем имя строки подключения из конфига
        private const string CONNECTION_NAME = "StudentResidenceEntities";

        // вызываем базовый конструктор класса dbcontext
        public MyDbContext()
            : base(CONNECTION_NAME)
        {
        }

        // Свойства для работы с таблицами бд. entityframework
        // задаем типы моделей
        public DbSet<BL.Model.student> Students { get; set; }

        public DbSet<Model.room> Rooms { get; set; }

        public DbSet<Model.studentsroom> StudentsRooms { get; set; }

        public DbSet<Model.user> Users { get; set; }
    }
}
