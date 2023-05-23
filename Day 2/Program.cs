namespace day_2
{
    class day_2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter D.O.B in dd/mm/yyyy format:");
            string in_dob = Console.ReadLine();
            DateTime out_dob;
            string[] parts=in_dob.Split('/');
            string day=parts[0];
            string month=parts[1];
            string year=parts[2];

            if(DateTime.TryParse($"{month}/{day}/{year}", out out_dob))
            {
                if (DateTime.Now<out_dob)
                {
                    Console.WriteLine("Invalid DOB.");
                }
                else
                {
                    // Calculate age
                    TimeSpan age = DateTime.Now - out_dob;
                    int age_year = (int)(age.TotalDays / 365);
                    int age_month=(int)((age.TotalDays%365)/30);
                    int age_day=(int)((age.TotalDays%365)%30)%30;
                    Console.WriteLine($"{age_year} years {age_month} month and {age_day} days");
                }
            }
            else
            {
                Console.WriteLine("Invalid date input.");
            }
        }
    }
}