﻿using postMortem.Data.Common;
using postMortem.Data.Model;
using postMortem.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postMortem.Data.Repository.Instance
{
    public class ReportRepository : postMortemRepository<Report>, IReportRepository
    {
        public ReportRepository(postMortemContext context) : base(context)
        {
        }
    }
}
