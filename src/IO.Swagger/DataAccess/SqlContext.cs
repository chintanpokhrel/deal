using Microsoft.EntityFrameworkCore;
using IO.Swagger.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System.Text;

namespace IO.Swagger.DataAccess {
    public class SqlContext:DbContext {
        ///<summary>create an SqlContext</summary>
        ///
        public SqlContext(DbContextOptions<SqlContext> options):base(options) {
            
        }

        public DbSet<User> users { get; set; }
        public DbSet<Deal> deals { get; set; }
        public DbSet<DealClaim> dealClaims { get; set; }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges(); 
        }
    }

        /// <summary>A replacement for <see cref="NpgsqlSqlGenerationHelper"/>
    /// to convert PascalCaseCsharpyIdentifiers to alllowercasenames.
    /// So table and column names with no embedded punctuation
    /// get generated with no quotes or delimiters.</summary>
    public class NpgsqlSqlGenerationLowercasingHelper : NpgsqlSqlGenerationHelper
    {
        //Don't lowercase ef's migration table
        const string dontAlter="__EFMigrationsHistory";
        static string Customize(string input) => input==dontAlter? input : input.ToLower();
        public NpgsqlSqlGenerationLowercasingHelper(RelationalSqlGenerationHelperDependencies dependencies) 
            : base(dependencies) { }
        public override string DelimitIdentifier(string identifier)
            => base.DelimitIdentifier(Customize(identifier));
        public override void DelimitIdentifier(StringBuilder builder, string identifier)
            => base.DelimitIdentifier(builder, Customize(identifier));
    }
}