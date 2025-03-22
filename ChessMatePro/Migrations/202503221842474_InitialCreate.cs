namespace ChessMate_pro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameID = c.Int(nullable: false, identity: true),
                        EventName = c.String(),
                        Date = c.DateTime(nullable: false),
                        OpponentName = c.String(),
                        WhitePlayer = c.String(),
                        BlackPlayer = c.String(),
                        Result = c.String(),
                        PGNFileID = c.Guid(nullable: false),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameID)
                .ForeignKey("dbo.PGNFiles", t => t.PGNFileID, cascadeDelete: true)
                .Index(t => t.PGNFileID);
            
            CreateTable(
                "dbo.PGNFiles",
                c => new
                    {
                        PGNFileID = c.Guid(nullable: false),
                        Moves = c.String(),
                        Annotations = c.String(),
                        Comments = c.String(),
                        ExportStatus = c.String(),
                    })
                .PrimaryKey(t => t.PGNFileID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "PGNFileID", "dbo.PGNFiles");
            DropIndex("dbo.Games", new[] { "PGNFileID" });
            DropTable("dbo.PGNFiles");
            DropTable("dbo.Games");
        }
    }
}
