using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xworks.taskprocess
{
	class Task
	{
		public Guid Id;//唯一识别ID
		public string Author;//提交者
		public DateTime SubmitTime;//提交时间
		public TaskPriority Priority;//优先度
		public DateTime DueTime;//预定日
		public string Assignee;//作业者
		public string Content;//内容
		public string HandlingNote;//处理内容
		public TaskStatus Status;
		public string Checker;//确认者
		public DateTime CheckTime;//确认时间
	}
}
