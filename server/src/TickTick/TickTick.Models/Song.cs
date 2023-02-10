using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TickTick.Models.Contracts;

namespace TickTick.Models
{
    public class Song:BaseEntity, IPlaylistItem
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan? Duration { get ; set ; }
        public uint SequenceNumber { get ; set ; }
    }
}
