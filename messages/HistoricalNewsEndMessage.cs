/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class HistoricalNewsEndMessage
    {
        public int RequestId { get; private set; }
        public bool HasMore { get; private set; }

        public HistoricalNewsEndMessage(int requestId, bool hasMore)
        {
            this.RequestId = requestId;
            this.HasMore = hasMore;
        }
    }
}