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

        public string Name;
        public string Owner;
        public string Description;
        public int Likes;
        public int Contributors;
        public int Followers;
        public string PictureUrl;
       // int counter = 1;
        private int counter
        {
            get
            {
                if (Session["i"] == null)
                return 1;
                return (int)Session["i"];
            }
            set
            {
                Session["i"] = value;
            }
        }

        private Entities db = new Entities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var IdeaList = db.Idea.ToList();
            foreach (var i in IdeaList)
            {

                if (i.Id == counter)
                {

                    this.Name = i.Name;
                    this.Owner = i.Owner;
                    this.Description = i.Description;
                    this.Likes = i.Likes.Value;
                    this.Contributors = i.Contributors.Value;
                    this.Followers = i.Followers.Value;
                    this.PictureUrl = i.PictureUrl;
                    break;
                }
            }

        }
        public void GetIdea(Object sender, EventArgs e)
        {
            var IdeaList = db.Idea.ToList();
            foreach (var i in IdeaList)
            {
                
                if (i.Id == counter)
                {

                    this.Name = i.Name;
                    this.Owner = i.Owner;
                    this.Description = i.Description;
                    this.Likes = i.Likes.Value;
                    this.Contributors = i.Contributors.Value;
                    this.Followers = i.Followers.Value;
                    counter++;
                    break;
                }
            }
        }
        public void Like(Object sender, EventArgs e)
        {
            int totalLikes;
            var IdeaList = db.Idea.ToList();
            foreach (var i in IdeaList)
            {
                if (i.Id == counter)
                {
                    totalLikes = i.Likes.Value;
                    totalLikes++;
                    i.Likes = totalLikes;
                    db.SaveChanges();
                }              
            }            
        }
        public void Follow(Object sender, EventArgs e)
        {
            int totalFollows;
            var IdeaList = db.Idea.ToList();
            foreach (var i in IdeaList)
            {
                if (i.Id == counter)
                {
                    totalFollows = i.Followers.Value;
                    totalFollows++;
                    i.Followers = totalFollows;
                    db.SaveChanges();
                }
            }
        }
        public void Contribute(Object sender, EventArgs e)
        {
            int totalContribute;
            var IdeaList = db.Idea.ToList();
            foreach (var i in IdeaList)
            {
                if (i.Id == counter)
                {
                    totalContribute = i.Contributors.Value;
                    totalContribute++;
                    i.Contributors = totalContribute;
                    db.SaveChanges();
                }
            }
        }

        private void InitializeComponent()
        {

        }
    }
}