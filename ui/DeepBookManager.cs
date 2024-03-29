/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;
using IBSampleApp.messages;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IBSampleApp.backend;

namespace IBSampleApp.ui
{
    internal class DeepBookManager : DataManager
    {
        public const int TICK_ID_BASE = 20000000;

        private int numRows = 3;

        private bool isSubscribed = false;

        private const int BID_MAKER_IDX = 0;
        private const int BID_SIZE_IDX = 1;
        private const int BID_PRICE_IDX = 2;

        private const int ASK_PRICE_IDX = 3;
        private const int ASK_SIZE_IDX = 4;
        private const int ASK_MAKER_IDX = 5;

        private DataGridView mktDepthExchangesGrid;
        private bool isSmartDepth;

        public DeepBookManager(IBClient client, DataGridView dataGrid, DataGridView mktDepthExchangesGrid) : base(client, dataGrid)
        {
            MktDepthExchangesGrid = mktDepthExchangesGrid;
        }

        public void AddRequest(Contract contract, int numEntries, bool isSmartDepth)
        {
            numRows = numEntries;
            IsSmartDepth = isSmartDepth;
            StopActiveRequests();
            ibClient.ClientSocket.reqMarketDepth(currentTicker + TICK_ID_BASE, contract, numRows, IsSmartDepth, new List<TagValue>());
            isSubscribed = true;
        }

        public override void Clear()
        {
        }

        public void StopActiveRequests()
        {
            if (isSubscribed)
            {
                ibClient.ClientSocket.cancelMktDepth(currentTicker + TICK_ID_BASE, IsSmartDepth);
                ((DataGridView)uiControl).Rows.Clear();
                isSubscribed = false;
            }
        }

        public override void NotifyError(int requestId)
        {
            ((DataGridView)uiControl).Rows.Clear();
            isSubscribed = false;
        }

        public void UpdateUI(DeepBookMessage entry)
        {
            DataGridView grid = (DataGridView)uiControl;

            if (grid.Rows.Count == 0)
                grid.Rows.Add(numRows);

            if (entry.Side == 1)
            {
                grid[BID_MAKER_IDX, entry.Position].Value = entry.MarketMaker;
                grid[BID_SIZE_IDX, entry.Position].Value = entry.Size;
                grid[BID_PRICE_IDX, entry.Position].Value = entry.Price;
            }
            else
            {
                grid[ASK_MAKER_IDX, entry.Position].Value = entry.MarketMaker;
                grid[ASK_SIZE_IDX, entry.Position].Value = entry.Size;
                grid[ASK_PRICE_IDX, entry.Position].Value = entry.Price;
            }
        }

        public void ReqMktDepthExchanges()
        {
            ibClient.ClientSocket.reqMktDepthExchanges();
        }

        public void ClearMktDepthExchanges()
        {
            mktDepthExchangesGrid.Rows.Clear();
        }

        public void HandleMktDepthExchangesMessage(MktDepthExchangesMessage mktDepthExchangesMessage)
        {
            mktDepthExchangesGrid.Rows.Clear();

            for (int i = 0; i < mktDepthExchangesMessage.Descriptions.Length; i++)
            {
                MktDepthExchangesGrid.Rows.Add(1);
                MktDepthExchangesGrid[0, MktDepthExchangesGrid.Rows.Count - 1].Value = mktDepthExchangesMessage.Descriptions[i].Exchange;
                MktDepthExchangesGrid[1, MktDepthExchangesGrid.Rows.Count - 1].Value = mktDepthExchangesMessage.Descriptions[i].SecType;
                MktDepthExchangesGrid[2, MktDepthExchangesGrid.Rows.Count - 1].Value = mktDepthExchangesMessage.Descriptions[i].ListingExch;
                MktDepthExchangesGrid[3, MktDepthExchangesGrid.Rows.Count - 1].Value = mktDepthExchangesMessage.Descriptions[i].ServiceDataType;
                MktDepthExchangesGrid[4, MktDepthExchangesGrid.Rows.Count - 1].Value =
                    mktDepthExchangesMessage.Descriptions[i].AggGroup != Int32.MaxValue ? mktDepthExchangesMessage.Descriptions[i].AggGroup.ToString() : "";
            }
        }

        public DataGridView MktDepthExchangesGrid
        {
            get { return mktDepthExchangesGrid; }
            set { mktDepthExchangesGrid = value; }
        }

        public bool IsSmartDepth
        {
            get { return isSmartDepth; }
            set { isSmartDepth = value; }
        }
    }
}