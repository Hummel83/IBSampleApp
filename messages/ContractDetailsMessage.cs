/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;

namespace IBSampleApp.messages
{
    internal class ContractDetailsMessage
    {
        private int requestId;
        private ContractDetails contractDetails;

        public ContractDetailsMessage(int requestId, ContractDetails contractDetails)
        {
            this.requestId = requestId;
            this.contractDetails = contractDetails;
        }

        public ContractDetails ContractDetails
        {
            get { return this.contractDetails; }
            set { contractDetails = value; }
        }

        public int RequestId
        {
            get { return this.requestId; }
            set { requestId = value; }
        }
    }
}