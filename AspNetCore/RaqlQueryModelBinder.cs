using Microsoft.AspNetCore.Mvc.ModelBinding;
using RAQL.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAQL.NET.AspNetCore
{
    public class RaqlQueryModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.ModelName;

            // Try to fetch the value of the argument by name
            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            var value = valueProviderResult.FirstValue;

            // Check if the argument value is null or empty
            if (string.IsNullOrEmpty(value))
            {
                return Task.CompletedTask;
            }

            try
            {
                RaqlQuery param = value;

                bindingContext.Result = ModelBindingResult.Success(param);
                return Task.CompletedTask;
            }
            catch(Exception e)
            {
                // Non-integer arguments result in model state errors
                bindingContext.ModelState.TryAddModelError(modelName, e.Message);
                return Task.CompletedTask;
            }
        }
    }
}
