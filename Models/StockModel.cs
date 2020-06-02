using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Markets.Models
{
        public class StockModel
        {
            public Quoteresponse quoteResponse { get; set; }
        }

        public class Quoteresponse
        {
            public Result[] result { get; set; }
            public object error { get; set; }
        }

        public class Result
        {
            public string language { get; set; }
            public string region { get; set; }
            public string quoteType { get; set; }
            public bool triggerable { get; set; }
            public string currency { get; set; }
            public float regularMarketChange { get; set; }
            public float regularMarketChangePercent { get; set; }
            public int regularMarketTime { get; set; }
            public float regularMarketPrice { get; set; }
            public float regularMarketDayHigh { get; set; }
            public string regularMarketDayRange { get; set; }
            public float regularMarketDayLow { get; set; }
            public int regularMarketVolume { get; set; }
            public float regularMarketPreviousClose { get; set; }
            public float bid { get; set; }
            public float ask { get; set; }
            public int bidSize { get; set; }
            public int askSize { get; set; }
            public string fullExchangeName { get; set; }
            public float regularMarketOpen { get; set; }
            public int averageDailyVolume3Month { get; set; }
            public int averageDailyVolume10Day { get; set; }
            public float fiftyTwoWeekLowChange { get; set; }
            public float fiftyTwoWeekLowChangePercent { get; set; }
            public string fiftyTwoWeekRange { get; set; }
            public float fiftyTwoWeekHighChange { get; set; }
            public float fiftyTwoWeekHighChangePercent { get; set; }
            public float fiftyTwoWeekLow { get; set; }
            public float fiftyTwoWeekHigh { get; set; }
            public long firstTradeDateMilliseconds { get; set; }
            public int priceHint { get; set; }
            public string marketState { get; set; }
            public float fiftyDayAverage { get; set; }
            public float fiftyDayAverageChange { get; set; }
            public float fiftyDayAverageChangePercent { get; set; }
            public float twoHundredDayAverage { get; set; }
            public float twoHundredDayAverageChange { get; set; }
            public float twoHundredDayAverageChangePercent { get; set; }
            public int sourceInterval { get; set; }
            public int exchangeDataDelayedBy { get; set; }
            public bool tradeable { get; set; }
            public string exchange { get; set; }
            public string shortName { get; set; }
            public string messageBoardId { get; set; }
            public string exchangeTimezoneName { get; set; }
            public string exchangeTimezoneShortName { get; set; }
            public int gmtOffSetMilliseconds { get; set; }
            public string market { get; set; }
            public bool esgPopulated { get; set; }
            public string symbol { get; set; }
            public string quoteSourceName { get; set; }
            public float postMarketChangePercent { get; set; }
            public int postMarketTime { get; set; }
            public float postMarketPrice { get; set; }
            public float postMarketChange { get; set; }
            public string financialCurrency { get; set; }
            public float ytdReturn { get; set; }
            public float trailingThreeMonthReturns { get; set; }
            public float trailingThreeMonthNavReturns { get; set; }
            // public int sharesOutstanding { get; set; }
            public long marketCap { get; set; }
            public string longName { get; set; }
            public int dividendDate { get; set; }
        }

    }

