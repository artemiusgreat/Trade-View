﻿using System.Collections.Generic;

namespace DevelopmentInProgress.MarketView.Interface.Model
{
    public class OrderBook
    {
        public string Symbol { get; set; }
        public long FirstUpdateId { get; set; }
        public long LastUpdateId { get; set; }
        public IEnumerable<OrderBookPriceLevel> Bids { get; set; }
        public IEnumerable<OrderBookPriceLevel> Asks { get; set; }
    }
}
