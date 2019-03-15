/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class ConnectionStatusMessage
    {
        private bool isConnected;

        public bool IsConnected
        {
            get { return this.isConnected; }
        }

        public ConnectionStatusMessage(bool isConnected)
        {
            this.isConnected = isConnected;
        }
    }
}