using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Core
{
    public abstract class BaseApplicationService
    {
        private ValidatorHelper _validatorHelper = new ValidatorHelper();
        protected void ValidationException(string message)
        {
            _validatorHelper.ValidationException(message);
        }
        protected void IsValid()
        {
            _validatorHelper.IsValid();
        }
        protected void AddError(string message)
        {
            _validatorHelper.AddError(message);
        }
        protected List<string> GetError()
        {
            return _validatorHelper.GetError();
        }
    }
}