﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MVClient
{
    class ModelInput
    {
        public byte[] Image { get; set; }

        public UInt32 LabelAsKey { get; set; }

        public string ImagePath { get; set; }

        public string Label { get; set; }
    }
}
