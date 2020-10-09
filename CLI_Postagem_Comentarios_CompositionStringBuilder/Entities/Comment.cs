using System;
using System.Collections.Generic;
using System.Text;

namespace CLI_Postagem_Comentarios_CompositionStringBuilder.Entities
{
    class Comment
    {
        private string Text { get; set; }

        public Comment(string text)
        {
            this.Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
