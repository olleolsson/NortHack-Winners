using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using NortHack.Models;

namespace NortHack
{
    public partial class _Default : Page
    {
        private Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {

            //hej();
        }
        public void hej()
        {
            var hej = db.Idea.ToList();

            var query = from b in db.Idea
                        where b.Id == 1
                        select b;

            var key = db.Idea.Find(1);

            foreach (var item in query)
            {
                
            }

            List<Profile> profiles = new List<Profile>();
            List<Idea> ideas = new List<Idea>();

            profiles = db.Profile.ToList();
            ideas = db.Idea.ToList();

            Idea model = new Idea();
            foreach (var i in hej)
            {
                if (i.Id == 1)
                {
                    

                }
            }
        }
    }
}