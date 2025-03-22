namespace ChessMate_pro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Games");
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Guid(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Wins = c.Int(),
                        Losses = c.Int(),
                        GamesPlayed = c.Int(),
                    })
                .PrimaryKey(t => t.UserID);
            
            AlterColumn("dbo.Games", "GameID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Games", "UserID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Games", "GameID");
            CreateIndex("dbo.Games", "UserID");
            AddForeignKey("dbo.Games", "UserID", "dbo.Users", "UserID", cascadeDelete: true);
            DropColumn("dbo.Games", "WhitePlayer");
            DropColumn("dbo.Games", "BlackPlayer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "BlackPlayer", c => c.String());
            AddColumn("dbo.Games", "WhitePlayer", c => c.String());
            DropForeignKey("dbo.Games", "UserID", "dbo.Users");
            DropIndex("dbo.Games", new[] { "UserID" });
            DropPrimaryKey("dbo.Games");
            AlterColumn("dbo.Games", "UserID", c => c.Int(nullable: false));
            AlterColumn("dbo.Games", "GameID", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Users");
            AddPrimaryKey("dbo.Games", "GameID");
        }
    }
}
