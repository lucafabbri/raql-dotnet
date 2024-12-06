// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
  /// <summary>
  /// The string array operation visitor class
  /// </summary>
  /// <seealso cref="RAQLBaseVisitor{Expression{Func{TEntity, bool}}?}"/>
  public class StringArrayOperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
  {
    /// <summary>
    /// Visits the string array operation using the specified context
    /// </summary>
    /// <param name="context">The context</param>
    /// <returns>An expression of func t entity and bool</returns>
    public override Expression<Func<TEntity, bool>>? VisitString_array_operation([NotNull] RAQLParser.String_array_operationContext context)
    {
      var field = context.field()?.GetText();
      var value = context.string_array()?.@string().Select(s => s.GetText().Trim('\''));

      if (field != null && value != null)
      {
        try
        {
          var prop = typeof(TEntity).GetProperty(field);
          var attribute = typeof(TEntity).GetField(field);

          if (prop != null && prop.PropertyType == typeof(string))
          {
            return c => value.Any(v => v == (string)prop.GetValue(c));
          }
          else if (attribute != null && attribute.FieldType == typeof(string))
          {
            return c => value.Any(v => v == (string)attribute.GetValue(c));
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