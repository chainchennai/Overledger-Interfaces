using System;
using System.Collections.Generic;
using System.Text;
using PS.Data;
using PS.Data.PS.DAO;


namespace PS.Interfaces
{
    public interface ISnapshotCollector 
    {

        PSSnapshot CollectSnapshot(SnapshotType snapshotType, bool includeComponentFileDetails);
        
			 
    }
}
