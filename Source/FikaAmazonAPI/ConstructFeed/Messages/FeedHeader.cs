﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace FikaAmazonAPI.ConstructFeed
{
    [Serializable]
    public class FeedHeader
    {
        [XmlElement]
        public string DocumentVersion { get; set; }

        [XmlElement]
        public string MerchantIdentifier { get; set; }
    }
}
