﻿using System.Collections.Generic;

namespace Visitor
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    public sealed class Person : IAsset
    {
        public Person()
        {
            Assets = new List<IAsset>();
        }

        public List<IAsset> Assets { get; set; }

        public void Accept(IVisitor visitor)
        {
            foreach (var asset in Assets)
            {
                asset.Accept(visitor);
            }
        }
    }
}
