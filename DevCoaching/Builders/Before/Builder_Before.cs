using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Builders.Before
{

    public class SandwichCommand
    {
        public void OrderSandwich()
        {
            var sandwich = new SandwichBuilder(
                "ciabatta",
                includeButter: true,
                includeMargerine: false,
                includeOliveOil: true,
                hasHam: true,
                hasMustard: false
            );
            var order = sandwich.Build();
        }
        
    }


    public class SandwichBuilder
    {
        private readonly string _breadType;
        private readonly bool _includeButter;
        private readonly bool _includeMargerine;
        private readonly bool _includeOliveOil;
        private readonly bool _hasHam;
        private readonly bool _hasMustard;

        public SandwichBuilder(
            string breadType,
            bool includeButter,
            bool includeMargerine,
            bool includeOliveOil,
            bool hasHam,
            bool hasMustard
        )
        {
            _hasMustard = hasMustard;
            _hasHam = hasHam;
            _includeOliveOil = includeOliveOil;
            _includeMargerine = includeMargerine;
            _includeButter = includeButter;
            _breadType = breadType;
        }

        public string Build()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Bread: {_breadType}");
            sb.AppendLine($"Fatty gloop: {(_includeButter ? "Organic British Butter" : "")}, {(_includeMargerine ? "Marg" : "")}, {(_includeMargerine ? "Olive Oil" : "")}");

            return sb.ToString();
        }
    }
}
