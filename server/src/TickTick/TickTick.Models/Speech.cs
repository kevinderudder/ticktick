using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTick.Models.Contracts;

namespace TickTick.Models
{
    public class Speech : BaseEntity, IPlaylistItem
    {
        public string Title { get; set; }
        public string? Speaker { get; set; }
        public TimeSpan? Duration { get; set ; }
        public string Text { get; set; }
        public uint SequenceNumber { get; set ; }
    }
}
