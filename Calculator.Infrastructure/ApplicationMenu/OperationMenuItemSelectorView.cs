using Calculator.Domain;
namespace Calculator.Infrastructure.ApplicationMenu;

public sealed class OperationMenuItemSelectorView : IMenuItemSelectorProvider
{
    public int GetMenuItemId()
    {
        Console.Write("\nВыберите действие: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
