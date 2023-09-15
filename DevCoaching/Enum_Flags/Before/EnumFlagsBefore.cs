namespace DevCoaching.Enum_Flags.Before
{
    public class EnumFlagsBefore
    {
        public void OrderIceCream(IceCreamRequest request)
        {
            // Save request to database
            var dbEntity = new IceCreamDbEntity
            {
                Cone = request.Cone,
                Flavour = request.Flavour,
                Topping = request.Topping,
            };
            // _context.SaveChanges();
            
        }
    }

    public class IceCreamDbEntity
    {
        public Flavour Flavour { get; set; }
        public Cone Cone { get; set; }
        public Topping Topping { get; set; }
    }

    public class IceCreamRequest
    {
        public Flavour Flavour { get; set; }
        public Cone Cone { get; set; }
        public Topping Topping { get; set; }
    }

    public enum Flavour
    {
        Vanilla,
        Chocolate,
        RaspberryRipple,
        MintAndChocolateChip,
        Strawberry
    }

    public enum Cone
    {
        Cheap,
        Waffle,
        ChocolateWaffle,
    }

    public enum Topping
    {
        HundredsAndThousands,
        Flake,
        RaspberryRipple,
        Honey,
    }


}
