using Model;
using System;
using System.Collections.Generic;

namespace WebUI.Models
{
    public class RationScheduleViewModel
    {
        public RationScheduleViewModel()
        {
            listRation = new List<PacketDetail>();
        }
        public DateTime StartDate { get; set; }
        public List<PacketDetail> listRation { get; set; }
        public int CounterSpan { get;set; }
        public int LivedLife { get; set; }

    }


    public class RationScheduleViewModelNew
    {
        
        public string statedate { get; set; }
        public DateTime StartDate { get; set; }
        public List<RationScheduleViewModel> lstRationScheduleViewModel { get; set; }

    }
}