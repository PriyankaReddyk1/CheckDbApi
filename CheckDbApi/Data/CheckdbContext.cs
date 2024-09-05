using Microsoft.EntityFrameworkCore;
using System;

namespace CheckDbApi.Data
{
	public class CheckdbContext:DbContext
	{
        public CheckdbContext(DbContextOptions<CheckdbContext> options): base(options) 
        {
            
        }
    }
}
