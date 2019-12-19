﻿using System;
using System.Collections.Generic;
{
    Task<List<Note>> GetListAsync();
    Task AddAsync(Note note);
    Task UpdateAsync(Note note);
    Tuple<List<Note>, int> PageList(int pageIndex, int pageSize);
}