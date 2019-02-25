using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public partial class Sandwich
    {
        private readonly string _bread;
        private readonly List<string> _condiments;
        private readonly string _sauce;
        private readonly List<string> _meats;

        public Sandwich(
            string bread,
            List<string> condiments,
            string sauce,
            List<string> meats
        )
        {
            _bread = bread;
            _condiments = condiments;
            _sauce = sauce;
            _meats = meats;
        }

        public string Bread => _bread ?? "*** No Bread ***";

        public string Condiments => 
            _condiments == null || _condiments.Count == 0
            ? "*** No Condiments ***"
            : _condiments.Aggregate(string.Empty, (total, current) => $"{total}, {current}").Remove(0, 2);

        public string Sauce => _sauce ?? "*** No Sauce ***";

        public string Meats =>
            _meats == null || _meats.Count == 0
            ? "*** No Meat ***"
            : _meats.Aggregate(string.Empty, (total, current) => $"{total}, {current}").Remove(0, 2);
    }
}
