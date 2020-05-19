using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
namespace EmployeeCommonLayer.Model
{
    [DataContract]
    public class ResponseMessage
    {
        [DataMember(Name = "Status")]
        public bool Status { get; set; }

        [DataMember(Name = "Message")]
        public string Message { get; set; }

        [DataMember(Name = "Data")]
        public List<EmployeeModel> Data { get; set; } = null;
    }
}

