namespace BD.WTTS.UI;

public static class ControlExtensions
{
    public static void SetViewModel<T>(this Control c) where T : ViewModelBase, new()
    {
        if (c.DataContext == null || c.DataContext.GetType() != typeof(T))
        {
            c.DataContext = new T();
        }
    }
}
