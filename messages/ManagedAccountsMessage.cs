/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using System.Collections.Generic;

namespace IBSampleApp.messages
{
    internal class ManagedAccountsMessage
    {
        private List<string> managedAccounts;

        public ManagedAccountsMessage(string managedAccounts)
        {
            this.managedAccounts = new List<string>(managedAccounts.Split(','));
        }

        public List<string> ManagedAccounts
        {
            get { return managedAccounts; }
            set { managedAccounts = value; }
        }
    }
}