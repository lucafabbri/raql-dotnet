// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;
using Antlr4.Runtime.Misc;

namespace RAQL.NET.Visitors
{
  public class OperationVisitor<TEntity> : RAQLBaseVisitor<Expression<Func<TEntity, bool>>?> where TEntity : class
  {
    public override Expression<Func<TEntity, bool>>? VisitOperation([NotNull] RAQLParser.OperationContext context)
    {
      var stringOperation = context.string_operation();
      var stringArrayOperation = context.string_array_operation();
      var numberOperation = context.number_operation();
      var numberArrayOperation = context.number_array_operation();
      var boolOperation = context.bool_operation();
      var boolArrayOperation = context.bool_array_operation();

      var isStringOperation = stringOperation != null;
      var isStringArrayOperation = stringArrayOperation != null;
      var isNumberOperation = numberOperation != null;
      var isNumberArrayOperation = numberArrayOperation != null;
      var isBoolOperation = boolOperation != null;
      var isBoolArrayOperation = boolArrayOperation != null;

      if (isStringOperation)
      {
        return new StringOperationVisitor<TEntity>().VisitString_operation(stringOperation);
      }
      else if (isStringArrayOperation)
      {
        return new StringArrayOperationVisitor<TEntity>().VisitString_array_operation(stringArrayOperation);
      }
      else if (isNumberOperation)
      {
        return new NumberOperationVisitor<TEntity>().VisitNumber_operation(numberOperation);

      }
      else if (isNumberArrayOperation)
      {
        return new NumberArrayOperationVisitor<TEntity>().VisitNumber_array_operation(numberArrayOperation);

      }
      else if (isBoolOperation)
      {
        return new BoolOperationVisitor<TEntity>().VisitBool_operation(boolOperation);

      }
      else if (isBoolArrayOperation)
      {
        return new BoolArrayOperationVisitor<TEntity>().VisitBool_array_operation(boolArrayOperation);

      }
      return null;
    }
  }
}
