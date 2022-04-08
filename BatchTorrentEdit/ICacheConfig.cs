using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchTorrentEdit
{
    public interface ICacheConfig
    {
        string BeforTarkerHostName { get; set; }
        string NewTarkerHostName { get; set; }
    }
}
