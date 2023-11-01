using System;
using Canadian_Holidays.Model;
using Canadian_Holidays.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Canadian_Holidays.Services
{
    interface IHolidayDataStore<Holiday>
    {
        Task<IEnumerable<Holiday>> GetHolidayAsync();

    }
}
