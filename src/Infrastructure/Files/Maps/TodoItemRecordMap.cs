﻿using System.Globalization;
using valkimia_challenge.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace valkimia_challenge.Infrastructure.Files.Maps;

public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
