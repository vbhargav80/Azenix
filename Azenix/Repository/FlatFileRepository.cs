using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Azenix.Repository
{
    public class FlatFileRepository : IRepository
    {
        private readonly string _filePath;

        public FlatFileRepository()
        {
            // TODO: this could have been injected via appsettings
            _filePath = "programming-task-example-data.log";
        }

        public List<string> GetLogFileEntries()
        {
            return File.ReadAllLines(_filePath).ToList();
        }
    }
}
