﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Models
{
    [Table("Tana_MicroBlog")]
    public class MicroBlog:BaseEntity
    {

        public MicroBlog()
        {
            this.TimeDifference = CreateTime;
        }
        //public int Id { get; set; }//MicroBlogID


        
        public int UserID { get; set; }//UserID  外键（UserInfo）
        [ForeignKey("")]
        public virtual UserInfo MicroBlogUserID { get; set; }


        
        public string Title { get; set; }//标题
        public string Content_text { get; set; }//内容（文本）
        public string Content_img { get; set; }//内容（图片）
        public string Content_video { get; set; }//内容（视频）
        public string Content_sound { get; set; }//内容（音频）

        [DefaultValue(0)]
        public int Points_number { get; set; }//点赞数量
        public string Place { get; set; }//发布地点（省市）
        public int Cansee_states { get; set; }//可见状态，0所有人可见，1只有好友可见,2仅自己可见（0/1/2）


        //public DateTime ReleaseTime { get; set; }//发布时间


        [NotMapped]
        /// <summary>
        /// 时间差
        /// </summary>
        public DateTime TimeDifference { get; set; }

    }
}
