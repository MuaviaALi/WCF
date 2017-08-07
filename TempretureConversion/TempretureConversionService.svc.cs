using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TempretureConversion
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TempretureConversionService : ITempretureConversionService
    {

        public double ConvertTempreture(double val, WeightScale from, WeightScale to)
        {

            if(from == WeightScale.FAHRENHEIT)
            {
                if (to == WeightScale.FAHRENHEIT)
                {

                    return val;

                }
                else
                {

                    return val * 255.9277777777778;
                }

            }
            else
            {
                    if (to == WeightScale.FAHRENHEIT)
                {

                    return val * -457.87;

                }
                else
                {

                    return val;
                }
            
            }


        }
  
    }

 }
