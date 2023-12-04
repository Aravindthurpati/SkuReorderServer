using SkuReorderService.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkuReorderService.IRepositary
{
    public interface ISkuRepositary
    {
        public List<ClientDTO> clientList();
        public List<SkuDTO> getSkuData(int clientid);
        public int getInventoryqty(int skuId);
    }
}
