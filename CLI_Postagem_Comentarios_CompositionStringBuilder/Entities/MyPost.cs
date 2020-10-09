using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Postagem_Comentarios_CompositionStringBuilder.Entities
{
    class MyPost
    {
        private List<Post> ListMyPosts { get; set; }

        public MyPost()
        {
            ListMyPosts = new List<Post>();
        }

        public void AddPostInMyPost(Post p)
        {
            ListMyPosts.Add(p);
        }

        public void RemovePostInMyPost(Post p)
        {
            ListMyPosts.Remove(p);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Post p in ListMyPosts)
            {
                if (ListMyPosts.Count > 0)
                {
                    sb.AppendLine($"Postagem # {p.getID()}:");
                }
                sb.AppendLine(p.ToString());
            }
            return sb.ToString();
        }

        public void AddLikePost(int idPost)
        {
            foreach (Post p in ListMyPosts)
            {
                if (p.getID() == idPost)
                {
                    p.AddLike();
                }
            }
        }

        public void RemoveLikePost(int idPost)
        {
            foreach (Post p in ListMyPosts)
            {
                if (p.getID() == idPost)
                {
                    p.RemoveLike();
                }
            }
        }

        public void AddCommentPost(int idPost, Comment c)
        {
            foreach (Post p in ListMyPosts)
            {
                if (p.getID() == idPost)
                {
                    p.AddComment(c);
                }
            }
        }
    }
}
