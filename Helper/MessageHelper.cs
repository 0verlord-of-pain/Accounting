using System.Windows.Forms;

namespace Accounting.Helper
{
    public class MessageHelper
    {
        public static void ShowInfoMessage(string message)
        {
            MessageBox.Show(
                $"Данные были успешно {message}",
                "Уведомление",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }

        public static DialogResult ShowWarningMessage(string message)
        {
            return MessageBox.Show(
                $"Вы уверено, что хотите {message} данные?",
                "Предупреждение!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}