using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UST_RESTapi.Models
{
    public class ServiceNowData
    {
        //internal fields
        private  string _SCCMRequestID = "not initilized";
        private  string _ApprovalStatus = "not initilized";
        private  string _RequestGUID = "not initilized";
        private  DateTime _WrittenDate;

        // properties declaration
        public  string SCCMRequestID { get { return _SCCMRequestID; } set { _SCCMRequestID = value; } }
        public  string ApprovalStatus { get { return _ApprovalStatus; } set { _ApprovalStatus = value; } }
        public  string RequestGUID { get { return _RequestGUID; } set { _RequestGUID = value; } }
        public DateTime WrittenDate { get { return _WrittenDate; } set { _WrittenDate = value; } }
        
    }

    public class ServiceNowdataRepo
    {
        private static IEnumerable<ServiceNowData> ServiceNowDatas;

        public static IEnumerable<ServiceNowData> GetAllServiceNowData()
        {

        }
        public static ServiceNowData GetServiceNowData(string RequestGUID)
        {

        }

        public static void RemoveServiceNowData(string RequestGUID)
        {

        }

        public static void AddServiceNowData(ServiceNowData serviceNowData)
        {

        }

        public static void UpdateServiceNowData(ServiceNowData serviceNowData)
        {

        }

    }
}
