using System.ComponentModel;

namespace BlazorDemo.ViewModel
{
    public class Counter : ICounter
    {
        public int Count { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Increment()
        {
            Count++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
        }
    }
}