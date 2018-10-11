﻿using System;
using System.Collections.Generic;
using eideas.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace eideas.Models
{
    public class EIdeasUser : IdentityUser
    {
        
        public EIdeasUser()
        {
        }

        public Division UserDivision {get; set;}

        public Unit UserUnit {get; set;}      

        public Team Team { get; set; }

        public ICollection<IdeaComment> IdeaComments { get; set; }

        public ICollection<IdeaSubscription> IdeaSubscriptions { get; set; }

        public ICollection<IdeaUpDoot> IdeaUpdoots { get; set; }

        public ICollection<CommentUpDoot> CommentUpDoots { get; set; }
    }
}
