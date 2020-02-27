using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator.Utils
{
    class Alert
    {
        public static Task Display(string title, string message, string buttonOk)
        {
            return Application.Current.MainPage.DisplayAlert(title, message, buttonOk);
        }
    }
}
