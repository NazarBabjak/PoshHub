using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_PoshHub
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicePoshHub" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(IServicePoshHubCallBack))]
    public interface IServicePoshHub
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int id);

        [OperationContract]
        void SelectionOfClothes(string sample, int id);

        [OperationContract(IsOneWay = true)]
        void Member(int id);

        [OperationContract(IsOneWay = true)]
        void BlockUser(string name);

    }

    public interface IServicePoshHubCallBack
    {
        [OperationContract]
        void SelectionOfClothesCallBack(int[] price, int[] quantity, int[] purchases, string[] name, string[] info, string[] image);

        [OperationContract(IsOneWay = true)]
        void MemberCallBack(string[] onlineUsersName);

    }
}
