﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Dundee_WPF.Models
{
    class Packet
    {
        DateTime timestamp;
        ErrorType errors;
        public Data theData;
        int totalChars;
        bool hasError;

        public Packet(DateTime timeStamp, Data theData)
        {
            this.timestamp = timeStamp;
            this.theData = theData;
        }

        public Data getData() {
            return this.theData;

        }

        public bool getErrorStatus() {
            return hasError;

        }

        public void setError(bool err, string type) {
            hasError = err;

            //Distinguish error type, pass in and set enum value

        }


    }


    enum ErrorType {
        noError,
        disconnect,
        parity,
        crc,
        eep,
        timeout,
        babblingIdiot,
        sequence
    };
}
