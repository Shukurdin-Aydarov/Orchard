﻿using System.Collections.Generic;
using Orchard.Comments.Models;
using Orchard.Mvc.ViewModels;

namespace Orchard.Comments.ViewModels {
    public class CommentsIndexViewModel : AdminViewModel {
        public IList<CommentEntry> Comments { get; set; }
        public CommentIndexOptions Options { get; set; }
    }

    public class CommentEntry {
        public Comment Comment { get; set; }
        public bool IsChecked { get; set; }
    }

    public class CommentIndexOptions {
        public CommentIndexFilter Filter { get; set; }
        public CommentIndexBulkAction BulkAction { get; set; }
    }

    public enum CommentIndexBulkAction {
        None,
        Delete,
        MarkAsSpam,
    }

    public enum CommentIndexFilter {
        All,
        Approved,
        Spam,
    }
}
