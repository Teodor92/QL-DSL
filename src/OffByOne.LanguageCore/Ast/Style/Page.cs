﻿namespace OffByOne.LanguageCore.Ast.Style
{
    using System.Collections.Generic;

    public class Page : AstNode
    {
        public Page(string id, ICollection<AstNode> nodes)
        {
            this.Id = id;
            this.Nodes = nodes;
        }

        public string Id { get; private set; }

        public ICollection<AstNode> Nodes { get; private set; }
    }
}
