﻿/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class AccountUpdateMultiEndMessage
    {
        private int reqId;

        public AccountUpdateMultiEndMessage(int reqId)
        {          
            this.reqId = reqId;
        }

        public int ReqId
        {
            get { return this.reqId; }
            set { reqId = value; }
        }
    }
}