/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class AccountUpdateMultiMessage
    {
        private int reqId;
        private string account;
        private string modelCode;
        private string key;
        private string value;
        private string currency;

        public AccountUpdateMultiMessage(int reqId, string account, string modelCode, string key, string value, string currency)
        {
            this.reqId = reqId;
            this.account = account;
            this.modelCode = modelCode;
            this.key = key;
            this.value = value;
            this.currency = currency;
        }

        public int ReqId
        {
            get { return this.reqId; }
            set { reqId = value; }
        }

        public string Account
        {
            get { return this.account; }
            set { account = value; }
        }

        public string ModelCode
        {
            get { return this.modelCode; }
            set { modelCode = value; }
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
    }
}