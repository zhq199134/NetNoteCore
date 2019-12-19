﻿// /Users/zhanghuqiang/Documents/GitHub/NetNote/NetNote.Models/Note.cs
// 2019/12/19
// zhanghuqiang-zhq_092012@163.com
using System;
  /// <summary>
  /// 笔记
  /// </summary>
    [Required]
    [MaxLength(100)]
    [Required]
    public string Password { get; set; }
    public string Attachment { get; set; }
    public int TypeId { get; set; }
    public NoteType Type { get; set; }
