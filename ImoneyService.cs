using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MONEY.Contracts
{

    [ServiceContract(Namespace = "https://cbr.ru/DailyInfoWebServ/DailyInfo.asmx")]

    public interface ImoneyService
    {
        [OperationContract]
        double FahrenheitToCelsius(double farenheitDegrees);

        [OperationContract]
        double CelsiusToFahrenheit(double celsiusDegrees);
    }

}

