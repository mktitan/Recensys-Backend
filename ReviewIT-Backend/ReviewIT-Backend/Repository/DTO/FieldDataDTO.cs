﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewIT_Backend.Repository.DTO
{
    public class FieldDataDTO
    {
        public int F_Id { get; set; }
        public int Field_Id { get; set; }
        public int Task_Id { get; set; }
        public int Article_Id { get; set; }
        public string Data { get; set; }
    }
}