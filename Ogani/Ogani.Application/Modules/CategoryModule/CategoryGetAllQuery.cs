using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Ogani.Application.Models.DataContext;
using Ogani.Application.Models.Entity;

namespace Ogani.Application.Modules.CategoryModule
{
	public class CategoryGetAllQuery: IRequest<List<Category>>
	{

        public class CategoryGetAllQueryHandler : IRequestHandler<CategoryGetAllQuery, List<Category>>
        {
            readonly OganiDbContext db;

            public CategoryGetAllQueryHandler(OganiDbContext db)
            {
                this.db = db;
            }
            public async Task<List<Category>> Handle(CategoryGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Categories
               .Where(c => c.DeletedDate == null)
               .ToListAsync();

                return data;
            }
        }

    }
}

