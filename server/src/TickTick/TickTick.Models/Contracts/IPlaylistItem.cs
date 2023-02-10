using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickTick.Models.Contracts
{
    public interface IPlaylistItem
    {
        TimeSpan? Duration { get; set; }
        string Title { get; set; }
        uint SequenceNumber { get; set; }
    }
}
