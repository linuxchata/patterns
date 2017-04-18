using System.Collections.Generic;

namespace Adapter
{
    public class PatternRenderer
    {
        private readonly IDataPatterRendererAdapter dataPatterRendererAdapter;

        public PatternRenderer()
            : this(new DataPatterRendererAdapter())
        {
        }

        public PatternRenderer(IDataPatterRendererAdapter dataPatterRendererAdapter)
        {
            this.dataPatterRendererAdapter = dataPatterRendererAdapter;
        }

        public string PatternsList(IEnumerable<Pattern> patterns)
        {
            return this.dataPatterRendererAdapter.PatternsList(patterns);
        }
    }
}
