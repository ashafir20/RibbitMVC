using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace RibbitMVC.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserProfileId { get; set; }

        [ForeignKey("UserProfileId")]
        public virtual UserProfile Profile { get; set; }

        private ICollection<Ribbit> _ribbits;
        public virtual ICollection<Ribbit> Ribbits
        {
            get { return _ribbits ?? (_ribbits = new Collection<Ribbit>()); }
            set { _ribbits = value; }
        }

        private ICollection<User> _following;
        public virtual ICollection<User> Following
        {
            get { return _following ?? (_following = new Collection<User>()); }
            set { _following = value; }
        }

        private ICollection<User> _followers;
        public virtual ICollection<User> Followers
        {
            get { return _followers ?? (_followers = new Collection<User>()); }
            set { _followers = value; }
        }
    }
}