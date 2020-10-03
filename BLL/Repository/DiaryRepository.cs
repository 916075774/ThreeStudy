﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repository
{
    public class DiaryRepository : Repository<Diary>
    {
        public DbSet<Diary> diaries { get; set; }

    }
}
