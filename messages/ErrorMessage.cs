﻿/* Copyright (C) 2018 Interactive Brokers LLC. All rights reserved. This code is subject to the terms
 * and conditions of the IB API Non-Commercial License or the IB API Commercial License, as applicable. */

namespace IBSampleApp.messages
{
    internal class ErrorMessage
    {
        private string message;
        private int errorCode;
        private int requestId;

        public ErrorMessage(int requestId, int errorCode, string message)
        {
            Message = message;
            RequestId = requestId;
            ErrorCode = errorCode;
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public int ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        public int RequestId
        {
            get { return requestId; }
            set { requestId = value; }
        }

        public override string ToString()
        {
            return "Error. Request: " + RequestId + ", Code: " + ErrorCode + " - " + Message;
        }
    }
}