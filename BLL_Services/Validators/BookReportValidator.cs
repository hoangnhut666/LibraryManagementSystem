using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Validators
{
    public class BookReportValidator
    {
        public static bool IsValidDateRange(DateTime from, DateTime to, out string errorMessage)
        {
            // Check if the 'from' date is later than the 'to' date
            if (from > to)
            {
                errorMessage = "Start date cannot be later than end date.";
                return false;
            }
            // Check if the 'from' date is before a reasonable minimum date (e.g., 1900-01-01)
            if (from < new DateTime(1900, 1, 1))
            {
                errorMessage = "Start date cannot be earlier than January 1, 1900.";
                return false;
            }
            // Check if the 'to' date is in the future
            if (to > DateTime.Now)
            {
                errorMessage = "End date cannot be in the future.";
                return false;
            }
            // Khi dgv hiện tất cả và khi ấn "Show All" thì sẽ báo "Đã hiện tất cả"
            if (from == new DateTime(1900, 1, 1) && to == DateTime.Now)
            {
                errorMessage = "All records are displayed.";
                return false;
            }
            // Check If there is no data in the time period
            if (from == to && from == DateTime.Now)
            {
                errorMessage = "No data available for the selected date range.";
                return false;
            }
            errorMessage = null;
            return true;
        }
    }
}
