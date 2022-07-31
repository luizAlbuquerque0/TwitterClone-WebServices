using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Core.Entites;

namespace TwitterClone.Infrastructure.Configurations
{
    public class PostCommentConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .HasOne(p=> p.Post)
                .WithMany(p=> p.Comments)
                .HasForeignKey(p=> p.IdPost)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.CommentOwner)
                .WithMany(c => c.Comments)
                .HasForeignKey(p => p.IdCommentOwner);
        }
    }
}
