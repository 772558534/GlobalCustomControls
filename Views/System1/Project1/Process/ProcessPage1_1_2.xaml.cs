using System.Windows.Controls;

namespace GlobalCustomControls
{
    /// <summary>
    /// ProcessPage1_1_1.xaml 的交互逻辑
    /// </summary>
    public partial class ProcessPage1_1_2 : UserControl

    {
        public ProcessPage1_1_2()
        {
            InitializeComponent();
            DataContext = new ProcessPage1_1_2ViewModel();
        }
    }
}
