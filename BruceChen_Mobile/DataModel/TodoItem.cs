﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BruceChen_Mobile
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }
    }
}
