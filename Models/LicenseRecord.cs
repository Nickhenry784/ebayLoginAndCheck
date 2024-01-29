using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class LicenseRecord : BaseRecord
    {
        [SheetField(
            DisplayName = "ComputerHash",
            ColumnID = 1,
            FieldType = SheetFieldType.String)]
        public string ComputerHash { get; set; }

        [SheetField(
            DisplayName = "Random Key",
            ColumnID = 2,
            FieldType = SheetFieldType.String)]
        public string RandomKey { get; set; }

        [SheetField(
            DisplayName = "Creation Date",
            ColumnID = 3,
            FieldType = SheetFieldType.DateTime)]
        public DateTime? CreationDate { get; set; }

        [SheetField(
            DisplayName = "Day Left",
            ColumnID = 4,
            FieldType = SheetFieldType.Integer)]
        public int DayLeft { get; set; }

        [SheetField(
            DisplayName = "HSD",
            ColumnID = 5,
            FieldType = SheetFieldType.Integer)]
        public int HSD { get; set; }

        [SheetField(
            DisplayName = "Active Key",
            ColumnID = 6,
            FieldType = SheetFieldType.Boolean)]
        public bool ActiveKey { get; set; }

        public LicenseRecord() { }

        // This constructor signature is required to define!
        public LicenseRecord(IList<object> row, int rowId, int minColumnId = 1)
            : base(row, rowId, minColumnId)
        {
        }
    }
}
