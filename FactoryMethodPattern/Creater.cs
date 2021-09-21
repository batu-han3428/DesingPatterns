using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Creater 
    {
        public IMobilApp FactoryMethod(AllMobileOs OSType)
        {
            IMobilApp mobilApp = null;

            switch (OSType)
            {
                case AllMobileOs.Android:
                    mobilApp = new Android();
                    break;
                case AllMobileOs.Iphone:
                    mobilApp = new Ios();
                    break;
                case AllMobileOs.Harmony:
                    mobilApp = new Harmony();
                    break;
                default:
                    break;
            }

            return mobilApp;
        }
    }
}
