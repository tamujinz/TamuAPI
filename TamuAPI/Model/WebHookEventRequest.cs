﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamuAPI.Model
{
    public class WebHookEventRequest
    {
        public string destination { get; set; }
        public List<Event> events { get; set; }
    }
    public class Source
    {
        public string type { get; set; }
        public string userId { get; set; }
    }

    public class Message
    {
        public string id { get; set; }
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Event
    {
        public string replyToken { get; set; }
        public string type { get; set; }
        public string mode { get; set; }
        public object timestamp { get; set; }
        public Source source { get; set; }
        public Message message { get; set; }
    }

    
}
