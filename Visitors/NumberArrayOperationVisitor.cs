// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
  public class NumberArrayOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
  {
    public override Expression<Func<TEntity, bool>> VisitNumber_array_operation([NotNull] RAQLParser.Number_array_operationContext context)
    {
      var field = context.field()?.GetText();
      var numbers = context.number_array()?.number();

      if (field != null && numbers != null)
      {
        try
        {
          var value = numbers.Select(s => double.Parse(s.GetText()));
          var prop = typeof(TEntity).GetProperty(field);
          var attribute = typeof(TEntity).GetField(field);

          if (prop != null)
          {
            if (prop.PropertyType == typeof(int) || prop.PropertyType == typeof(long) || prop.PropertyType == typeof(double) || prop.PropertyType == typeof(float) || prop.PropertyType == typeof(float))
            {
              return c => value.Any(v => (double)v == Convert.ToDouble(prop.GetValue(c)));
            }
          }
          else if (attribute != null)
          {
            if (attribute.FieldType == typeof(int) || attribute.FieldType == typeof(long) || attribute.FieldType == typeof(double) || attribute.FieldType == typeof(float) || attribute.FieldType == typeof(float))
            {
              return c => value.Any(v => (double)v == Convert.ToDouble(attribute.GetValue(c)));
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