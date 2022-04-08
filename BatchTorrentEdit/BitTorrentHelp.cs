using MonoTorrent;
using MonoTorrent.BEncoding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchTorrentEdit
{
    /// <summary>
    /// BT种子帮助类
    /// </summary>
    public class BitTorrentHelp
    {
        /// <summary>
        /// 创建种子
        /// </summary>
        /// <param name="filepath">需要做种的文件路径</param>
        /// <param name="tarker">tarker服务器地址</param>
        /// <param name="savepath">保存路径</param>
        /// <param name="PieceLength">种子大小</param>
        /// <returns></returns>
        public static async Task<bool> CreatBitTorrent(string filepath, List<string> tarker, string savepath, long PieceLength = 4194304)
        {
            try
            {

                MonoTorrent.TorrentCreator creator = new MonoTorrent.TorrentCreator();
                //设置为私有种子
                creator.Private = true;
                //设置tarker
                if (tarker.Count == 1)
                {
                    creator.Announce = tarker[0].Trim();
                }
                else
                {
                    creator.Announces.Add(tarker);
                }

                creator.CreatedBy = "AudiencesTools By MonoTorrent V2.0.3";
                creator.PieceLength = PieceLength;//4MB
                await creator.CreateAsync(new TorrentFileSource(filepath), savepath);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }
        public static async Task<bool> EditBitTorrent(string filepath, string savepath, string oldTarker,string newTarker)
        {
            try
            {
                oldTarker = oldTarker.Trim();
                newTarker = newTarker.Trim();

                var TFS = new TorrentFileSource(filepath);

                var TorrentInfo = Torrent.Load(filepath);
                if (TorrentInfo == null) return false;

                var allbytes = System.IO.File.ReadAllBytes(filepath);

                var dict = (MonoTorrent.BEncoding.BEncodedDictionary)BEncodedValue.Decode(allbytes);
                MonoTorrent.TorrentEditor torrentEditor = new MonoTorrent.TorrentEditor(dict);
                if (torrentEditor.Announces != null)
                {
                    if (torrentEditor.Announces.Count > 0)
                    {
                        for (int i = 0; i < torrentEditor.Announces.Count; i++)
                        {
                            for (int K = 0; K < torrentEditor.Announces[i].Count; K++)
                            {
                                if (!string.IsNullOrEmpty(torrentEditor.Announces[i][K]))
                                {
                                    torrentEditor.Announces[i][K] = torrentEditor.Announces[i][K].Replace(oldTarker, newTarker);
                                }

                            }

                        }
                    }
                }
                if (!string.IsNullOrEmpty(torrentEditor.Announce))
                {
                    torrentEditor.Announce = torrentEditor.Announce.Replace(oldTarker, newTarker);
                }
                var tor = torrentEditor.ToDictionary();
                File.WriteAllBytes(savepath, tor.Encode());
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
