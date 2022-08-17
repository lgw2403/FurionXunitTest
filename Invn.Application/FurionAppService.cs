using Furion.DynamicApiController;

namespace Invn.Application
{
    public class FurionAppService : IDynamicApiController
    {
        public string Get()
        {
            return $"Hello {nameof(Furion)}";
        }
    }
}