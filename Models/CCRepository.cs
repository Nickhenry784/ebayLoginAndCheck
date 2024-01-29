using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class CCRepository : BaseRepository<CCRecord>
    {
        public CCRepository() { }

        public CCRepository(SheetHelper<CCRecord> sheetsHelper, BaseRepositoryConfiguration config)
            : base(sheetsHelper, config) { }
    }
}
