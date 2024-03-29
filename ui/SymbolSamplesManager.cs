﻿/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;
using IBSampleApp.messages;
using System.Windows.Forms;
using IBSampleApp.backend;

namespace IBSampleApp.ui
{
    internal class SymbolSamplesManager : DataManager
    {
        protected bool active = false;
        private int activeReqId = 0;

        public SymbolSamplesManager(IBClient client, DataGridView dataGrid) : base(client, dataGrid)
        {
        }

        public void AddRequest(string pattern)
        {
            ibClient.ClientSocket.reqMatchingSymbols(++activeReqId, pattern);

            if (!uiControl.Visible)
                uiControl.Visible = true;
        }

        public override void NotifyError(int requestId)
        {
        }

        public override void Clear()
        {
            ((DataGridView)uiControl).Rows.Clear();
        }

        public bool isActive()
        {
            return active;
        }

        public void setActive()
        {
            active = true;
        }

        public void unsetActive()
        {
            active = false;
        }

        public void UpdateUI(SymbolSamplesMessage dataMessage)
        {
            if (!uiControl.Visible)
                uiControl.Visible = true;

            ((DataGridView)uiControl).Rows.Clear();

            if (dataMessage.ReqId == activeReqId)
            {
                DataGridView grid = (DataGridView)uiControl;
                int count = 0;
                foreach (ContractDescription cd in dataMessage.ContractDescriptions)
                {
                    grid.Rows.Add();
                    grid[0, count].Value = cd.Contract.ConId;
                    grid[1, count].Value = cd.Contract.Symbol;
                    grid[2, count].Value = cd.Contract.SecType;
                    grid[3, count].Value = cd.Contract.PrimaryExch;
                    grid[4, count].Value = cd.Contract.Currency;
                    foreach (string s in cd.DerivativeSecTypes)
                    {
                        grid[5, count].Value += (s + " ");
                    }
                    count++;
                }
            }
        }
    }
}