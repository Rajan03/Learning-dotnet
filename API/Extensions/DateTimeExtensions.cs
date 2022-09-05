
namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dateTime)
        {
            // Find the age of the user by subtracting the current year from the year of birth
            var age = DateTime.Today.Year - dateTime.Year;

            // If the user's birthday hasn't happened yet this year, subtract 1 from the age
            if (dateTime.AddYears(age) > DateTime.Today)
                age--;

            return age;
        }
    }
}