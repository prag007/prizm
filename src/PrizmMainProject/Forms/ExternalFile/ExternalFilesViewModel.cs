﻿using Prizm.Data.DAL;
using DevExpress.Mvvm;
using Prizm.Domain.Entity;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Prizm.Main.Forms.ExternalFile;
using Prizm.Main.Commands;
using DevExpress.Mvvm.POCO;
using Prizm.Main.Forms;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.ExternalFile
{
    public class ExternalFilesViewModel: ViewModelBase, IDisposable
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(ExternalFilesViewModel));

        private readonly IFileRepository repo;
        private readonly AddExternalFileCommand addExternalFileCommand;
        private readonly DownloadFileCommand downloadFileCommand;
        private readonly ViewFileCommand viewFileCommand;
        private readonly IUserNotify notify;
        private BindingList<Prizm.Domain.Entity.File> files;
        private Prizm.Domain.Entity.File selectedFile;
        public Dictionary<string, string> FilesToAttach = new Dictionary<string, string>();
        public Guid Item { get; set; }

        [Inject]
        public ExternalFilesViewModel(IFileRepository repo, IUserNotify notify) //Guid item, 
        {
            this.repo = repo;
            this.notify = notify;
           

            addExternalFileCommand =
              ViewModelSource.Create(() => new AddExternalFileCommand(repo, this, notify));
            downloadFileCommand =
              ViewModelSource.Create(() => new DownloadFileCommand(repo, this, notify));
            viewFileCommand =
              ViewModelSource.Create(() => new ViewFileCommand(repo, this, notify));
        }

        public void RefreshFiles(Guid item)
        {
            if (item != Guid.Empty)
            {
                var fileList = repo.GetByItem(item);
                if (fileList != null)
                {
                    files = new BindingList<Prizm.Domain.Entity.File>(fileList);
                }
                else
                {
                    log.Warn(string.Format("List of attached files for Entity id:{0} is NULL", item));
                }
            }
            else
            {
                files = new BindingList<Prizm.Domain.Entity.File>();
            }
           
        }

        public BindingList<Prizm.Domain.Entity.File> Files
        {
            get { return files; }
            set
            {
                if (value != files)
                {
                    files = value;
                    RaisePropertyChanged("Files");
                }
            }
        }


        public Prizm.Domain.Entity.File SelectedFile
        {
            get { return selectedFile; }
            set
            {
                if (value != selectedFile)
                {
                    selectedFile = value;
                    RaisePropertyChanged("SelectedFile");
                }
            }
        }

        public string SelectedPath { get; set; }

         #region Commands
         public ICommand AddExternalFileCommand
        {
            get { return addExternalFileCommand; }
        }

         public ICommand DownloadFileCommand
         {
             get { return downloadFileCommand; }
         }

         public ICommand ViewFileCommand
         {
             get { return viewFileCommand; }
         }
        #endregion

        public void Dispose()
        {
            repo.Dispose();
            if (Directory.Exists(Directories.TargetPathForView))
            {
                Directory.Delete(Directories.TargetPathForView, true);
            }
        }
        
    }
}
