// NameForm.cshtml.cs

using Hydro;

namespace hydrodemo2.Pages.Components;

public class NameForm : HydroComponent
{
    public NameForm()
    {
        Calibers = new List<string>()
        {
            "Brandy", "224 Valkyrie", "308 Winchester", "5.56 NATO", "300 Blackout"
        };
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<string> Calibers { get; set; }
}