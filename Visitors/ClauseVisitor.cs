// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;
using RAQL.NET.Linq;

namespace RAQL.NET.Visitors
{
    /// <summary>
    /// The clause visitor class
    /// </summary>
    /// <seealso cref="RAQLBaseVisitor{Expression{Func{TEntity, bool}}}"/>
    public class ClauseVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>> where TEntity : class
    {
        /// <summary>
        /// Visits the clause using the specified context
        /// </summary>
        /// <param name="context">The context</param>
        /// <returns>An expression of func t entity and bool</returns>
        public override Expression<Func<TEntity, bool>> VisitClause([NotNull] RAQLParser.ClauseContext context)
        {
            var conjunction = context.conjunction();
            var clauses = context.clause();
            var operation = context.operation();

            if (conjunction != null && clauses.Length == 2)
            {
                var isAnd = conjunction.GetText().ToLower().Contains("and");
                var clause1 = new ClauseVisitor<TEntity>().VisitClause(clauses.First());
                var clause2 = new ClauseVisitor<TEntity>().VisitClause(clauses.Last());
                return isAnd ? clause1.And(clause2) : clause1.Or(clause2);
            }
            else if (conjunction is null && clauses.Length == 1)
            {
                return new ClauseVisitor<TEntity>().VisitClause(clauses.First());
            }
            else if (conjunction is null && operation != null)
            {
                return new OperationVisitor<TEntity>().VisitOperation(operation) ?? PredicateBuilder.False<TEntity>();
            }

            return PredicateBuilder.False<TEntity>();
        }
    }
}