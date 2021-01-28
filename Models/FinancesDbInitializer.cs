using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC.Models
{
    public class FinancesDbInitializer: DropCreateDatabaseAlways<FinancesContext>
    {
        public override void InitializeDatabase(FinancesContext context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction
                , string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }
        protected override void Seed(FinancesContext db)
        {
            db.Groups.Add(new Group { Group_id = 1, GroupName = "KN-307"});
            db.Groups.Add(new Group { Group_id = 2, GroupName = "PZ-33"});
            db.Groups.Add(new Group { Group_id = 3, GroupName = "SA-34"});

            base.Seed(db);
        }
    }
}