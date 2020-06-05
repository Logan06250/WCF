using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceProject
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "HelloService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez HelloService.svc ou HelloService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class HelloService : IHelloService
    {
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }

        public int m_add(int x, int y)
        {
            return x + y;
        }

        public int m_sous(int x, int y)
        {
            return x - y;
        }

        public int dispatching(string op_name, string token, int x, int y)
        {
            int res = 0;
            if (token == "loganToken")
            {
                if (op_name == "m_add")
                {
                    res = m_add(x, y);
                }
                else
                {
                    res = m_sous(x, y);
                }

            }
            else
            {
                return 0;
            }

            return res;
        }
    }


}
