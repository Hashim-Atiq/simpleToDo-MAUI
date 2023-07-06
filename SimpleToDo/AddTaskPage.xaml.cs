using CommunityToolkit.Maui.Views;
using SimpleToDo.ViewModels;

namespace SimpleToDo;

public partial class AddTaskPage : Popup
{
    public AddTaskPage()
    {
        InitializeComponent();
    }

    private void OnSaveClick(Object sender, EventArgs args)
    {
        if (this.TaskEntry.Text != null)
        {
            this.Close(this.TaskEntry.Text);
        }
    }

    private void OnCancelClick(Object sender, EventArgs args)
    {
        this.Close("null");
    }
}