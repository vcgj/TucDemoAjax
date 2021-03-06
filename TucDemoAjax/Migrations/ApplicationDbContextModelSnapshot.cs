// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TucDemoAjax.Data;

namespace TucDemoAjax.Migrations
{
    [DbContext(typeof(ApplicationDataContext.ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TucDemoAjax.Data.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AwayId")
                        .HasColumnType("int");

                    b.Property<int>("Awayscores")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HomeId")
                        .HasColumnType("int");

                    b.Property<int>("Homescores")
                        .HasColumnType("int");

                    b.Property<int>("Spectators")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AwayId");

                    b.HasIndex("HomeId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("TucDemoAjax.Data.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("TucDemoAjax.Data.Game", b =>
                {
                    b.HasOne("TucDemoAjax.Data.Team", "Away")
                        .WithMany()
                        .HasForeignKey("AwayId");

                    b.HasOne("TucDemoAjax.Data.Team", "Home")
                        .WithMany()
                        .HasForeignKey("HomeId");

                    b.Navigation("Away");

                    b.Navigation("Home");
                });
#pragma warning restore 612, 618
        }
    }
}
