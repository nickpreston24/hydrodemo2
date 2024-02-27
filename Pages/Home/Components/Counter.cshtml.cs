using Hydro;

namespace hydrodemo2.Pages.Home.Components;
// ~/Pages/Components/Counter2.cshtml.cs

public class Counter : HydroComponent
{
    public int Count { get; set; }
    
    public void Add()
    {
        Count++;
    }
}