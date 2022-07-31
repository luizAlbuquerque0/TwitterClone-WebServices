using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Core.Entites
{
    public class Post : BaseEntity
    {
        public string Content { get; private set; }
        public int IdPostOwner { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<> MyProperty { get; private set; }

    }
}
