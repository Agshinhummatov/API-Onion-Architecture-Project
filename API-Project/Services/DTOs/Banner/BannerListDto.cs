﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DTOs.Banner
{
    public class BannerListDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public byte[]? Image { get; set; }
    }
}
