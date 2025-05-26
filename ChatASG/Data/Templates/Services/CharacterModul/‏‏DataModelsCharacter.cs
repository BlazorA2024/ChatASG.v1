using Microsoft.AspNetCore.Components;

namespace Data.Character.Model
{
    public class DataButtons
    {
        public string? Buttons { get; set; }
        public string? Icon { get; set; }
        public string Title { get; set; } = "";
    }

    public class DataListProjectModul
    {
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public string? Link { get; set; }
        public string? Description { get; set; }
        public string Title { get; set; } = "";
        public string? IconColor { get; set; }
        public string? Image { get; set; }
        public bool IsSelected { get; set; } = false;
    }

    public class DataCardListProjectModul
    {
        public string Title { get; set; } = "";
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public DataButtons? IButtons { get; set; }
        public List<DataListProjectModul> Items { get; set; } = new List<DataListProjectModul>();
    }

    public class DataCardAddProjectModul
    {
        public string Title { get; set; } = "";
        public string? Icon { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }
        public DataCardListProjectModul? ICharact { get; set; }
    }

}
