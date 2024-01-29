using ebayLoginAndCheck.Models;
using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Controllers
{
    public class GoogleSheetControllers
    {
        public static ReaderWriterLock locker = new ReaderWriterLock();

        public bool AddaNewRecordToSheet(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential, string account)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<CCRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new CCRepository(sheetHelper, repoConfig);

                // Validate that the header names match the expected format defined with the SheetFieldAttribute values
                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                // Add a new record to the end of the Google Sheets tab
                repository.AddRecord(new CCRecord()
                {
                    Account = account,
                    DateTime = DateTime.Now
                });
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                locker.ReleaseWriterLock();
            }

        }

        public List<string> getListApiGologinFromSheet(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential)
        {
            List<string> list = new List<string>();
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<APIGologinRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new APIGologinRepository(sheetHelper, repoConfig);

                // Validate that the header names match the expected format defined with the SheetFieldAttribute values
                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                var allRecords = repository.GetAllRecords();

                foreach (var record in allRecords)
                {
                    list.Add(record.ApiGologin.ToString());
                }
            }
            catch
            {
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
            return list;
        }

        public LicenseRecord findComputerHashFromSheet(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential, string computer)
        {
            LicenseRecord licenseRecord = null;
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<LicenseRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new LicenseRepository(sheetHelper, repoConfig);

                // Validate that the header names match the expected format defined with the SheetFieldAttribute values
                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                var allRecords = repository.GetAllRecords();

                if (allRecords.Count > 0)
                {
                    foreach (var record in allRecords)
                    {

                        if (record.ComputerHash.Equals(computer))
                        {
                            licenseRecord = record;
                            break;
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
                locker.ReleaseWriterLock();
            }
            return licenseRecord;
        }

        public bool EditRecordToSheetActiveKey(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential, string computer, string randomKey, DateTime? creationDate, int dayLeft)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<LicenseRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new LicenseRepository(sheetHelper, repoConfig);


                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                // Add a new record to the end of the Google Sheets tab
                var allRecords = repository.GetAllRecords();

                if (allRecords.Count > 0)
                {
                    foreach (var record in allRecords)
                    {
                        if (record.ComputerHash.Equals(computer))
                        {
                            record.RandomKey = randomKey;
                            record.CreationDate = creationDate;
                            record.DayLeft = dayLeft;
                            record.ActiveKey = false;
                            repository.SaveFields(record, (r) => r.RandomKey, (r) => r.CreationDate, (r) => r.DayLeft, (r) => r.ActiveKey);
                            break;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                locker.ReleaseWriterLock();
            }

        }


        public bool EditDateLeftToSheetActiveKey(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential, string computer, int dayLeft)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<LicenseRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new LicenseRepository(sheetHelper, repoConfig);


                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                // Add a new record to the end of the Google Sheets tab
                var allRecords = repository.GetAllRecords();

                if (allRecords.Count > 0)
                {
                    foreach (var record in allRecords)
                    {
                        if (record.ComputerHash.Equals(computer))
                        {
                            record.HSD = dayLeft;
                            repository.SaveField(record, (r) => r.HSD);
                            break;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                locker.ReleaseWriterLock();
            }

        }

        public bool AddaNewRecordToSheetActiveKey(string GoogleSpreadsheetId, string GoogleServiceAccountName, string JsonCredential, LicenseRecord licenseRecord)
        {
            try
            {
                locker.AcquireWriterLock(int.MaxValue);
                var sheetHelper = new SheetHelper<LicenseRecord>(GoogleSpreadsheetId, GoogleServiceAccountName, "");

                sheetHelper.Init(JsonCredential);

                // Create a Repository for the TestRecord class
                var repoConfig = new BaseRepositoryConfiguration()
                {
                    // Does the table have a header row?
                    HasHeaderRow = true,
                    // Are there any blank rows before the header row starts?
                    HeaderRowOffset = 0,
                    // Are there any blank rows before the first row in the data table starts?                
                    DataTableRowOffset = 0,
                };

                var repository = new LicenseRepository(sheetHelper, repoConfig);


                var result = repository.ValidateSchema();

                if (!result.IsValid)
                {
                    throw new ArgumentException(result.ErrorMessage);
                }

                // Add a new record to the end of the Google Sheets tab
                repository.AddRecord(licenseRecord);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                locker.ReleaseWriterLock();
            }

        }
    }
}
