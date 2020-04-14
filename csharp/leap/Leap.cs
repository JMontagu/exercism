public static class Leap
{
    public static bool IsLeapYear(int year) =>
        year switch
        {
            var _ when year % 400 == 0 => true,
            var _ when year % 100 == 0 => false,
            var _ when year % 4 == 0 => true,
            _ => false,
        };
}
