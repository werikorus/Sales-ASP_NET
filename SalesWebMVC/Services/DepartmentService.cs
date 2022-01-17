﻿using SalesWebMVC.Models;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;

        }

        public async Task<List<Department>> FindAllAsync()
        {
            //feito por mim para aprender mais 
            List<Department> result = null;

            try
            {
               result = await _context.Department.OrderBy(x => x.Name).ToListAsync();
            }
            catch
            {

            }
            
            return result;
        }

    }
}
