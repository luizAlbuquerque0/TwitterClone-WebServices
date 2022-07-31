using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TwitterClone.Core.Entites;

namespace TwitterClone.Infrastructure.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.
                HasKey(p => p.Id);

            builder
                .HasOne(p=> p.PostOwner)
                .WithMany(u=> u.Posts)
                .HasForeignKey(p => p.IdPostOwner)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
