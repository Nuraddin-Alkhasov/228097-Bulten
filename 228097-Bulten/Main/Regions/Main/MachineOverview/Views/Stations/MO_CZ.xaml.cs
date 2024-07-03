using HMI.CO.General;
using HMI.CO.Trend;
using HMI.Resources.UserControls.MO;
using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.MainRegion.MO
{

    [ExportView("MO_CZ")]
    public partial class MO_CZ
    {
        BackgroundWorker AddObjects = new BackgroundWorker();
        BackgroundWorker ClearObjects = new BackgroundWorker();
        IVariableService VS = ApplicationService.GetService<IVariableService>();
        public MO_CZ()
        {
            InitializeComponent();
            Modus = "CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Production.to.Mode.State";
            Clocked = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ HMI.PC.Clocked";

            ClearObjects.DoWork += ClearObjects_DoWork;
            ClearObjects.RunWorkerCompleted += ClearObjects_RunWorkerCompleted;

            AddObjects.WorkerSupportsCancellation = true;
            AddObjects.DoWork += AddObjects_DoWork;
            AddObjects.RunWorkerCompleted += AddObjects_RunWorkerCompleted;
        }

        private IVariable IVModus;
        public string Modus
        {
            get { return ""; }
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    IVModus = VS.GetVariable(value);
                    IVModus.Change += IVModus_ValueChanged;
                }
            }
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "Trend",
            new TrendData()
            {
                ArchiveName = "CZ1",
                TrendName_1 = "In",
                CurveTag_1 = "@TrendSystem.Text18",
                TrendName_2 = "Out",
                CurveTag_2 = "@TrendSystem.Text19",
                Header = "@TrendSystem.Text7",
                Min = 0,
                Max = 50,
                BackViewName = "MO_CZ"
            });
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "Trend",
            new TrendData()
            {
                ArchiveName = "CZ2",
                TrendName_1 = "In",
                CurveTag_1 = "@TrendSystem.Text18",
                TrendName_2 = "Out",
                CurveTag_2 = "@TrendSystem.Text19",
                Header = "@TrendSystem.Text20",
                Min = 0,
                Max = 50,
                BackViewName = "MO_CZ"
            });
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "Trend",
            new TrendData()
            {
                ArchiveName = "CZ3",
                TrendName_1 = "In",
                CurveTag_1 = "@TrendSystem.Text18",
                TrendName_2 = "Out",
                CurveTag_2 = "@TrendSystem.Text19",
                Header = "@TrendSystem.Text21",
                Min = 0,
                Max = 50,
                BackViewName = "MO_CZ"
            });
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "Trend",
            new TrendData()
            {
                ArchiveName = "CZ4",
                TrendName_1 = "In",
                CurveTag_1 = "@TrendSystem.Text18",
                TrendName_2 = "Out",
                CurveTag_2 = "@TrendSystem.Text19",
                Header = "@TrendSystem.Text22",
                Min = 0,
                Max = 50,
                BackViewName = "MO_CZ"
            });
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

  
      
        private void IVModus_ValueChanged(object sender, VariableEventArgs e)
        {
            if (e.Quality.Data == DataQuality.Good)
            {
                Mod.Visibility = Visibility.Visible;
                switch ((byte)e.Value)
                {
                    case 1:
                        Mod.Background = (Brush)Application.Current.FindResource("FP_Green_Gradient");
                        txt.LocalizableText = "@Lists.Modus.Text1";
                        break;
                    case 2:
                        Mod.Background = (Brush)Application.Current.FindResource("FP_Yellow_Gradient");
                        txt.LocalizableText = "@Lists.Modus.Text2"; break;
                    case 3:
                        Mod.Background = (Brush)Application.Current.FindResource("FP_Yellow_Gradient");
                        txt.LocalizableText = "@Lists.Modus.Text3"; break;
                    default: Mod.Visibility = Visibility.Collapsed; break;
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
                }
               // IVClocked.Value = false;
            }
        }




        private void ClearObjects_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!AddObjects.IsBusy)
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
           
            for (int i = 7; i >= 0; i--)
            {
                if (AddObjects.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                short Coord = (short)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i.ToString() + "].Status.Coordinate");

                CZTray T = null;
                Dispatcher.InvokeAsync(delegate
                {
                    T = GetCZTray(i);

                    switch (Coord)
                    {
                        case 0: T.Margin = new Thickness(0, 500, 115, 0); break;
                        case 1: T.Margin = new Thickness(0, 500, 277, 0); break;
                        case 2: T.Margin = new Thickness(0, 500, 448, 0); break;
                        case 3: T.Margin = new Thickness(0, 500, 610, 0); break;
                        case 4: T.Margin = new Thickness(0, 500, 782, 0); break;
                        case 5: T.Margin = new Thickness(0, 500, 944, 0); break;
                        case 6: T.Margin = new Thickness(0, 500, 1116, 0); break;
                        case 7: T.Margin = new Thickness(0, 500, 1278, 0); break;
                    }

                    T.HorizontalAlignment = HorizontalAlignment.Right;
                    T.VerticalAlignment = VerticalAlignment.Top;

                    Trays.Children.Add(T);
                });

              
   

                uint ChargeNr = (uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i.ToString() + "].PD.Charge.Data.Charge");

                if (ChargeNr == 1)
                {
                    Dispatcher.InvokeAsync(delegate
                    {
                        TrackingR TT = new TrackingR()
                        {
                            Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                        };
                        switch (Coord)
                        {
                            case 0: TT.Margin = new Thickness(0, 820, 150, 0); break;
                            case 1: TT.Margin = new Thickness(0, 820, 315, 0); break;
                            case 2: TT.Margin = new Thickness(0, 820, 485, 0); break;
                            case 3: TT.Margin = new Thickness(0, 820, 650, 0); break;
                            case 4: TT.Margin = new Thickness(0, 820, 820, 0); break;
                            case 5: TT.Margin = new Thickness(0, 820, 985, 0); break;
                            case 6: TT.Margin = new Thickness(0, 820, 1155, 0); break;
                            case 7: TT.Margin = new Thickness(0, 820, 1320, 0); break;

                        }
                        TT.VerticalAlignment = VerticalAlignment.Top;
                        TT.HorizontalAlignment = HorizontalAlignment.Right;
                        Trays.Children.Add(TT);

                    });



                }

                Thread.Sleep(250);
            }
        }

        private CZTray GetCZTray(int i)
        {
            return new CZTray()
            {
                IsTray = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.isTray",
                IsMaterial = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.isMaterial",
                SetLayer = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.Layers.Set",
                ActualLayer = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Charge.Layers.Actual",
               
                IsDischarge = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.Functions.Discharge",
                IsWatch = "CPU1.PLC.Blocks.04 Tray handling.07 CZ.00 Main.DB CZ PD.Place[" + i + "].PD.Tray.Functions.Watch",
                Station = 15,
                Place = i,
                Coord = i,
                Type = "Tray",
                CPU = "CPU1",
                Header = "@Status.Text" + (63 + i).ToString()
            };
        }


    }
}




