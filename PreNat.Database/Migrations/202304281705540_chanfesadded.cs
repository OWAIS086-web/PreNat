namespace PreNat.Database.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class chanfesadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Obstetrichistories", "Preterm", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Ectopic", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Obitus", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Molas", c => c.Int(nullable: false));
            DropColumn("dbo.Obstetrichistories", "Premature");
            DropColumn("dbo.Obstetrichistories", "Ectopicos");
            DropColumn("dbo.Obstetrichistories", "Obitos");
            DropColumn("dbo.Obstetrichistories", "Springs");
        }

        public override void Down()
        {
            AddColumn("dbo.Obstetrichistories", "Springs", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Obitos", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Ectopicos", c => c.Int(nullable: false));
            AddColumn("dbo.Obstetrichistories", "Premature", c => c.Int(nullable: false));
            DropColumn("dbo.Obstetrichistories", "Molas");
            DropColumn("dbo.Obstetrichistories", "Obitus");
            DropColumn("dbo.Obstetrichistories", "Ectopic");
            DropColumn("dbo.Obstetrichistories", "Preterm");
        }
    }
}
