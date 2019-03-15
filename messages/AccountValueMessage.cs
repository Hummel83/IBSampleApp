/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class AccountValueMessage
    {
        private string key;
        private string value;
        private string currency;
        private string accountName;

        public AccountValueMessage(string key, string value, string currency, string accountName)
        {
            this.key = key;
            this.value = value;
            this.currency = currency;
            this.accountName = accountName;
        }

        public string Key
        {
            get { return this.key; }
            set { key = value; }
        }

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public string Currency
        {
            get { return this.currency; }
            set { currency = value; }
        }

        public string AccountName
        {
            get { return this.accountName; }
            set { accountName = value; }
        }
    }
}