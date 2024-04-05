/*//UC1
class program
{
    public static void Main(string[] args)
    {
        //attendence

        *//* Random r = new Random();

          int attendence =r.Next(0,2);

          if(attendence == 1)
          {
              Console.WriteLine("employee PRESENT");
          }
          else
          {
              Console.WriteLine("employee ABSENT");
          }*//*

        //wage calculation

        *//* const int wageperHour = 20;
         // const int fulldayHours = 8;

         Console.WriteLine("enter the number of hours worked");
         int fulldayHours = Convert.ToInt32(Console.ReadLine());

         int dailywage = wageperHour * fulldayHours;

         Console.WriteLine($"the total wage is {dailywage}");


     }*//*

        int fullTimewage = 20;
        int partTimewage = 10;
        int workingdaysformonth = 20;
        const int maxWorkingHours = 100;
        const int maxWorkingDays = 20;


        Console.WriteLine("Enter employment type");
        Console.WriteLine("1. Full time");
        Console.WriteLine("2. Part time");
        int employetype = Convert.ToInt32(Console.ReadLine());

        if (employetype != 1 && employetype != 2)
        {
            Console.WriteLine("invalid choice");
            return;
        }
        Console.WriteLine("enter the number of hours to work");

        int hoursofwork = Convert.ToInt32(Console.ReadLine());

        int totalhoursworked=0;
        int totalworkingdays = 0;



        int dailywages;
        if (employetype == 1)
        {
            dailywages = fullTimewage * hoursofwork;
        }
        else
        {
            dailywages =partTimewage * hoursofwork;
        }


        Console.WriteLine($"Daily employee wages is {dailywages}");

        int monthlywage = dailywages * workingdaysformonth;
        Console.WriteLine($"Monthly employee wages is {monthlywage}");

        while(totalhoursworked < maxWorkingHours && totalworkingdays < maxWorkingDays)
        {
            totalhoursworked += hoursofwork;
            totalworkingdays++;
            // If total hours exceed the limit, adjust total hours
            if (totalhoursworked > maxWorkingHours)
            {
                totalhoursworked = maxWorkingHours;
            }

            // If total working days exceed the limit, adjust total working days
            if (totalworkingdays > maxWorkingDays)
            {
                totalworkingdays = maxWorkingDays;
            }
        }

        int monthlyWage = dailywages * to;

        // Display the result
        Console.WriteLine($"Total hours worked: {totalhoursworked}");
        Console.WriteLine($"Total working days: {totalworkingdays}");
        Console.WriteLine($"Monthly Employee Wage: ${monthlyWage}");


    }


}*/