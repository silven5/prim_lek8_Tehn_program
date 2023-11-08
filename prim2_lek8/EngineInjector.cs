using prim1_lek8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prim2_lek8
{
    internal class EngineInjector
    {
        List<IEngineSetter> clients = new List<IEngineSetter>();
        public void inject(IEngineSetter client, Engine engine)
        {
            this.clients.Add(client);
            client.setEngine(engine);
        }
        //Змінити потужність двигунів
        public void updateEngine(Engine engine)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].setEngine(engine);
            }

        }
    }
}

