// ===============================================================================
// 项目名称  :    LearnCode_Test.Example.ExtensionMethod
// 项目描述  :    
// ===============================================================================
// 类名称    :    MyDelegate
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2018-6-5 10:30:18
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
    /// <summary>
    /// 委托学习
    /// </summary>
    public class MyDelegate
    {
       //委托申明  Delegate至少0个参数，至多32个参数，可以无返回值，也可以指定返回值类型。
       public delegate void mDelegate(string str);

       public static void HellowWord(string strCountry)
       {
           MessageBox.Show(string.Format("Hellow '{0}'", strCountry)); 
       }

       public static bool HellowChina(string strCountry)
       {
           MessageBox.Show(string.Format("Hellow '{0}'", strCountry));
           return true;
       }
       public void excuteDelegate()
       {
           mDelegate mydelegate = new mDelegate(HellowWord);
           mydelegate("China");

           //Action是无返回值的泛型委托。
           //Action 表示无参，无返回值的委托
           //Action<int,string> 表示有传入参数int,string无返回值的委托
           //Action<int,string,bool> 表示有传入参数int,string,bool无返回值的委托
           //Action<int,int,int,int> 表示有传入4个int型参数，无返回值的委托
           //Action至少0个参数，至多16个参数，无返回值。
           Action<string> action = HellowWord;
           action("American");

           //Func是有返回值的泛型委托
           //Func<int> 表示无参，返回值为int的委托
           //Func<object,string,int> 表示传入参数为object, string 返回值为int的委托
           //Func<object,string,int> 表示传入参数为object, string 返回值为int的委托
           //Func<T1,T2,,T3,int> 表示传入参数为T1,T2,,T3(泛型)返回值为int的委托
           //Func至少0个参数，至多16个参数，根据返回值泛型返回。必须有返回值，不可void
           Func<string, bool> func = HellowChina;
           func("China");

           //predicate 是返回bool型的泛型委托
　　       //predicate<int> 表示传入参数为int 返回bool的委托
　　       //Predicate有且只有一个参数，返回值固定为bool
           //List.Find

           //Conparison  List.Sort
         
       }
    }
}
