using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppMVC.Models
{
	public class TodoItem
	{
        [Key]
        public int id { get;set;}

        // 待辦事項的標題
        public string Title { get; set; }

        // 待辦事項是否完成的標記
        public bool IsCompleted { get; set; }

        // 建構子
        public TodoItem(string title)
        {
            Title = title;
            IsCompleted = false; // 預設為未完成
        }

        // 將待辦事項標記為已完成
        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        // 將待辦事項標記為未完成
        public void MarkAsIncomplete()
        {
            IsCompleted = false;
        }

        // 返回待辦事項的狀態
        public override string ToString()
        {
            return $"{Title} - {(IsCompleted ? "已完成" : "未完成")}";
        }

		public TodoItem()
		{

		}

    }
}