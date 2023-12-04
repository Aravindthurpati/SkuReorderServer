using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkuReorderService.DTO
{
    public class SkuDTO
    {

        public int SkuId { get; set; }
        public string? Sku1 {  get; set; }
        public string? Description { get; set; }
        public int Reorderqty {  get; set; }
        public int totalqty { get; set; }
    }
    public class SkuMailDTO
    {
        public List<SkuDTO> skuList { get; set; }
        public List<string>? Email { get; set; }
        public List<string>? BccEmail { get; set; }
        public string client { get; set; }
        public string logo { get; set; }
        public string currentdate {  get; set; }
    }
}
