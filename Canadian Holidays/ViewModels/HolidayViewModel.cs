using System;
using Canadian_Holidays.Services;
using Canadian_Holidays.Model;
using MvvmHelpers;
using MvvmHelpers.Commands;
namespace Canadian_Holidays.ViewModels
{
	internal class HolidayViewModel
	{
		

          public IHolidayDataStore<Holiday> DataStore =>
            DependencyService.Get<IHolidayDataStore<Holiday>>();

        public ObservableRangeCollection<Holiday> Holiday { get; set; }

        public AsyncCommand PageAppearingCommand { get; }


        public HolidayViewModel()
        {
            Holiday = new ObservableRangeCollection<Holiday>();
            PageAppearingCommand = new AsyncCommand(PageAppearing);
        }

        public async Task Refresh()
        {
            var holiday = await DataStore.GetHolidayAsync();

            Holiday.AddRange(holiday);
        }

        async Task PageAppearing()
        {
            await Refresh();
        }
    }
	
}

