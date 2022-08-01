using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;

namespace TwitterClone.Application.ViewModels
{
    public class PostDetailsViewModel
    {
        public string Content { get; private set; }
        public User PostOwner { get; private set; }

    }
}
