using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevCoaching.Builders.After
{
    public class SandwichCommand
    {
        public void OrderSandwich()
        {
            var builder = new SandwichBuilder()
                .AddBread("ciabatta")
                .AddButter()
                .AddHam();
            
            var order = builder.Build();
        }

    }


    public class SandwichBuilder
    {
        private string _breadType;
        private bool _includeButter;
        private bool _includeMargerine;
        private bool _includeOliveOil;
        private bool _hasHam;
        private bool _hasMustard;

        public SandwichBuilder AddBread(string type)
        {
            _breadType = type;
            return this;
        }

        public SandwichBuilder AddButter()
        {
            _includeButter = true;
            return this;
        }

        public SandwichBuilder AddMargerine()
        {
            _includeMargerine = true;
            return this;
        }

        public SandwichBuilder AddHam()
        {
            _hasHam = true;
            return this;
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
