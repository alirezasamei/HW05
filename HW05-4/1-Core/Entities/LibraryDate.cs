using System.Globalization;
public class LibraryDate
{
    private PersianCalendar Shamsi = new PersianCalendar();
    public DateTime BorrowDate { get; set; }
    public int RespiteDays { get; set; }
    public DateTime BackDate { get; set; }
    public static int PenaltyPerDay { get; set; }
    public LibraryDate(int year, int month, int day)
    {
        BorrowDate = Shamsi.ToDateTime(year, month, day, 0, 0, 0, 0);
    }
    public int Penalty()
    {
        return Math.Max(0, (DateTime.Compare(BackDate, BorrowDate) - RespiteDays) * PenaltyPerDay);
    }

}