using Microsoft.AspNetCore.Mvc.Rendering;


namespace LoadBrokerageApp.Interfaces
{
    public interface IViewModel<T>
    {
        public T? Entity { get; set; }
        public List<SelectListItem>? AvailableStates { get; set; }
        
    }
}