/// ================================================
/// File    : ResponseMessage.cs
/// Author  : Saksham Singh
/// Company : Bridgelabz Solution LLP
/// ================================================
#region EmployeeCommonLayer.Model
namespace EmployeeCommonLayer.Model
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// Poco class for Response message
    /// </summary>
    #region ResponseMessage
    [DataContract]
    public class ResponseMessage
    {
        /// <summary>
        /// Gets or sets Status
        /// </summary>
        [DataMember(Name = "Status")]
        public bool Status { get; set; }

        /// <summary>
        /// Gets or sets Message
        /// </summary>
        [DataMember(Name = "Message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Data
        /// </summary>
        [DataMember(Name = "Data")]
        public List<DisplayAllDetails> Data { get; set; } = null;
    }
    #endregion
}
#endregion

