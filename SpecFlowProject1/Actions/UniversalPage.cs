using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Actions
{
    public class UniversalPage : UICommonActions
    {
        private static T GetPage<T>() where T : new() => new T();
        public static HomePage HomePage => GetPage<HomePage>(); 

        public static MordernWorkPage MordernWorkPage => GetPage<MordernWorkPage>();
    }
}
