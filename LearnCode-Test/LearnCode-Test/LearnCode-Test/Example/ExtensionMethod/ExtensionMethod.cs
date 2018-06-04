// ===============================================================================
// 项目名称  :    LearnCode_Test.Example.ExtensionMethod
// 项目描述  :    
// ===============================================================================
// 类名称    :    ExtensionMethod
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2018-6-4 17:12:00
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnCode_Test.Example.ExtensionMethod
{
    public static class ExtensionMethod
    {
        public static void WriteSelf(this string strself,int year)
        {
            MessageBox.Show(string.Format("我是'{0}',今年'{1}'岁",strself,year));
            
        }
    }
}
