using Antlr4.Runtime;
using RAQL.NET.Models;
using RAQL.NET.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAQL.NET.Linq
{
    public static class RaqlExtension
    {
        public static IQueryable<T> Raql<T>(this IQueryable<T> items, RaqlQuery query) where T : class
        {
            if (query?.Clause != null)
            {
                return items.Where(new ClauseVisitor<T>().VisitClause(query.Clause));
            }
            return items;
        }
    }
}
