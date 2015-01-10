﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Prizm.Domain.Entity.Setup;
using Prizm.Domain.Entity;
using Prizm.Main.Forms.PipeMill.NewEdit.Inspections;

namespace Prizm.Main.Forms.PipeMill.NewEdit
{
    public partial class InspectionAddEditXtraForm : XtraForm
    {
        InspectionAddEditViewModel viewModel;

        public InspectionAddEditXtraForm(IList<PipeTest> tests, IList<Inspector> inspectors)
        {
            InitializeComponent();

            viewModel = new InspectionAddEditViewModel(tests, inspectors);
        }

        private void InspectionAddEditXtraForm_Load(object sender, EventArgs e)
        {
            BindToViewModel();
        }

        private void BindToViewModel()
        {
            bindingSource.DataSource = viewModel;

            inspectors.DataSource = bindingSource;
            code.Properties.DataSource = viewModel.Tests;
            //category.DataBindings.Add("EditValue", bindingSource, "Category");
            //code.DataBindings.Add("EditValue", bindingSource, "Test");
        }
    }
}