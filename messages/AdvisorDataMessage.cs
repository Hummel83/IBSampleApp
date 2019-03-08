/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class AdvisorDataMessage
    {
        private int faDataType;
        private string data;

        public AdvisorDataMessage(int faDataType, string data)
        {
            FaDataType = faDataType;
            Data = data;
        }

        public int FaDataType
        {
            get { return faDataType; }
            set { faDataType = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}