/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;

namespace IBSampleApp.messages
{
    internal class CommissionMessage
    {
        private CommissionReport commissionReport;

        public CommissionMessage(CommissionReport commissionReport)
        {
            this.commissionReport = commissionReport;
        }

        public CommissionReport CommissionReport
        {
            get { return this.commissionReport; }
            set { commissionReport = value; }
        }
    }
}