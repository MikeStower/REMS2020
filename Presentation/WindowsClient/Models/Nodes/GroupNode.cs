﻿using System;

namespace WindowsClient.Models
{
    public class GroupNode : ImportNode<NullValidator>
    {
        public override string Key { get; }

        public override NullValidator Validator { get; set; } = new();

        public GroupNode(string name) : base(name)
        { }

        protected override void OnMenuOpening(object sender, EventArgs args)
        {
            // No current implementation
        }

        public override void Validate()
        {
            foreach (ColumnNode node in Nodes)
                node.Validate();

            Validator.Advice = Advice;
        }
    }
}