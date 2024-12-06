// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

namespace RAQL.NET.Linq
{
    /// <summary>
    /// The predicate builder class
    /// </summary>
    public static class PredicateBuilder
    {
        /// <summary>
        /// Trues
        /// </summary>
        /// <typeparam name="T">The </typeparam>
        /// <returns>An expression of func t and bool</returns>
        public static Expression<Func<T, bool>> True<T>() { return f => true; }
        /// <summary>
        /// Falses
        /// </summary>
        /// <typeparam name="T">The </typeparam>
        /// <returns>An expression of func t and bool</returns>
        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        /// <summary>
        /// Ors the expr 1
        /// </summary>
        /// <typeparam name="T">The </typeparam>
        /// <param name="expr1">The expr</param>
        /// <param name="expr2">The expr</param>
        /// <returns>An expression of func t and bool</returns>
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1,
                                                            Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
        }

        /// <summary>
        /// Ands the expr 1
        /// </summary>
        /// <typeparam name="T">The </typeparam>
        /// <param name="expr1">The expr</param>
        /// <param name="expr2">The expr</param>
        /// <returns>An expression of func t and bool</returns>
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
                                                             Expression<Func<T, bool>> expr2)
        {
            var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
            return Expression.Lambda<Func<T, bool>>
                  (Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
        }
    }
}