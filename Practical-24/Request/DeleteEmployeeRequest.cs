﻿using Practical_24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_24.Repository
{
    public class DeleteEmployeeRequest:MediatR.IRequest<bool>
    {
        public int EMP_ID { get; set; }
    }
}
