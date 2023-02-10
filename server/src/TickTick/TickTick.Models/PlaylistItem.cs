using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTick.Models
{
    public enum PlaylistItemType
    {
        SONG   = 0,
        SPEECH = 1
    }

    public class PlaylistItem:BaseAuditableEntity
    {
        public Guid PublicId { get; set; }
        public string Title { get; set; }
        public string Performer { get; set; }
        public string? Text { get; set; }
        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public uint SequenceNumber { get; set; }
        public PlaylistItemType Type { get; set; }
    }
}
