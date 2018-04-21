﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedditApi.BodiesOut
{
    public class Post : DataAnswer
    {

        public Post(int postId, string title, string description, string path, string user, int upvotes, int downvotes)
        {
            this.postId = postId;
            this.title = title;
            this.description = description;
            this.path = path;
            this.user = user;
            this.upvotes = upvotes;
            this.downvotes = downvotes;
            this.comment = new List<Comment>();
        }

        public Post(int postId, string title, string description, string path, string user, int upvotes, int downvotes, int yourvote) : this(postId, title, description, path, user, upvotes, downvotes)
        {
            this.yourvote = yourvote;
        }

        public int postId { get; private set; }
        public string title { get; private set; }
        public string description { get; private set; }
        public string path { get; private set; }
        public string user { get; private set; }
        public int upvotes { get; private set; }
        public int downvotes { get; private set; }
        public int yourvote { get; private set; }
        public List<Comment> comment { get; private set; }
    }
}
