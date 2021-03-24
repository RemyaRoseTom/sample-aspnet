using System;

namespace sampleweb.Models
{
    public class ErrorViewModel
    {
        //requestid 
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
