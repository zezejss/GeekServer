﻿using Geek.Server.Proto;
using NLog;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Geek.Server.Test
{
    [MsgMapping(typeof(ResBagInfo))]
    public class ResBagInfoHandler : RobotHandler
    {
        private static readonly NLog.Logger LOGGER = LogManager.GetCurrentClassLogger();
        public override Task ActionAsync()
        {
            var msg = (ResBagInfo)Msg;
            var data = msg.ItemDic;
            StringBuilder str = new StringBuilder();
            str.Append("收到背包数据:");
            foreach (KeyValuePair<int, long> keyVal in data)
            {
                str.Append($"{keyVal.Key}:{keyVal.Value},");
            }
            LOGGER.Info(str);
            return Task.CompletedTask;
        }
    }
}
