using HMI.CO.General;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Resources.UserControls.MO
{
    public partial class MV_CZ : UserControl
    {
        BackgroundWorker AddObjects = new BackgroundWorker();
        BackgroundWorker ClearObjects = new BackgroundWorker();
        IVariableService VS = ApplicationService.GetService<IVariableService>();
        public MV_CZ()
        {
            InitializeComponent();
            CZ1Temp1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.01 Air 1.DB CZ Air 1 HMI.Actual.Temperature 1";
            CZ1Temp2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.01 Air 1.DB CZ Air 1 HMI.Actual.Temperature 2";
            CZ1Fan1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.01 Air 1.DB CZ Air 1 HMI.Actual.Supply fan.Motor.Actual.Speed 2";
            CZ1Fan2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.01 Air 1.DB CZ Air 1 HMI.Actual.Exhaust fan.Motor.Actual.Speed 2";   
            CZ2Temp1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.02 Air 2.DB CZ Air 2 HMI.Actual.Temperature 1";
            CZ2Temp2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.02 Air 2.DB CZ Air 2 HMI.Actual.Temperature 2";
            CZ2Fan1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.02 Air 2.DB CZ Air 2 HMI.Actual.Supply fan.Motor.Actual.Speed 2";
            CZ2Fan2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.02 Air 2.DB CZ Air 2 HMI.Actual.Exhaust fan.Motor.Actual.Speed 2";
            CZ3Temp1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.03 Air 3.DB CZ Air 3 HMI.Actual.Temperature 1";
            CZ3Temp2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.03 Air 3.DB CZ Air 3 HMI.Actual.Temperature 2";
            CZ3Fan1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.03 Air 3.DB CZ Air 3 HMI.Actual.Supply fan.Motor.Actual.Speed 2";
            CZ3Fan2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.03 Air 3.DB CZ Air 3 HMI.Actual.Exhaust fan.Motor.Actual.Speed 2";
            CZ4Temp1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.04 Air 4.DB CZ Air 4 HMI.Actual.Temperature 1";
            CZ4Temp2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.04 Air 4.DB CZ Air 4 HMI.Actual.Temperature 2";
            CZ4Fan1 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.04 Air 4.DB CZ Air 4 HMI.Actual.Supply fan.Motor.Actual.Speed 2";
            CZ4Fan2 = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.04 Air 4.DB CZ Air 4 HMI.Actual.Exhaust fan.Motor.Actual.Speed 2";

            Clocked = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ HMI.PC.Clocked";

            ClearObjects.DoWork += ClearObjects_DoWork;
            ClearObjects.RunWorkerCompleted += ClearObjects_RunWorkerCompleted;

            AddObjects.WorkerSupportsCancellation = true;
            AddObjects.DoWork += AddObjects_DoWork;
            AddObjects.RunWorkerCompleted += AddObjects_RunWorkerCompleted;
        }

        private IVariable IVClocked;

        public string Clocked
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    IVClocked = VS.GetVariable(value);
                    IVClocked.Change += IVClocked_ValueChanged;
                }
            }
        }
        public string CZ1Temp1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ1T1.VariableName = value;
                }
            }
        }
        public string CZ1Temp2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ1T2.VariableName = value;
                }
            }
        }


        public string CZ2Temp1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ2T1.VariableName = value;
                }
            }
        }
        public string CZ2Temp2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ2T2.VariableName = value;
                }
            }
        }
        public string CZ3Temp1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ3T1.VariableName = value;
                }
            }
        }
        public string CZ3Temp2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ3T2.VariableName = value;
                }
            }
        }
        public string CZ4Temp1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ4T1.VariableName = value;
                }
            }
        }
        public string CZ4Temp2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ4T2.VariableName = value;
                }
            }
        }
        public string CZ1Fan1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ1F1.VariableName = value;
                }
            }
        }
        public string CZ1Fan2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ1F2.VariableName = value;
                }
            }
        }
        public string CZ2Fan1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ2F1.VariableName = value;
                }
            }
        }
        public string CZ2Fan2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ2F2.VariableName = value;
                }
            }
        }
        public string CZ3Fan1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ3F1.VariableName = value;
                }
            }
        }
        public string CZ3Fan2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ3F2.VariableName = value;
                }
            }
        }
        public string CZ4Fan1
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ4F1.VariableName = value;
                }
            }
        }
        public string CZ4Fan2
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    CZ4F2.VariableName = value;
                }
            }
        }

        private void IVClocked_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                if (this.IsVisible)
                {
                    if ((bool)e.Value && Trays.IsLoaded)
                    {
                       // IVClocked.Value = false;
                        if (AddObjects.IsBusy)
                        {
                            AddObjects.CancelAsync();
                        }
                        else
                        {
                            if(!ClearObjects.IsBusy)
                                ClearObjects.RunWorkerAsync();
                        }
                    }
                }
            }
        }
        private void ClearObjects_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(!AddObjects.IsBusy)
                AddObjects.RunWorkerAsync();
        }
        private void ClearObjects_DoWork(object sender, DoWorkEventArgs e)
        {

            Dispatcher.InvokeAsync(delegate
            {
                Trays.Children.Clear();
            });

            Thread.Sleep(250);

        }

        private void AddObjects_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                //
            }
            else if (e.Cancelled)
            {
                ClearObjects.RunWorkerAsync();
            }
            else
            {

            }
        }
        private void AddObjects_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 7; i++)
            {
                if (AddObjects.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                short Coord = (short)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i.ToString() + "].Status.Coordinate");

               

                MVTray T = null;
               
                Dispatcher.InvokeAsync(delegate
                {

                    T = GetCZTray(i);
                    switch (Coord)
                    {
                        case 0: T.Margin = new Thickness(0, 135, 6, 0); break;
                        case 1: T.Margin = new Thickness(0, 135, 70, 0); break;
                        case 2: T.Margin = new Thickness(0, 135, 137, 0); break;
                        case 3: T.Margin = new Thickness(0, 135, 201, 0); break;
                        case 4: T.Margin = new Thickness(0, 135, 268, 0); break;
                        case 5: T.Margin = new Thickness(0, 135, 332, 0); break;
                        case 6: T.Margin = new Thickness(0, 135, 399, 0); break;
                        case 7: T.Margin = new Thickness(0, 135, 463, 0); break;
                    }

                    T.HorizontalAlignment = HorizontalAlignment.Right;
                    T.VerticalAlignment = VerticalAlignment.Top;

                    Trays.Children.Add(T);
                });
                Thread.Sleep(250);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowMOElement(this);
        }
     
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "MO_CZ");
        }
        private void Trays_Loaded(object sender, RoutedEventArgs e)
        {

            if (AddObjects.IsBusy)
            {
                AddObjects.CancelAsync();
            }
            else
            {
                if (!ClearObjects.IsBusy)
                    ClearObjects.RunWorkerAsync();
            }
        }

        private MVTray GetCZTray(int i)
        {
            return new MVTray()
            {
                IsTray = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.isTray",
                IsMaterial = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.isMaterial",
                SetLayer = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.Layers.Set",
                ActualLayer = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.Layers.Actual",
               
                IsDischarge = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.Functions.Discharge",
                IsWatch = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.Functions.Watch",
                Station = 15,
                Place = i,
                Type = "Tray",
                CPU = "CPU1",
                Header = "@Status.Text" + (63 + i).ToString()
            };
        }
    }
}
