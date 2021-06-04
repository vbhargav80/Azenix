using System.Collections.Generic;

namespace Azenix.Repository
{
    public interface IRepository
    {
        List<string> GetLogFileEntries();
    }
}
