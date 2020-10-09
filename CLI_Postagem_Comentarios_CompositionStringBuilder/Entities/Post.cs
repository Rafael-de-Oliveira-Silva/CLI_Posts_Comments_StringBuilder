using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Postagem_Comentarios_CompositionStringBuilder.Entities
{
    class Post
    {
        private int Id { get;  set; }

        private DateTime Moment { get; set; }

        private string Title { get; set; }

        private string Content { get; set; }

        private int Likes { get; set; }

        private List<Comment> ListComments;

        public Post(DateTime moment, string title, string content, int id)
        {
            this.Moment = moment;
            this.Title = title;
            this.Content = content;
            this.Likes = 0;
            this.Id = id;
            this.ListComments = new List<Comment>();
        }

        public int getID() {
            return this.Id;
        }

        public void AddComment(Comment c)
        {
            ListComments.Add(c);
        }

        public void RemoveComment(Comment c)
        {
            ListComments.Remove(c);
        }

        public void ViewerAllComments()
        {
            ;
        }

        public void AddLike()
        {
            Likes++;
        }

        public void RemoveLike()
        {
            Likes--;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");

            foreach (Comment comment in ListComments)
            {
                sb.AppendLine(comment.ToString());
            }

            return sb.ToString();
        }
    }
}
