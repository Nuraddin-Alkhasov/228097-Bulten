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

namespace HMI.MainRegion.MO.Views
{

    [ExportView("MO_HZ")]
    public partial class MO_HZ
    {

        BackgroundWorker AddObjects = new BackgroundWorker();
        BackgroundWorker ClearObjects = new BackgroundWorker();
        IVariableService VS = ApplicationService.GetService<IVariableService>();

        private IVariable IVModus;

        public MO_HZ()
        {
            InitializeComponent();
            Modus = "CPU1.PLC.Blocks.00 Main.02 HMI.00 Main.DB HMI Main.Production.to.Mode.State";
            Clocked = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 HMI.PC.Clocked";

            ClearObjects.DoWork += ClearObjects_DoWork;
            ClearObjects.RunWorkerCompleted += ClearObjects_RunWorkerCompleted;
            
            AddObjects.WorkerSupportsCancellation = true;
            AddObjects.DoWork += AddObjects_DoWork;
            AddObjects.RunWorkerCompleted += AddObjects_RunWorkerCompleted;
           

        }

       

       


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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ApplicationService.SetView("MainRegion", "Trend",
            new TrendData()
            {
                ArchiveName = "HZ1",
                TrendName_1 = "AV",
                CurveTag_1 = "@TrendSystem.Text1",
                TrendName_2 = "SV",
                CurveTag_2 = "@TrendSystem.Text2",
                Header = "@TrendSystem.Text6",
                Min = 0,
                Max = 300,
                BackViewName = "MO_HZ"
            });
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
                IVClocked.Value = false;
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

            for (int i = 9; i >= 0; i--)
            {
                if (AddObjects.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                short Coord = (short)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].Status.Coordinate");
                HZTray T = null;
                Dispatcher.InvokeAsync(delegate
                {
                    T = GetHZTray(i, Coord);

                    switch (Coord)
                    {
                        case 0: T.Margin = new Thickness(0, 698, 668, 0); break;
                        case 1: T.Margin = new Thickness(0, 698, 942, 0); break;
                        case 3: T.Margin = new Thickness(0, 563, 668, 0); break;
                        case 2: T.Margin = new Thickness(0, 563, 942, 0); break;
                        case 4: T.Margin = new Thickness(0, 428, 668, 0); break;
                        case 5: T.Margin = new Thickness(0, 428, 942, 0); break;
                        case 7: T.Margin = new Thickness(0, 293, 668, 0); break;
                        case 6: T.Margin = new Thickness(0, 293, 942, 0); break;
                        case 8: T.Margin = new Thickness(0, 158, 668, 0); break;
                        case 9: T.Margin = new Thickness(0, 158, 942, 0); break;
                    }

                    T.HorizontalAlignment = HorizontalAlignment.Right;
                    T.VerticalAlignment = VerticalAlignment.Top;

                    Trays.Children.Add(T);
                });

                uint ChargeNr = (uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Charge.Data.Charge");
   
                if (ChargeNr == 1)
                {

                    Dispatcher.InvokeAsync(delegate
                    {

                        TrackingL TL = new TrackingL();
                        TrackingR TR = new TrackingR();

                        switch (Coord)
                        {
                            case 0:
                                TL = new TrackingL()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TL.X2 = 0; TL.Y1 = -2; TL.X1 = 200; TL.Y2 = 40; TL.Width = 340; TL.Margin = new Thickness(0, 644, 340, 0); 
                                break;
                            case 1:
                                TR = new TrackingR()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TR.X2 = 0; TR.Y1 = 40; TR.X1 = 150; TR.Y2 = -2; TR.Width = 350; TR.Margin = new Thickness(0, 644, 1156, 0); break;
                            case 2:
                                TR = new TrackingR()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TR.X2 = 0; TR.Y1 = 40; TR.X1 = 150; TR.Y2 = -2; TR.Width = 350; TR.Margin = new Thickness(0, 509, 1156, 0); break;
                            case 3:
                                TL = new TrackingL()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TL.X2 = 0; TL.Y1 = -2; TL.X1 = 200; TL.Y2 = 40; TL.Width = 340; TL.Margin = new Thickness(0, 509, 340, 0); break;
                          
                            case 4:
                                TL = new TrackingL()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TL.X2 = 0; TL.Y1 = -2; TL.X1 = 200; TL.Y2 = 40; TL.Width = 340; TL.Margin = new Thickness(0, 374, 340, 0); break;
                            case 5:
                                TR = new TrackingR()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TR.X2 = 0; TR.Y1 = 40; TR.X1 = 150; TR.Y2 = -2; TR.Width = 350; TR.Margin = new Thickness(0, 374, 1156, 0); break;
                            case 6:
                                TR = new TrackingR()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TR.X2 = 0; TR.Y1 = 40; TR.X1 = 150; TR.Y2 = -2; TR.Width = 350; TR.Margin = new Thickness(0, 239, 1156, 0); break;
                            case 7:
                                TL = new TrackingL()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TL.X2 = 0; TL.Y1 = -2; TL.X1 = 200; TL.Y2 = 40; TL.Width = 340; TL.Margin = new Thickness(0, 239, 340, 0); break;
                            
                            case 8:
                                TL = new TrackingL()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TL.X2 = 0; TL.Y1 = -2; TL.X1 = 200; TL.Y2 = 40; TL.Width = 340; TL.Margin = new Thickness(0, 104, 340, 0); break;
                            case 9:
                                TR = new TrackingR()
                                {
                                    Data = new Track((uint)ApplicationService.GetVariableValue("CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i.ToString() + "].PD.Header.BoxId"))
                                };
                                TR.X2 = 0; TR.Y1 = 40; TR.X1 = 150; TR.Y2 = -2; TR.Width = 350; TR.Margin = new Thickness(0, 104, 1156, 0); break;
                        }

                        TR.Height = TL.Height = 100;
                        TR.VerticalAlignment = TL.VerticalAlignment = VerticalAlignment.Top;
                        TR.HorizontalAlignment = TL.HorizontalAlignment = HorizontalAlignment.Right;

                        if (Coord == 0 || Coord == 3 || Coord == 4 || Coord == 7 || Coord == 8) 
                        {
                            Trays.Children.Add(TL);
                        }
                        else { Trays.Children.Add(TR); }
                        
                    });

                }
                Thread.Sleep(250);
            }
        }


        private HZTray GetHZTray(int i, int coord)
        {
            return new HZTray()
            {
                IsTray = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Tray.isTray", 
                IsMaterial = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Charge.isMaterial",
                SetLayer = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Charge.Layers.Set",
                ActualLayer = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Charge.Layers.Actual",
                
                IsDischarge = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Tray.Functions.Discharge",
                IsWatch = "CPU1.PLC.Blocks.04 Tray handling.05 HZ 1.00 Main.DB HZ 1 PD.Place[" + i + "].PD.Tray.Functions.Watch",
                Station = 13,
                Place = i,
                Coord= i ,
                Type = "Tray",
                CPU="CPU1",
                Header = "@Status.Text" + (53 + i).ToString()

            };
        }
    }
}



