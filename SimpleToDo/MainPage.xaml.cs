using CommunityToolkit.Maui.Views;
using SimpleToDo.ViewModels;

namespace SimpleToDo;

public partial class MainPage : ContentPage
{
    public MainPage(ToDoListViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

