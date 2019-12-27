using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class PacketDetail
    {
        public int Id { get; set; }
        public DateTime Startdate { get; set; }
        public int LivedLife { get; set; }
        public string PacketTypeId { get; set; }

        public string PacketType { get; set; }
        public string PacketContent { get; set; }

        public int? Calories { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public int? LitersQty { get; set; }

        public bool? IsDeleted { get; set; }

    }
}
