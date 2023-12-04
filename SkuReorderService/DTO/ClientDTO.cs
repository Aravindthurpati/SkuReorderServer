using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkuReorderService.DTO
{
    public class ClientDTO
    {
        public int Uniqueid { get; set; }
        public string? Clientname {  get; set; }
        public byte[]? Photo {  get; set; }
        public string? Reordertoemail { get; set; }
        public string? Reorderbccemail { get; set; }


    }
}
