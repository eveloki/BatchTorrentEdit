using Config.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchTorrentEdit
{
    public class MainConfig
    {
        private static string CacheBase_Path = null;
        public static string Base_Path
        {
            get
            {
                if (string.IsNullOrEmpty(CacheBase_Path))
                {
                    CacheBase_Path = AppDomain.CurrentDomain.RelativeSearchPath ?? AppDomain.CurrentDomain.BaseDirectory;

                }

                return CacheBase_Path;
            }
        }

        private static ICacheConfig CacheConfig = null;

        public static ICacheConfig Main_Settings
        {
            get
            {
                if (CacheConfig == null)
                {
                    var configpath = System.IO.Path.Combine(Base_Path, "config.json");

                    CacheConfig = new ConfigurationBuilder<ICacheConfig>()
                                  .UseJsonFile(configpath)
                                  .Build();
                }
                return CacheConfig;
            }
        }
    }
}
