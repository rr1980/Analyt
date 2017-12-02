using System.Threading.Tasks;

namespace Analytic.Services
{
    public static class CpuViewModelService
    {
        public static async Task TakeTime(int timeInMilliSec)
        {
            await Task.Delay(timeInMilliSec);
        }
    }
}
