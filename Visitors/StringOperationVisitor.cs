// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
    /// <summary>
    /// The string operation visitor class
    /// </summary>
    /// <seealso cref="RAQLBaseVisitor{Expression{Func{TEntity, bool}}?}"/>
    public class StringOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
    {
        /// <summary>
        /// Visits the string operation using the specified context
        /// </summary>
        /// <param name="context">The context</param>
        /// <returns>An expression of func t entity and bool</returns>
        public override Expression<Func<TEntity, bool>>? VisitString_operation([NotNull] RAQLParser.String_operationContext context)
        {
            var field = context.field()?.GetText();
            var @operator = context.string_operator()?.GetText().ToLower().Trim();
            var value = context.@string()?.GetText().Trim('\'');

            if (field != null && @operator != null)
            {
                try
                {
                    var prop = typeof(TEntity).GetProperty(field);
                    var attribute = typeof(TEntity).GetField(field);

                    if (prop != null && prop.PropertyType == typeof(string))
                    {
                        switch (@operator)
                        {
                            case "like":
                                return c => ((string)prop.GetValue(c)).Contains(value);
                            case "not equals":
                            case "!=":
                                return c => (string)prop.GetValue(c) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => (string)prop.GetValue(c) == value;
                        }
                    }
                    else if (attribute != null && attribute.FieldType == typeof(string))
                    {
                        switch (@operator)
                        {
                            case "like":
                                return c => ((string)prop.GetValue(c)).Contains(value);
                            case "not equals":
                            case "!=":
                                return c => (string)attribute.GetValue(c) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => (string)attribute.GetValue(c) == value;
                        }
                    }
                }
                catch
                {
                    //do nothing
                }
            }

            return null;
        }
    }
}
