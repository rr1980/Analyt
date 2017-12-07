using Analytic.Common;
using Analytic.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Analytic.Services
{
    public static class ProcessViewModelService
    {
        public static async Task<List<Process_Search_Model>> Search_Processes()
        {
            Process[] localAll = Process.GetProcesses();

            return await Task.FromResult(localAll.Select(la => new Process_Search_Model
            {
                Process_Name = la.ProcessName
            }).ToList());
        }
    }
}
