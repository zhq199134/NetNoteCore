﻿// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote.Models/NoteContext.cs
// 2019/12/19
// zhanghuqiang-zhq_092012@163.com
using System;using JetBrains.Annotations;using Microsoft.EntityFrameworkCore;namespace NetNote.Models{  public class NoteSqlServerContext : DbContext  {    public NoteSqlServerContext(DbContextOptions<NoteSqlServerContext> options) : base(options)    {    }
    public DbSet<Note> Notes { get; set; }    public DbSet<NoteType> NoteTypes { get; set; }  }}