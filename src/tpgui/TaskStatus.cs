using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xworks.taskprocess
{
	enum TaskStatus
	{
		NotStart = 0,//未着手
		Handling,//作业中
		Finished,//完成
		Accept,//已经确认
		Reject,//被驳回
	}
}
