﻿using DevelopmentInProgress.TradeView.Wpf.Common.Model;
using System.Threading.Tasks;

namespace DevelopmentInProgress.TradeView.Wpf.Common.Helpers
{
    public interface IOrderBookHelper
    {
        Task<OrderBook> CreateLocalOrderBook(Symbol symbol, Interface.Model.OrderBook orderBook, int listDisplayCount, int chartDisplayCount);

        void UpdateLocalOrderBook(OrderBook orderBook, Interface.Model.OrderBook updateOrderBook,
            int pricePrecision, int quantityPrecision, int listDisplayCount, int chartDisplayCount);
    }
}