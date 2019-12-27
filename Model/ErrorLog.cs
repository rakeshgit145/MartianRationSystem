using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ErrorLog
    {
        public int Id { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string Message { get; set; }

        public string Method { get; set; }

        public string Controller { get; set; }

    }

}
