using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Ogani.Application.Models.DataContext;
using Ogani.Application.Models.Entity;

namespace Ogani.Application.Modules.CategoryModule
{
	public class CategoryCreateCommand : IRequest<bool>
	{
        public string Name { get; set; }

        public class CategoryCreateCommandHandler : IRequestHandler<CategoryCreateCommand, bool>
        {

            readonly OganiDbContext db;

            public CategoryCreateCommandHandler(OganiDbContext db)
            {
                this.db = db;
            }

            public async Task<bool> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
            {
                try
                {
                    Category model = new Category();
                    model.Name = request.Name;

                    db.Categories.Add(model);
                    await db.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return false;
                }


                return true;
            }
        }
    }
}

