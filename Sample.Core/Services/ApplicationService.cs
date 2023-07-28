using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample.Core
{
    public interface IApplicationService
    {

    }
    public abstract class ApplicationService : BaseApplicationService, IApplicationService
    {

    }
}