// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
  public class BoolArrayOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
  {
    public override Expression<Func<TEntity, bool>> VisitBool_array_operation([NotNull] RAQLParser.Bool_array_operationContext context)
    {
      var field = context.field()?.GetText();
      var value = context.bool_array()?.@bool().Select(s => s.GetText().ToLower() == "true");

      if (field != null && value != null)
      {
        try
        {
          var prop = typeof(TEntity).GetProperty(field);
          var attribute = typeof(TEntity).GetField(field);

          if (prop != null && prop.PropertyType == typeof(bool))
          {
            return c => value.Any(v => v == (bool)prop.GetValue(c));
          }
          else if (attribute != null && attribute.FieldType == typeof(bool))
          {
            return c => value.Any(v => v == (bool)attribute.GetValue(c));
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
