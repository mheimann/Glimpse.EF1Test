using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Glimpse.EF1Test
{
	public partial class _Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			using (var entityCtx = new TestEntities())
			{
				List<Division> allDivisionsWithProducts = entityCtx.Division.Include("Product").ToList();
			}
		}
	}
}