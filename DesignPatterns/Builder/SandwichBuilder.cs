using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class SandwichBuilder
    {
        private string _bread;
        private List<string> _condiments;
        private string _sauce;
        private List<string> _meats;

        public SandwichBuilder()
        {
            Init();
        }

        private void Init()
        {
            _bread = null;
            _sauce = null;
            _condiments = new List<string>();
            _meats = new List<string>();
        }

        public SandwichBuilder Reset()
        {
            Init();

            return this;
        }

        public SandwichBuilder AddBread(string bread)
        {
            _bread = bread;

            return this;
        }

        public SandwichBuilder AddCondiment(string condiment)
        {
            if (!_condiments.Contains(condiment))
                _condiments.Add(condiment);

            return this;
        }

        public SandwichBuilder AddSauce(string sauce)
        {
            _sauce = sauce;

            return this;
        }

        public SandwichBuilder AddMeat(string meat)
        {
            if (!_meats.Contains(meat))
                _meats.Add(meat);

            return this;
        }

        public Sandwich GetSandwich()
        {
            return new Sandwich(
                _bread,
                _condiments,
                _sauce,
                _meats
            );
        }
    }
}
