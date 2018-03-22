using System;
using System.Collections.Generic;
using System.Text;
using PS.Data;
using PS.Data.PS.Data;

namespace PS.Interfaces
{
    public interface IPSService
    {
        void SendSnapshot(PSSnapshot snapshot);
    }
}
