using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public partial class Sandwich
    {
        private string _bread;
        private List<string> _condiments;
        private string _sauce;
        private List<string> _meats;

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

        public string Bread => _bread == null ? "*** No Bread ***" : _bread;
        public string Condiments => 
            _condiments == null || _condiments.Count == 0
            ? "*** No Condiments ***"
            : _condiments.Aggregate(string.Empty, (total, current) => $"{total}, {current}").Remove(0, 2);
        public string Sauce => _sauce == null ? "*** No Sauce ***" : _sauce;
        public string Meats =>
            _meats == null || _meats.Count == 0
            ? "*** No Meat ***"
            : _meats.Aggregate(string.Empty, (total, current) => $"{total}, {current}").Remove(0, 2);
    }
}
