namespace DevCoaching.Enum_Flags.After
{
    public class EnumFlagsAfter
    {
        public void OrderIceCream(IceCreamRequest request)
        {
            // Save request to database
            var dbEntity = new IceCreamDbEntity
            {
                Cone = request.Cone,
                Flavour = request.Flavour,
                Topping = request.Toppings
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
        public Topping Toppings { get; set; }
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

    [Flags]
    public enum Topping
    {
        HundredsAndThousands = 1 << 1,
        Flake = 1 << 2,
        RaspberryRipple = 1 << 3,
        Honey = 1 << 4,
    }


}
