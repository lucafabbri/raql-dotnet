// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
    public class NumberOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
    {
        public override Expression<Func<TEntity, bool>>? VisitNumber_operation([NotNull] RAQLParser.Number_operationContext context)
        {
            var field = context.field()?.GetText();
            var @operator = context.number_operator()?.GetText().ToLower().Trim();
            var number = context.number()?.GetText();

            if (field != null && @operator != null && number != null)
            {
                try
                {
                    var value = double.Parse(number);
                    var prop = typeof(TEntity).GetProperty(field);
                    var attribute = typeof(TEntity).GetField(field);

                    if (prop != null && (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(long) || prop.PropertyType == typeof(double) || prop.PropertyType == typeof(float) || prop.PropertyType == typeof(float)))
                    {
                        switch (@operator)
                        {
                            case "greater than":
                            case ">":
                                return c => Convert.ToDouble(prop.GetValue(c)) > value;
                            case ">=":
                                return c => Convert.ToDouble(prop.GetValue(c)) >= value;
                            case "lower than":
                            case "<":
                                return c => Convert.ToDouble(prop.GetValue(c)) < value;
                            case "<=":
                                return c => Convert.ToDouble(prop.GetValue(c)) <= value;
                            case "not equals":
                            case "!=":
                                return c => Convert.ToDouble(prop.GetValue(c)) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => Convert.ToDouble(prop.GetValue(c)) == value;
                        }
                    }
                    else if (attribute != null && (attribute.FieldType == typeof(int) || attribute.FieldType == typeof(long) || attribute.FieldType == typeof(double) || attribute.FieldType == typeof(float) || attribute.FieldType == typeof(float)))
                    {
                        switch (@operator)
                        {
                            case "greater than":
                            case ">":
                                return c => Convert.ToDouble(attribute.GetValue(c)) > value;
                            case ">=":
                                return c => Convert.ToDouble(attribute.GetValue(c)) >= value;
                            case "lower than":
                            case "<":
                                return c => Convert.ToDouble(attribute.GetValue(c)) < value;
                            case "<=":
                                return c => Convert.ToDouble(attribute.GetValue(c)) <= value;
                            case "not equals":
                            case "!=":
                                return c => Convert.ToDouble(attribute.GetValue(c)) != value;
                            case "equals":
                            case "=":
                            default:
                                return c => Convert.ToDouble(attribute.GetValue(c)) == value;
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
