using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    // Адаптер от Camel к ITransport
    public class CamelToTransportAdapter : ITransport
    {
        Camel camel;
        public CamelToTransportAdapter(Camel c)
        {
            camel = c;
        }

        public void Drive()
        {
            camel.Move();
        }
    }
}
