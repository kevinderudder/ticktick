using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTick.Models.Contracts;

namespace TickTick.Models
{
    public class Playlist : BaseAuditableEntity
    {
        public Guid PublicId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public IList<PlaylistItem> Items { get; set; }

    }
}
