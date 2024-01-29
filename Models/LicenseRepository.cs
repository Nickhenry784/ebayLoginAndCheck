using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class LicenseRepository : BaseRepository<LicenseRecord>
    {
        public LicenseRepository() { }

        public LicenseRepository(SheetHelper<LicenseRecord> sheetsHelper, BaseRepositoryConfiguration config)
            : base(sheetsHelper, config) { }
    }
}
