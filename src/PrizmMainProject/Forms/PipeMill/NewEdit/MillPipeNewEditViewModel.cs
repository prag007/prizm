﻿using Data.DAL.Mill;
using DevExpress.Mvvm.POCO;
using Ninject;
using PrizmMain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm;
using Domain.Entity.Mill;
using Domain.Entity.Setup;


namespace PrizmMain.Forms.PipeMill.NewEdit
{
    public class MillPipeNewEditViewModel: ViewModelBase, IDisposable
    {

        private readonly IMillRepository repoMill;

        private IList<Domain.Entity.Mill.Heat> heats;
        private IList<PurchaseOrder> purchaseOrders;
        private IList<PipeMillSizeType> pipeTypes;

        private readonly MillPipeNewEditCommand newEditCommand;
        private readonly ExtractHeatsCommand extractHeatsCommand;
        private readonly ExtractPurchaseOrderCommand extractPurchaseOrderCommand;
        private readonly ExtractPipeTypeCommand extractPipeTypeCommand;

        public Pipe Pipe { get; set; }


        [Inject]
        public MillPipeNewEditViewModel(IMillRepository repoMill, Guid pipeId)
        {
            this.repoMill = repoMill;

            newEditCommand =
                ViewModelSource.Create(() => new MillPipeNewEditCommand(this, repoMill.RepoPipe));

            extractHeatsCommand =
                ViewModelSource.Create(() => new ExtractHeatsCommand(this, repoMill.RepoHeat));

            extractPurchaseOrderCommand =
                ViewModelSource.Create(() => new ExtractPurchaseOrderCommand(this, repoMill.RepoPurchaseOrder));

            extractPipeTypeCommand =
                ViewModelSource.Create(() => new ExtractPipeTypeCommand(this, repoMill.RepoPipeType));

            if (pipeId == Guid.Empty)
            {
                NewPipe();
            }
            else
            {
                extractPurchaseOrderCommand.Execute();
                extractHeatsCommand.Execute();
                extractPipeTypeCommand.Execute();

                Pipe = repoMill.RepoPipe.Get(pipeId);
            }
        }

        public IList<PurchaseOrder> PurchaseOrders
        {
            get { return purchaseOrders; }
            set
            {
                if (value != purchaseOrders)
                {
                    purchaseOrders = value;
                    RaisePropertyChanged("PurchaseOrders");
                }
            }
        }
        
        public IList<Domain.Entity.Mill.Heat> Heats
        {
            get { return heats; }
            set
            {
                if (value != heats)
                {
                    heats = value;
                    RaisePropertyChanged("Heats");
                }
            }
        }

        public IList<PipeMillSizeType> PipeTypes
        {
            get { return pipeTypes; }
            set
            {
                if (value != pipeTypes)
                {
                    pipeTypes = value;
                    RaisePropertyChanged("PipeTypes");
                }
            }
        }

        #region Pipe

        public bool PipeIsActive
        {
            get { return Pipe.IsActive; }
            set
            {
                if (value != Pipe.IsActive)
                {
                    Pipe.IsActive = value;
                    RaisePropertyChanged("PipeIsActive");
                }
            }
        }

        public string Number
        {
            get { return Pipe.Number; }
            set
            {
                if (value != Pipe.Number)
                {
                    Pipe.Number = value;
                    RaisePropertyChanged("Number");
                }
            }
        }

        public int Diameter
        {
            get { return Pipe.Diameter; }
            set
            {
                if (value != Pipe.Diameter)
                {
                    Pipe.Diameter = value;
                    RaisePropertyChanged("Diameter");
                }
            }
        }

        public int Length
        {
            get { return Pipe.Length; }
            set
            {
                if (value != Pipe.Length)
                {
                    Pipe.Length = value;
                    RaisePropertyChanged("Length");
                }
            }
        }

        public int Weight
        {
            get { return Pipe.Weight; }
            set
            {
                if (value != Pipe.Weight)
                {
                    Pipe.Weight = value;
                    RaisePropertyChanged("Weight");
                }
            }
        }

        public int WallThickness
        {
            get { return Pipe.WallThickness; }
            set
            {
                if (value != Pipe.WallThickness)
                {
                    Pipe.WallThickness = value;
                    RaisePropertyChanged("WallThickness");
                }
            }
        }

        public string Mill
        {
            get { return Pipe.Mill; }
            set
            {
                if (value != Pipe.Mill)
                {
                    Pipe.Mill = value;
                    RaisePropertyChanged("Mill");
                }
            }
        }

        #endregion

        #region PurchaseOrder
        
        public PurchaseOrder PipePurchaseOrder
        {
            get { return Pipe.PurchaseOrder; }
            set
            {
                if (value != Pipe.PurchaseOrder)
                {
                    Pipe.PurchaseOrder = value;
                    RaisePropertyChanged("PipePurchaseOrder");
                }
            }
        }

        public DateTime PurchaseOrderDate
        {
            get 
            {
                if (PipePurchaseOrder == null)
                {
                    return DateTime.Now;
                }

                return PipePurchaseOrder.Date; 
            }
            set
            {
                if (value != PipePurchaseOrder.Date)
                {
                    PipePurchaseOrder.Date = value;
                    RaisePropertyChanged("PurchaseOrderDate");
                }
            }
        }

        #endregion

        #region Plate

        public Plate Plate
        {
            get { return Pipe.Plate; }
            set
            {
                if (value != Pipe.Plate)
                {
                    Pipe.Plate = value;
                    RaisePropertyChanged("Plate");
                }
            }
        }

        public string PlateNumber
        {
            get { return Plate.Number; }
            set
            {
                if (value != Plate.Number)
                {
                    Plate.Number = value;
                    RaisePropertyChanged("PlateNumber");
                }
            }
        }

        public int PlateThickness
        {
            get { return Plate.Thickness; }
            set
            {
                if (value != Plate.Thickness)
                {
                    Plate.Thickness = value;
                    RaisePropertyChanged("PlateThickness");
                }
            }
        }

        #endregion

        #region Heat

        public Domain.Entity.Mill.Heat Heat
        {
            get { return Plate.Heat; }
            set
            {
                if (value != Plate.Heat)
                {
                    Plate.Heat = value;
                    RaisePropertyChanged("Heat");
                }
            }
        }

        public string SteelGrade
        {
            get
            {
                if (Heat == null)
                {
                    return string.Empty;
                }
                return Heat.SteelGrade;
            }
            set
            {
                if (value != Heat.SteelGrade)
                {
                    Heat.SteelGrade = value;
                    RaisePropertyChanged("SteelGrade");
                }
            }
        }

        #endregion

        #region Railcar
              public Domain.Entity.Mill.Railcar Railcar
              {
                  get { return Pipe.Railcar; }
                  set
                  {
                      if (value != Pipe.Railcar)
                      {
                          Pipe.Railcar = value;
                          RaisePropertyChanged("Railcar");
                      }
                  }
              }

              public string RailcarNumber
              {
                  get
                  {
                      if (Railcar == null)
                      {
                          return string.Empty;
                      }
                      return Railcar.Number;
                  }

                  set
                  {
                      if (value != Railcar.Number)
                      {
                          Railcar.Number = value;
                          RaisePropertyChanged("RailcarNumber");
                      }
                  }
              }

              public string RailcarCertificate
              {
                  get
                  {
                      if (Railcar == null)
                      {
                          return string.Empty;
                      }
                      return Railcar.Certificate;
                  }
                  set
                  {
                      if (value != Railcar.Certificate)
                      {
                          Railcar.Certificate = value;
                          RaisePropertyChanged("RailcarCertificate");
                      }
                  }
              }

              public string RailcarDestination
              {
                  get
                  {
                      if (Railcar == null)
                      {
                          return string.Empty;
                      }
                      return Railcar.Destination;
                  }
                  set
                  {
                      if (value != Railcar.Destination)
                      {
                          Railcar.Destination = value;
                          RaisePropertyChanged("RailcarDestination");
                      }
                  }
              }

              public DateTime RailcarShippingDate
              {
                  get
                  {
                      if (Railcar == null)
                      {
                          return DateTime.Now;
                      }

                      return Railcar.ShippingDate.Value;
                  }
                  //set
                  //{
                  //    if (value != Railcar.ShippingDate)
                  //    {
                  //        Railcar.ShippingDate = value;
                  //        RaisePropertyChanged("RailcarShippingDate");
                  //    }
                  //}
              }
              #endregion

        #region PipeMillSizeType

          public PipeMillSizeType PipeMillSizeType
          {
              get { return Pipe.Type; }
              set
              {
                  if (value != Pipe.Type)
                  {
                      Pipe.Type = value;
                      RaisePropertyChanged("PipeMillSizeType");
                  }
             }
        }


        #endregion

        public ICommand NewEditCommand
        {
            get { return newEditCommand; }
        }

        public ICommand ExtractHeatsCommand
        {
            get { return extractHeatsCommand; }
        }

        public ICommand ExtractPurchaseOrderCommand
        {
            get { return extractPurchaseOrderCommand; }
        }
        

        public void NewPipe()
        {
            extractPurchaseOrderCommand.Execute();
            extractHeatsCommand.Execute();
            extractPipeTypeCommand.Execute();

            this.Pipe = new Pipe();

            this.PlateNumber = string.Empty;
            this.Pipe.Status = string.Empty;
            this.Number = string.Empty;
            this.Mill = string.Empty;
            this.WallThickness = 0;
            this.Weight = 0;
            this.Length = 0;
            this.Diameter = 0;

            this.PipePurchaseOrder = new PurchaseOrder();
            this.PipePurchaseOrder.Number = string.Empty;
            this.PipePurchaseOrder.Date = DateTime.Now;

            //TODO: Please change set the default value 
            // after introduction the logic of new heat creating 
            Heat = Heats[0];

            //TODO: Please change set the default value 
            // after introduction the logic of new heat PipePurchaseOrder 
            PipePurchaseOrder = purchaseOrders[0];

            //TODO: Please change set the default value 
            // after introduction the logic of new PipeTypes creating 
            PipeMillSizeType = PipeTypes[0];
        }

        public void Dispose()
        {
            repoMill.Dispose();
        }

    }
}
