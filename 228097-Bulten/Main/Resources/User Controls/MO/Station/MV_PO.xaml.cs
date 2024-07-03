using HMI.CO.General;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using VisiWin.ApplicationFramework;
using VisiWin.DataAccess;

namespace HMI.Resources.UserControls.MO
{
    public partial class MV_PO : UserControl
    {
        public MV_PO()
        {
            InitializeComponent();
            Traction = "CPU1.PLC.Blocks.04 Tray handling.08 PO.01 Traction.DB PO Traction HMI.Actual.Traction.Motor.Actual.Position";
        }
        IVariableService VS = ApplicationService.GetService<IVariableService>();

        IVariable IVTraction;
        public string Traction
        {
             get { return ""; } 
            set
            {
                if (VS.IsExistingVariable(value))
                {
                    IVTraction = VS.GetVariable(value);
                    IVTraction.Change += IVTraction_Change;
                }
            }
        }
        double OldTraction = 0;
        private void IVTraction_Change(object sender, VariableEventArgs e)
        {
            double pos = 0;
            if ((float)e.Value > 0)
            {
                pos = Math.Round(((float)e.Value) * 0.068139);
            }
          
            
            if (OldTraction != pos)
            {
                Tray.Margin = new Thickness(50 + pos, 3, 0, 0);
                OldTraction = pos;
             
            }
        
        }

        
   

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            new ObjectAnimator().ShowMOElement(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new SP
            {
                CPU = "CPU1",
                Station = 17,
                Header = "@Status.Text72",
                Type = "Tray"
            }.Open();
        }
    }
}
