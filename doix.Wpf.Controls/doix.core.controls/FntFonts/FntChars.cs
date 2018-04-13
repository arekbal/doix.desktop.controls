﻿using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace doix.core.controls.FntFonts
{
    public struct FntChars
    {
        [XmlAttribute("count")]
        public int Count { get; set; }

        [XmlElement("char")]
        public FntChar[] Items { get; set; }
    }
}
