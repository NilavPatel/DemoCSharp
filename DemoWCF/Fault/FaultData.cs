using System.Runtime.Serialization;

namespace DemoWCF.Fault
{
    [DataContract]
    public class FaultData
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public string ErrorDetails { get; set; }
    }
}