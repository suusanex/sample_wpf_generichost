using System.Windows.Controls;

namespace WPFTemplateStudio.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);

    Page GetPage(string key);
}
