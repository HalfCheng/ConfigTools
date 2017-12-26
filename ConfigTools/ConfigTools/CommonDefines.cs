﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigTools
{
    //字段类型
    public enum TableFieldType
    {
        TFT_Int = 0,
        TFT_Float = 1,
        TFT_String = 2,
        TFT_Bool = 3,
        TFT_IntList = 4,
        TFT_FloatList = 5,
        TFT_StringList = 6,
    }

    //导出配置类型
    public enum ExportCfgType
    {
        NULL,   //不导出配置
        All,    //所有
        Client, //仅客户端
        Server  //仅服务器
    }

    //导出代码类型
    public enum ExportCodeType
    {
        NULL,       //不导出代码
        CSharp,
        TypeScript
    }
}