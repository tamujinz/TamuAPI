using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamuAPI.Model
{
    public class Detail
    {
        public string message { get; set; }
        public string property { get; set; }
    }

    public class WebHookEventResponse
    {
        public string message { get; set; }
        public List<Detail> details { get; set; }
    }

}
