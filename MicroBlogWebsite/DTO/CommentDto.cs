﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// 评论DTO
    /// </summary>
    public class CommentDto
    {
        //public int Id { get; set; }//CommentID
        public int? CommentatorUserID { get; set; }//评论人的ID
        public int? BeCommentatorUserID { get; set; }//被评论人的ID
        public string Content_text { get; set; }//内容（文本）
        public string Content_img { get; set; }//内容（图片）
        public string Content_video { get; set; }//内容（视频）
        public string Content_sound { get; set; }//内容（音频）
    }
}
