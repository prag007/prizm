﻿using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Ninject;
using Ninject.Parameters;
using Domain.Entity.Mill;

namespace PrizmMain.Forms.Railcar.NewEdit
{
    public partial class RailcarNewEditXtraForm : XtraForm
    {
        private RailcarViewModel viewModel;

        public RailcarNewEditXtraForm(string railcarNumber)
        {
            InitializeComponent();
            viewModel = (RailcarViewModel)Program.Kernel.Get<RailcarViewModel>(new ConstructorArgument("railcarNumber", railcarNumber));
        }

        public RailcarNewEditXtraForm():this("")
        {

        }

        private void RailcarNewEditXtraForm_Load(object sender, EventArgs e)
        {
            BindCommands();
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            railcarNumber.DataBindings.Add("EditValue", bindingSource, "Number");
            certificateNumber.DataBindings.Add("EditValue", bindingSource, "Certificate");
            destination.DataBindings.Add("EditValue", bindingSource, "Destination");
            shippedDate.DataBindings.Add("EditValue", bindingSource, "ShippingDate");
            pipesList.DataBindings.Add("DataSource", bindingSource, "Pipes");
            pipeNumberLookUp.Properties.DataSource = viewModel.AllPipes;
        }

        private void BindCommands()
        {
            saveButton.BindCommand(() => viewModel.SaveCommand.Execute(), viewModel.SaveCommand);
        }

        private void RailcarNewEditXtraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            viewModel.Dispose();
            viewModel = null;
        }

        private void addPipeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(pipeNumberLookUp.Text))
            {
                return;
            }
            viewModel.AddPipe((Guid)pipeNumberLookUp.EditValue);
            pipesList.RefreshDataSource();
        }

        private void removePipe_Click(object sender, EventArgs e)
        {
            string number = pipesListView.GetRowCellValue(pipesListView.FocusedRowHandle, "Number") as string;
            viewModel.RemovePipe(number);
            pipesList.RefreshDataSource();
        }
    }
}