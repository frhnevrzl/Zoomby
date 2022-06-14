namespace ZoomScheduler.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TB_T_Scheduler", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.TB_T_Scheduler", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Zoom", "UpdateDate", c => c.DateTime());
            AlterColumn("dbo.TB_M_Zoom", "DeleteDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TB_M_Zoom", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_Zoom", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_M_User", "UpdateDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_T_Scheduler", "DeleteDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.TB_T_Scheduler", "UpdateDate", c => c.DateTime(nullable: false));
        }
    }
}
