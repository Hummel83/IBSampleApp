/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class PositionMultiEndMessage
    {
        private int reqId;

        public PositionMultiEndMessage(int reqId)
        {
            ReqId = reqId;
        }

        public int ReqId
        {
            get { return reqId; }
            set { reqId = value; }
        }
    }
}