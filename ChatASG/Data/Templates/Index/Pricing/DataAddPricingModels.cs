
namespace Data.ModulsPricing
{
    public class DataPricingCard
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ClassCard { get; set; }
        public string? Price { get; set; }
        public string? Period { get; set; }
        public List<string>? Features { get; set; }
        public List<string>? DisabledFeatures { get; set; }
        public string? Button { get; set; }
        public string? ClassButton { get; set; }
        public bool IsPopular { get; set; }
        public string? BadgeText { get; set; }
    }

    public class DataPricingQuiz
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Button { get; set; }
        public string? ButtonIconClass { get; set; }
    }

    public class DataAddPricing
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<DataPricingCard>? Items { get; set; }
        public DataPricingQuiz? Iquiz { get; set; }
    }

  
    
}
