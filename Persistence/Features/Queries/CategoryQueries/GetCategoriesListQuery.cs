﻿using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Features.Queries.CategoryQueries
{
    public class GetCategoriesListQuery : IRequest<List<Category>>
    {
    }
}
