/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

using IBApi;

namespace IBSampleApp.messages
{
    internal class NewsProvidersMessage
    {
        public NewsProvider[] NewsProviders { get; private set; }

        public NewsProvidersMessage(NewsProvider[] newsProviders)
        {
            this.NewsProviders = newsProviders;
        }
    }
}