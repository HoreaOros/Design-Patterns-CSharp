﻿using Microsoft.Practices.Prism.Events;
using System.Windows;

namespace Observer_StockTicker
{
    public partial class StockReceiver : Window
    {
        int received = 0;
        string stockFilter = "";

        public StockReceiver(IEventAggregator eventAggregator, string stockID = "")
        {
            InitializeComponent();

            stockFilter = stockID;
            if (string.IsNullOrEmpty(stockFilter))
            {
                // TODO: Add subscription
            }
            else
            {
                // TODO: Add subscription with stock filter
            }
        }

        public void ProcessStockTickerData(StockTickerPayload payload)
        {
            received++;
            TextBlock1.Text = payload.StockId;
            TextBlock2.Text = payload.StockValue.ToString();
            TextBlock3.Text = string.Format("Total Received: {0}", received);
        }
    }
}
