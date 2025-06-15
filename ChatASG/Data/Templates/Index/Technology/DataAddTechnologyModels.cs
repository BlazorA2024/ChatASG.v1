using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Data.ModulsTechnology
{
    public class DataTechnology
    {
        public string? Icon { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ColorIcon { get; set; }
        public string? BgIcon { get; set; }
    }

    public class DataTechnologyImage
    {
        public string? ImageUrl { get; set; }
        public string? AltText { get; set; }
        public string? LabelTop { get; set; }
        public string? LabelNumber { get; set; }
        public string? LabelBottom { get; set; }
    }

    public class DataTargetMarketItem
    {
        public string? IconClass { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }

    public class DataGrowthAnalytics
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? GrowthRange { get; set; }
        public string? GrowthAmount { get; set; }
        public int Progress { get; set; }
    }

    public class DataTargetMarket
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<DataTargetMarketItem>? Items { get; set; }

        public string? TitleGrowth { get; set; }
        public string? DescriptionGrowth { get; set; }
        public DataGrowthAnalytics? IGrowth { get; set; }
    }

    public class DataAddTechnology
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public string? Label { get; set; }
        public List<DataTechnology>? Items { get; set; }
        public DataTechnologyImage? ITechnol { get; set; }
        public DataTargetMarket? IMarket { get; set; }
    }

    
}