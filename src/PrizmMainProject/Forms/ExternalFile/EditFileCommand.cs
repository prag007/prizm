using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm.DataAnnotations;
using Prizm.Data.DAL;
using Prizm.Main.Commands;
using Prizm.Main.Common;

namespace Prizm.Main.Forms.ExternalFile
{
    public class EditFileCommand : ICommand
    {
        private readonly IFileRepository repo;
        private readonly ExternalFilesViewModel viewModel;
        private readonly IUserNotify notify;

        public event RefreshVisualStateEventHandler RefreshVisualStateEvent = delegate { };

        public EditFileCommand(IFileRepository repo, ExternalFilesViewModel viewModel, IUserNotify notify)
        {
            this.repo = repo;
            this.viewModel = viewModel;
            this.notify = notify;
        }

        [Command(UseCommandManager = false)]
        public void Execute()
        {
            if (CanExecute())
            {
                string distFile = string.Format("{0}{1}", Directories.FilesToAttachFolder, viewModel.SelectedFile.NewName);
                if (File.Exists(distFile))
                {
                    File.Copy(viewModel.SelectedPath, distFile, true);
                    viewModel.SelectedFile.FileName = Path.GetFileName(viewModel.SelectedPath);
                    viewModel.SelectedFile.UploadDate = DateTime.Now;
                }
            }
        }

        public bool CanExecute()
        {
            return viewModel.SelectedFile.NewName != null;
        }
    }
}
