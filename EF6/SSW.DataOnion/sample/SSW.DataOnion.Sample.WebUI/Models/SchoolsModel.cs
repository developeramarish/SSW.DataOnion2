﻿using System.Collections.Generic;
using SSW.DataOnion.Sample.Entities;

namespace SSW.DataOnion.Sample.WebUI.Models
{
    public class SchoolsModel
    {
        public List<School> Schools { get; set; }

        public Student Student { get; set; }
    }
}
