﻿using System.Collections.Generic;
using System.Text;

namespace Geek.Server
{

    public class MthInfo
    {

        public const string NotAwait = "MethodOption.NotAwait";
        public const string ThreadSafe = "MethodOption.ThreadSafe";
        public const string ExecuteTime = "MethodOption.ExecuteTime";
        public const string CanBeCalledBySameComp = "MethodOption.CanBeCalledBySameComp";

        public string Name { get; set; }

        public string Returntype { get; set; }

        public string Declare
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("public override ");
                sb.Append(Returntype);
                sb.Append(" ");
                sb.Append(Name);
                sb.Append(Typeparams);
                sb.Append(ParamDeclare);
                //sb.Append(" ");
                //sb.Append(Constraint);
                return sb.ToString();
            }
        }

        public bool IsPublic { get; set; }

        public bool IsStatic { get; set; }

        public bool IsVirtual { get; set; }

        public List<string> Params { get; private set; } = new List<string>();

        public List<string> AttributeList { get; private set; } = new List<string>();

        public bool Isnotawait { get; set; }

        public bool Isthreadsafe { get; set; }

        public bool IsCanBeCalledBySameComp { get; set; }

        public int Executetime { get; set; } = 12000;

        /// <summary>
        /// 约束
        /// </summary>
        public string Constraint { get; set; }

        /// <summary>
        /// 泛型参数
        /// </summary>
        public string Typeparams { get; set; }

        /// <summary>
        /// 参数声明
        /// </summary>
        public string ParamDeclare { get; set; }

        public string Paramstr 
        { 
            get 
            {
                if (Params.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < Params.Count; i++)
                    {
                        sb.Append(Params[i]);
                        if(i != Params.Count-1)
                            sb.Append(",");
                    }
                    return sb.ToString();
                }
                return "";
            }
        }
    }

    public class AgentInfo
    {
        public string Space { get; set; }
        public string Name { get; set; }
        public string Super { get; set; }
        public List<MthInfo> Methods { get; set; } = new List<MthInfo>();
        public List<string> Usingspaces { get; set; } = new List<string>();
    }
}
