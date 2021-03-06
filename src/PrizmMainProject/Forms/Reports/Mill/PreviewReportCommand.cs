﻿using Prizm.Data.DAL;
using Prizm.Domain.Entity.Mill;
using Prizm.Main.Commands;
using Prizm.Main.Languages;
using Prizm.Main.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Main.Forms.Reports.Mill
{
    public class PreviewReportCommand: ICommand
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(PreviewReportCommand));

        readonly IMillReportsRepository repo;
        readonly MillReportsViewModel viewModel;
        readonly IUserNotify notify;
        DataSet data;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public PreviewReportCommand(MillReportsViewModel viewModel, IMillReportsRepository repo, IUserNotify notify)
        {
            this.viewModel = viewModel;
            this.repo = repo;
            this.notify = notify;
        }

        public void Execute()
        {
            if (viewModel.StartDate > viewModel.EndDate)
            {
                notify.ShowNotify(Program.LanguageManager.GetString(StringResources.Message_FailureReportDate), 
                    Program.LanguageManager.GetString(StringResources.Message_FailureReportDateHeader));
            }
            try
            {
                if (viewModel.SelectedReportType == MillReportType.ByProducing)
                {
                    data = repo.GetPipes(viewModel.StartDate, viewModel.EndDate);
                    AdditionToTheReport report = new AdditionToTheReport();
                    BindingList<double> counts = repo.CountPipe(viewModel.StartDate, viewModel.EndDate);
                    report.PipesCount = counts[0];
                    report.PipesLength = counts[1];
                    report.PipesWeight = counts[2];
                    report.DataSource = data;
                    report.CreateDocument();
                    viewModel.PreviewSource = report;
                }
                else if (viewModel.SelectedReportType == MillReportType.General)
                {
                    data = repo.CountWeldInf(viewModel.StartDate, viewModel.EndDate);
                    GeneralInformationXtraReport report = new GeneralInformationXtraReport();
                    report.DataSource = data;
                    report.CreateDocument();
                    viewModel.PreviewSource = report;
                }
                else if (viewModel.SelectedReportType == MillReportType.ByShipped)
                {
                    LoadingXtraReport report = new LoadingXtraReport();
                    report.DataSource = repo.GetReleaseNotes(viewModel.StartDate, viewModel.EndDate);
                    report.CreateDocument();
                    viewModel.PreviewSource = report;
                }
                else 
                { 
                    data = repo.GetPipesByStatus(viewModel.StartDate, viewModel.EndDate, viewModel.SearchIds, viewModel.SelectedReportType, viewModel.SearchStatuses, true);
                    MillReportsXtraReport report = new MillReportsXtraReport();
                    report.DataSource = data;
                    report.CreateDocument();
                    viewModel.PreviewSource = report;
                }
            }
            catch (RepositoryException ex)
            {
                log.Error(string.Concat(ex.InnerException.Message, ex.Message));
                notify.ShowFailure(ex.InnerException.Message, ex.Message);
            }
          
        }
   
        public bool CanExecute()
        {
            return true;
        }

    }
}
