using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace MVC_PROJECT.Models {
    public partial class Friends : DbContext {
        public Friends() : base("name=Friends") { }

        public virtual DbSet<Friend> FriendsDB { get; set; }
    }
}