using Domain.Entities;
using MediatR;
using Persistence.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Features.Commands.CategoryCommands
{
    public class CreateCategoryCommand : IRequest<Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CreateCategoryCommand(CategoryDTO category)
        {
            Name = category.Name;
            Description = category.Description;
        }
    }
}
