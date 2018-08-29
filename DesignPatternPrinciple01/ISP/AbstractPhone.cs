using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPrinciple01.ISP
{
    public abstract class AbstractPhone
    {
        public int Id { get; set; }
        public string Branch { get; set; }

        public abstract void Call();
        public abstract void Text();
    }


    public interface IExtend
    {
        void Online();
        void Game();
        void Movie();
        void Music();
    }

    public interface IExtendAdvanced
    {
        /// <summary>
        /// 录音
        /// </summary>
        void Record();
        /// <summary>
        /// 导航
        /// </summary>
        void Map();
        /// <summary>
        /// 支付
        /// </summary>
        void Pay();
    }

    /// <summary>
    /// 专门拍照 录视频
    /// </summary>
    public interface IPhotoVideo
    {
        /// <summary>
        /// 拍视频
        /// </summary>
        void Video();
        /// <summary>
        /// 拍照
        /// </summary>
        void Photo();
    }

    //一个方法拆分成一个接口，太过于零碎，使用起来成本太大


    public interface IMap
    {
        void Map();//内部实现这三个方法

        //void Location();
        //void Search();
        //void Goto();
    }


}
