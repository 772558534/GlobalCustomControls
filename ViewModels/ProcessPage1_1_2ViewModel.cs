using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Data.SqlClient;
using NLog;

namespace GlobalCustomControls
{
    public partial class ProcessPage1_1_2ViewModel : BaseViewModel
    {
        public ProcessPage1_1_2ViewModel()
        {

        }

        [RelayCommand]
        void Log()
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Info("my info message");

            string sql = "server=jiashili-PC;Database=test;user id=sa;password=123456;Encrypt=True;TrustServerCertificate=True;";

            using SqlConnection sqlcon = new SqlConnection(sql);
            sqlcon.Open();
        }


        [RelayCommand] void Reset()
        {
            
        }
    }
}
