using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using yxyl.leanr.Albums;

namespace yxyl.leanr.EntityFrameworkCore
{
    public static class leanrDbContextModelCreatingExtensions
    {
        public static void Configureleanr(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(leanrConsts.DbTablePrefix + "YourEntities", leanrConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
            builder.Entity<Category>(b =>
            {

                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}