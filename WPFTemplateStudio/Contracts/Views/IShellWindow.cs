using System.Windows.Controls;

namespace WPFTemplateStudio.Contracts.Views;

public interface IShellWindow
{
    Frame GetNavigationFrame();

    void ShowWindow();

    void CloseWindow();
}
