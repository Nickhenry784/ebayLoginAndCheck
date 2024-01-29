using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class APIGologinRepository : BaseRepository<APIGologinRecord>
    {
        public APIGologinRepository() { }

        public APIGologinRepository(SheetHelper<APIGologinRecord> sheetsHelper, BaseRepositoryConfiguration config)
            : base(sheetsHelper, config) { }
    }
}
