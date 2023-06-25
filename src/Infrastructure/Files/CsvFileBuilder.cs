using System.Globalization;
using valkimia_challenge.Application.Common.Interfaces;
using valkimia_challenge.Application.TodoLists.Queries.ExportTodos;
using valkimia_challenge.Infrastructure.Files.Maps;
using CsvHelper;

namespace valkimia_challenge.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
