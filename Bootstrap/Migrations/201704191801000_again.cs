namespace Bootstrap.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class again : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Score = c.String(),
                        AwayTeamID = c.Int(),
                        HomeTeamID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teams", t => t.AwayTeamID)
                .ForeignKey("dbo.Teams", t => t.HomeTeamID)
                .Index(t => t.AwayTeamID)
                .Index(t => t.HomeTeamID);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfPlayers = c.Int(nullable: false),
                        SportID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sports", t => t.SportID, cascadeDelete: true)
                .Index(t => t.SportID);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "HomeTeamID", "dbo.Teams");
            DropForeignKey("dbo.Games", "AwayTeamID", "dbo.Teams");
            DropForeignKey("dbo.Teams", "SportID", "dbo.Sports");
            DropIndex("dbo.Teams", new[] { "SportID" });
            DropIndex("dbo.Games", new[] { "HomeTeamID" });
            DropIndex("dbo.Games", new[] { "AwayTeamID" });
            DropTable("dbo.Sports");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
        }
    }
}
