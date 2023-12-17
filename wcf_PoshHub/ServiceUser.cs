using System.ServiceModel;


namespace wcf_PoshHub
{
    internal class ServiceUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public OperationContext operationContext{ get; set; }
    }
}
