using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ExpiryDate { get; set; }

        public int? LitersQty { get; set; }

        public string PacketId { get; set; }
        public bool? IsDeleted { get; set; }

    }
}
