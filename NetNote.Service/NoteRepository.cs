﻿using System;
using System.Collections.Generic;
{
    private NoteContext context;
      return context.SaveChangesAsync();
      var count = query.Count();
      var pageCount = count % pageSize == 0 ? count / pageSize : count / pageSize + 1;
      var notes = query.OrderByDescending(r => r.CreateDate).Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
      return new Tuple<List<Note>, int>(notes, pageCount);
      return context.SaveChangesAsync();
}