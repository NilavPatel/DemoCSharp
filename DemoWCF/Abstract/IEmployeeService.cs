using DemoWCF.Fault;
using DemoWCF.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DemoWCF.Abstract
{
    [ServiceContract]
    public interface IEmployeeService
    {
        /// <summary>
        /// Get all Employee detials
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/GetEmployees",
            ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(FaultData))]
        IEnumerable<EmployeeDTO> GetEmployees();

        /// <summary>
        /// Get Employee details by Employee id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [WebGet(UriTemplate = "/GetEmployeeById?id={id}",
            ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(FaultData))]
        EmployeeDTO GetEmployeeById(long id);

        /// <summary>
        /// Insert new Employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/InsertEmployee",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(FaultData))]
        long InsertEmployee(EmployeeDTO employee);

        /// <summary>
        /// Update Employee details
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateEmployee",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(FaultData))]
        bool UpdateEmployee(EmployeeDTO employee);

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteEmployee",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        [FaultContract(typeof(FaultData))]
        bool DeleteEmployee(long id);
    }
}
