using SkuReorderService.DTO;
using SkuReorderService.IRepositary;
using SkuReorderService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkuReorderService.Repositary
{
    internal class SkuRepositary: ISkuRepositary
    {
        private readonly MAIWMSContext _context;

        public SkuRepositary(MAIWMSContext context)
        {
            _context = context;
        }
        public List<ClientDTO> clientList()
        {
            var data = _context.Whclients.Where(x => x.Reordernotification == true).Select(x => new ClientDTO {Uniqueid= x.Uniqueid,
                Clientname= x.Clientname,
                Photo= x.Photo,Reordertoemail = x.Reordertoemail,
                Reorderbccemail=x.Reorderbccemail}).ToList();
            //return _context.Whclients.Where(x=>x.Reordernotification==true).Select(y=>y.Uniqueid).ToList();
            return data;
        }
       public List<SkuDTO> getSkuData(int clientid)
        {
            var skuData = _context.Skus
       .Where(x => x.Clientid == clientid && x.Reorderpoint > 0)
       .Select(sku => new SkuDTO
       {
           SkuId = sku.Skuid,
           Sku1 = sku.Sku1,
           Description = sku.Description,
           Reorderqty = sku.Reorderpoint
       }).ToList();

            return skuData;
        }
        public int getInventoryqty(int skuId)
        {
            int totalqty = _context.Skuinventorylocations
                .Where(loc => loc.Skuid == skuId)
                .Sum(loc => loc.Availableqty - loc.Allocatedqty);

            return totalqty;
        }
    }
}
