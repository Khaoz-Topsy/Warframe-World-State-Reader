using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeWorldStateReadSave.Data.Repositories.Interfaces;
using WarframeWorldStateReadSave.Domain.Functional;

namespace WarframeWorldStateReadSave.Data.Repositories
{
    public class WarframeRepository : IWarframeRepository
    {
        public WarframeWorldStateData getAllData()
        {
            WarframeDashData data = new WarframeDashData();
            return data.readAndConvertWarframeData();
        }

        public string getAllDataFormatted()
        {
            WarframeDashData data = new WarframeDashData();
            return data.WarframeDataFormatted();
        }
    }
}
