using Hydro;

namespace hydrodemo2.Pages.Components;

public class CaliberOptions : HydroComponent
{
    public CaliberOptions()
    {
        Calibers = new List<string>()
        {
            "6.5 Creedmoor", "224 Valkyrie", "308 Winchester", "5.56 NATO", "300 Blackout"
        };
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<string> Calibers { get; set; }
}