using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using CommunityToolkit.Maui.Views;

namespace SimpleToDo.ViewModels
{
    public partial class ToDoListViewModel : ObservableObject
    {
        public ToDoListViewModel()
        {
            Tasks = new ObservableCollection<ListDataTemplate>();
        }

        [ObservableProperty]
        ObservableCollection<ListDataTemplate> tasks;

        [RelayCommand]
        void RemoveTask(ListDataTemplate task)
        {
            Tasks.Remove(task);
        }

        [RelayCommand]
        async void AddTask()
        {
            var result = await App.Current.MainPage.ShowPopupAsync(new AddTaskPage());
            if (result.ToString() != "null")
            {
                Tasks.Add(new ListDataTemplate
                {
                    IsCompleted = false,
                    Text = result.ToString()
                });
            }
        }

    }

    public partial class ListDataTemplate
    {
        public bool IsCompleted { get; set; }
        public string Text { get; set; }
    }
}
