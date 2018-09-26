using System.Runtime.Serialization;

namespace DemoWCF.Models
{
    [DataContract]
    public class EmployeeDTO
    {
        [DataMember]
        public int EmployeeID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int DepartmentID { get; set; }
        [DataMember]
        public string Department { get; set; }
        [DataMember]
        public string Address { get; set; }
    }
}