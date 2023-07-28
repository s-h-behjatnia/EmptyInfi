using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Core
{
    public class ValidatorHelper
    {
        private List<string> errosList { get; set; }

        public ValidatorHelper()
        {
            errosList = new List<string>();
        }
        public void ValidationException(string message)
        {
            if (message != string.Empty)
            {
                throw new Exception(message);
            }
        }
        public void IsValid()
        {
            if (GetError().Any())
            {
                var errorMessage = string.Join("\n", errosList);
                throw new Exception(errorMessage);
            }
        }
        public void AddError(string message)
        {
            errosList.Add(message);
        }
        public List<string> GetError()
        {
            return errosList;
        }
    }
}