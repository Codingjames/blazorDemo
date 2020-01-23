using System.ComponentModel;

namespace BlazorDemo.ViewModel
{
    public interface ICounter : INotifyPropertyChanged
    {
         int Count { get; set; }

         void Increment();
    }
}