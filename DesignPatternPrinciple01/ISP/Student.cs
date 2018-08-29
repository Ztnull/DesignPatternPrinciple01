using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// 就想看看电影  听听歌
        /// iphone  ipad  itouch
        /// </summary>
        /// <param name="phone"></param>
        public void MovieMusic(IExtend phone)
        {
            phone.Movie();
            phone.Music();

            //phone.
        }

        /// <summary>
        /// 拆成一个方法一个接口
        /// 太零碎了。。使用困难
        /// </summary>
        /// <param name="phone"></param>
        public void PhotoVideo(IPhotoVideo phone)
        {
            phone.Photo();
            phone.Video();
        }
    }
}
