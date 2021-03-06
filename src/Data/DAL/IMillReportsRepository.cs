﻿using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL
{
    public interface IMillReportsRepository : IDisposable
    {
        DataSet GetPipesByStatus(DateTime startDate, DateTime finalDate, List<Guid> categories, MillReportType reportType, List<string> statuses, bool previewFlag = false);
        DataTable GetPipelineElements();
        DataTable GetPipelineElements(string sqlQueryString);
        DataSet GetUsedProducts(int startPK, int endPK, string queryString);
        DataSet GetPipesFromInspection(DateTime startDate, DateTime finalDate);
        DataSet GetPipes(DateTime startDate, DateTime finalDate);
        BindingList<double> CountPipe(DateTime startDate, DateTime finalDate);
        DataTable GetPipelineElements(string pipeNumber, string[] pipeTypes);
        DataSet CountWeldInf(DateTime startDate, DateTime finalDate);
        BindingList<int> GetAllKP();
        DataTable GetPipelineElements(DateTime? weldDateFrom, DateTime? weldDateTo);
        DataSet GetReleaseNotes(DateTime startDate, DateTime finalDate);
    }
}
