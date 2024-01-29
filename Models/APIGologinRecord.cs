using GoogleSheetsWrapper;

namespace ebayLoginAndCheck.Models
{
    public class APIGologinRecord : BaseRecord
    {
        [SheetField(
            DisplayName = "Api",
            ColumnID = 1,
            FieldType = SheetFieldType.String)]
        public string ApiGologin { get; set; }

        [SheetField(
            DisplayName = "Status",
            ColumnID = 2,
            FieldType = SheetFieldType.DateTime)]
        public string Status { get; set; }

        public APIGologinRecord() { }

        // This constructor signature is required to define!
        public APIGologinRecord(IList<object> row, int rowId, int minColumnId = 1)
            : base(row, rowId, minColumnId)
        {
        }
    }
}
