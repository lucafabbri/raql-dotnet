// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
    public class BoolOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
    {
        public override Expression<Func<TEntity, bool>> VisitBool_operation([NotNull] RAQLParser.Bool_operationContext context)
        {
            var field = context.field()?.GetText();
            var @operator = context.bool_operator()?.GetText().ToLower().Trim();
            var value = context.@bool()?.GetText() == "true";

            if (field != null && @operator != null)
            {
                try
                {
                    var prop = typeof(TEntity).GetProperty(field);
                    var attribute = typeof(TEntity).GetField(field);

                    if (prop != null && prop.PropertyType == typeof(bool))
                    {
                        switch (@operator)
                        {
                            case "not equals":
                            case "!=":
                                return c => (bool)prop.GetValue(c) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => (bool)prop.GetValue(c) == value;
                        }
                    }
                    else if (attribute != null && attribute.FieldType == typeof(bool))
                    {
                        switch (@operator)
                        {
                            case "not equals":
                            case "!=":
                                return c => (bool)attribute.GetValue(c) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => (bool)attribute.GetValue(c) == value;
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
