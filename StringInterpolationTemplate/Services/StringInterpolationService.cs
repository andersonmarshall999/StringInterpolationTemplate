using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. "                        January 22, 2019" (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now;
        var answer = $"{date,40:MMMM dd, yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    //2. "2019.01.22"
    public string Number02()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy.MM.dd}";
        Console.WriteLine(answer);

        return answer;
    }

    //3. "Day 22 of January, 2019"
    public string Number03()
    {
        var date = _date.Now;
        var answer = $"Day {date:dd} of {date:MMMM, yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    //4. "Year: 2019, Month: 01, Day: 22"
    public string Number04()
    {
        var date = _date.Now;
        var answer = $"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}";
        Console.WriteLine(answer);

        return answer;
    }

    //5. "   Tuesday" (right aligned in a 10 character field)
    public string Number05()
    {
        var date = _date.Now;
        var answer = $"{date.DayOfWeek,10}";
        Console.WriteLine(answer);

        return answer;
    }

    //6. "  11:01 PM   Tuesday" (right aligned in 10 character fields)
    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date,10:t}{date.DayOfWeek,10}";
        Console.WriteLine(answer);

        return answer;
    }

    //7. "h:11, m:01, s:27"
    public string Number07()
    {
        var date = _date.Now;
        var answer = $"h:{date:hh}, m:{date:mm}, s:{date:ss}";
        Console.WriteLine(answer);

        return answer;
    }

    //8. "2019.01.22.11.01.27"
    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy.MM.dd.hh.mm.ss}";
        Console.WriteLine(answer);

        return answer;
    }

    //9. "$3.14"
    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C}";
        Console.WriteLine(answer);

        return answer;
    }

    //10. "     3.142" (right aligned in a 10 character field)
    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:F3}";
        Console.WriteLine(answer);

        return answer;
    }

    //11. "7E3"
    public string Number11()
    {
        var date = _date.Now;
        var answer = $"{date.Year:X}";
        Console.WriteLine(answer);

        return answer;
    }

    //2.2019.01.22
}
