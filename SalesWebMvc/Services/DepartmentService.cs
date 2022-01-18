using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync() // esse método está assincrono (ele funcionará sem que a aplicação seja interrompida para sua execução)
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync(); // expressão lambda com uma chamada assincrona tbm
        }
    }
}
