/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class FundamentalsMessage
    {
        private string data;

        public FundamentalsMessage(string data)
        {
            Data = data;
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}