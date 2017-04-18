using System.Collections.Generic;

namespace Adapter
{
    public interface IDataPatterRendererAdapter
    {
        string PatternsList(IEnumerable<Pattern> patterns);
    }
}
