namespace PCode.Api.Infrastructure
{
    public class BaseRepository
    {
        private readonly MainDatabaseContext _dbContext;

        public BaseRepository(MainDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
