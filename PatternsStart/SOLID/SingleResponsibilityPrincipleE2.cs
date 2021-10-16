using SOLID.Single_Responsibility_Principle.Example2;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.SOLID
{
    class SingleResponsibilityPrincipleE2 : IPattern
    {
        public void Start()
        {
            MobileStore mobileStore = new MobileStore(
                new ConsolePhoneReader(),
                new GeneralPhoneBinder(),
                new GeneralPhoneValidator(),
                new TextPhoneSaver()
                );
            mobileStore.Process();
        }
    }

}
