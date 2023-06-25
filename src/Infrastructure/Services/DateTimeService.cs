using valkimia_challenge.Application.Common.Interfaces;

namespace valkimia_challenge.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
