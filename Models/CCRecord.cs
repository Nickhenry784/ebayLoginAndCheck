using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class CCRecord : BaseRecord
    {
        [SheetField(
            DisplayName = "Account",
            ColumnID = 1,
            FieldType = SheetFieldType.String)]
        public string Account { get; set; }

        [SheetField(
            DisplayName = "Time Create",
            ColumnID = 2,
            FieldType = SheetFieldType.DateTime)]
        public DateTime? DateTime { get; set; }

        public CCRecord() { }

        // This constructor signature is required to define!
        public CCRecord(IList<object> row, int rowId, int minColumnId = 1)
            : base(row, rowId, minColumnId)
        {
        }
    }
}
