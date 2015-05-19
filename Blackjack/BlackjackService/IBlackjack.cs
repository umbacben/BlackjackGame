using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BlackjackService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBlackjack
    {
        [OperationContract]
        string GetData(int value);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "BlackjackService.ContractType".
    [DataContract]
    public class Card
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class DBHandler
    {
        String connectionInfo =  @"server=athena01.fhict.local;
                                      userid=dbi271495;
                                      password=FHBQCP47aR;
                                      database=dbi271495;
                                      Convert Zero Datetime=True;
                                      Allow Zero Datetime=True;";
        [DataMember]
        public MySqlConnection connection { get; set; }

        public DBHandler()
        {
            connection = new MySqlConnection(connectionInfo);
        }
    }
}
