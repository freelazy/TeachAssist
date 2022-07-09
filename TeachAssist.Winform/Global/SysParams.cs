using System.Collections.Generic;
using TeachAssist.DAL;

namespace TeachAssist.Winform.Global
{
    public class SysParams
    {
        static Dictionary<string, (string value, string category, int type)> _params = new();

        public static void LoadParams()
        {
            _params.Clear();
            foreach (var (name, value, category, type) in new SysParamDAO().GetAllParams())
            {
                _params[name] = (value, category, type);
            }
        }

        public static Dictionary<string, (string value, string category, int type)> Items => _params;

        public static object Get(string key) => _params.ContainsKey(key) ? _params[key].value : null;

        #region 辅助方法

        /// <summary>
        /// 设置头像文件夹的位置
        /// </summary>
        public static string AvatarDir => (string)Get("avatarDir") ?? "E:/Assets/";

        /// <summary>
        /// 打开程序后，默认显示哪个窗体。第几个，从 1 开始
        /// </summary>
        public static int DefaultMenuIndex
        {
            get
            {
                var index = Get("defaultMenuIndex");
                return index == null ? 2 : int.Parse(index.ToString());
            }
        }

        /// <summary>
        /// 自动点名的时间间隔。如果没有设置，默认为 3 秒
        /// </summary>
        public static int AutoRollInterval
        {
            get
            {
                var interval = Get("autoRollInterval");
                return interval == null ? 3000 : int.Parse(interval.ToString());
            }
        }

        #endregion
    }
}
