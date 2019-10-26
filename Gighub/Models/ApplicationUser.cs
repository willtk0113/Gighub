using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Gighub.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public ICollection<Following> Follower { get; set; }
        public ICollection<Following> Followee { get; set; }

        public ApplicationUser()
        {
            Follower = new Collection<Following>();
            Followee = new Collection<Following>();
        }
    }
}