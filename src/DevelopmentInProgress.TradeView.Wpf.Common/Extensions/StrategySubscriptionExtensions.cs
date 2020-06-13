﻿using DevelopmentInProgress.TradeView.Wpf.Common.Model;
using DevelopmentInProgress.TradeView.Core.Extensions;

namespace DevelopmentInProgress.TradeView.Wpf.Common.Extensions
{
    public static class StrategySubscriptionExtensions
    {
        public static Core.Strategy.StrategySubscription ToCoreStrategySubscription(this StrategySubscription strategySubscription)
        {
            int subscribe = 0;

            if (strategySubscription.SubscribeAccount)
            {
                subscribe += 1;
            }

            if (strategySubscription.SubscribeTrades)
            {
                subscribe += 2;
            }

            if (strategySubscription.SubscribeOrderBook)
            {
                subscribe += 4;
            }

            if (strategySubscription.SubscribeCandlesticks)
            {
                subscribe += 8;
            }

            var coreStrategySubscription = new Core.Strategy.StrategySubscription
            {
                AccountName = strategySubscription.AccountName,
                Symbol = strategySubscription.Symbol,
                Limit = strategySubscription.Limit,
                ApiKey = strategySubscription.ApiKey,
                SecretKey = strategySubscription.SecretKey,
                ApiPassPhrase = strategySubscription.ApiPassPhrase,
                Exchange = strategySubscription.Exchange,
                Subscribe = (Core.Strategy.Subscribe)subscribe,
                CandlestickInterval = strategySubscription.CandlestickInterval.GetCandlestickInterval()
            };

            return coreStrategySubscription;
        }

        public static StrategySubscription ToWpfStrategySubscription(this Core.Strategy.StrategySubscription coreStrategySubscription)
        {
            var strategySubScription = new StrategySubscription
            {
                AccountName = coreStrategySubscription.AccountName,
                Symbol = coreStrategySubscription.Symbol,
                Limit = coreStrategySubscription.Limit,
                ApiKey = coreStrategySubscription.ApiKey,
                ApiPassPhrase = coreStrategySubscription.ApiPassPhrase,
                SecretKey = coreStrategySubscription.SecretKey,
                Exchange = coreStrategySubscription.Exchange,
                CandlestickInterval = coreStrategySubscription.CandlestickInterval.ToString()
            };

            if ((coreStrategySubscription.Subscribe & Core.Strategy.Subscribe.AccountInfo) == Core.Strategy.Subscribe.AccountInfo)
            {
                strategySubScription.SubscribeAccount = true;
            }

            if ((coreStrategySubscription.Subscribe & Core.Strategy.Subscribe.Trades) == Core.Strategy.Subscribe.Trades)
            {
                strategySubScription.SubscribeTrades = true;
            }

            if ((coreStrategySubscription.Subscribe & Core.Strategy.Subscribe.OrderBook) == Core.Strategy.Subscribe.OrderBook)
            {
                strategySubScription.SubscribeOrderBook = true;
            }

            if ((coreStrategySubscription.Subscribe & Core.Strategy.Subscribe.Candlesticks) == Core.Strategy.Subscribe.Candlesticks)
            {
                strategySubScription.SubscribeCandlesticks = true;
            }

            return strategySubScription;
        }
    }
}
