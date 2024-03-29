﻿using Comon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Comon
{
    [ServiceContract]
    public interface IEvidencijaGeo
    {
        [OperationContract]
        List<GeoPodrucje> evidencija();

        [OperationContract]
        void ubaci(GeoPodrucje geo);

    }
}
