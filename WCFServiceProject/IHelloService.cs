using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IHelloService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string GetMessage(string name);

        int m_add(int x, int y);

        int m_sous(int x, int y);

        [OperationContract]
        int dispatching(string op_name, string token, int x, int y);

    }

    [DataContract]
    public struct MSG
    {
        [DataMember]
        public bool op_statut;
        [DataMember]
        public string op_name;
        [DataMember]
        public string op_infos;
        [DataMember]
        public string app_name;
        [DataMember]
        public string app_version;
        [DataMember]
        public string app_tocken;
        [DataMember]
        public string user_login;
        [DataMember]
        public string user_password;
        [DataMember]
        public string user_token;
        [DataMember]
        public object[] data;

    }
}
