using System;
using System.Threading.Tasks;

namespace Analytic.Services
{
    public static class CpuViewModelService
    {
        public static async Task TakeTime(string timeInMilliSecString = "0")
        {
            if (string.IsNullOrEmpty(timeInMilliSecString))
            {
                timeInMilliSecString = "0";
            }

            if (Int32.TryParse(timeInMilliSecString, out var timeInMilliSec))
            {
                await Task.Delay(timeInMilliSec);
            }
            else
            {
                throw new FormatException("'" + timeInMilliSecString + "' ist kein gültiges 'Int32' Format!");
            }
        }
    }
}
