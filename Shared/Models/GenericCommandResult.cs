﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Remotely.Shared.Models
{
    public class GenericCommandResult
    {
        public string DeviceID { get; set; }
        public string CommandResultID { get; set; }
        public string CommandType { get; set; }
        public string StandardOutput { get; set; }
        public string ErrorOutput { get; set; }
        public DateTimeOffset TimeStamp { get; set; } = DateTimeOffset.Now;
    }
}
