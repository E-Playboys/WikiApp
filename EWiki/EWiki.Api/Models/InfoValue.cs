﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EWiki.Api.Models
{
    public class InfoValue : EntityBase
    {
        public LinkTo LinkTo { get; set; }
        public int LinkToId { get; set; }
        public string UrlFormat { get; set; }
        public int Priority { get; set; }
    }
}
