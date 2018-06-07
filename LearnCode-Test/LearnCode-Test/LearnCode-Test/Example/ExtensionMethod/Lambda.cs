// ===============================================================================
// 项目名称  :    LearnCode_Test.Example.ExtensionMethod
// 项目描述  :    
// ===============================================================================
// 类名称    :    lambda
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2018-6-6 15:53:52
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

    public class Uesr
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public int Age { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ClassName { get; set; }
    }


    public class Lambda
    {
        delegate int AddDel(int a,int b);//定义一个委托
        public void LambdaTest()
        {
            List<string> list = new List<string>() { "1","2","3","4"};
            List<string> temp = list.FindAll(s => int.Parse(s) > 1);
            List<int> list2 = new List<int>() { 1,2,3,4,5,6};
            list2.FindAll(GetEvenNum);
            MessageBox.Show(temp[1]);

            //lambda实际就是一个匿名函数
            Func<int, int, int> func = (a, b) => a + b;
            func(1, 2);
            AddDel funLambda = delegate(int a, int b) { return a + b; };//匿名函数
            funLambda(1, 3);

            //标准查询运算（SQO）  SQO缺点：语句太庞大 复杂
            //筛选、投影、聚合、排序等功能
            List<Uesr> userList = new List<Uesr>() { 
                new Uesr{Id=1,Name="张三",Age=21},
                new Uesr{Id=2,Name="张三",Age=22},
                new Uesr{Id=3,Name="张三",Age=23},
                new Uesr{Id=4,Name="张三",Age=24},
                new Uesr{Id=5,Name="张三",Age=25},
                new Uesr{Id=6,Name="张三",Age=26},
                new Uesr{Id=7,Name="张三",Age=27},
                new Uesr{Id=8,Name="张三",Age=28}
            };
            //集合筛选
            userList = userList.Where(x => x.Age > 25).OrderBy(x=>x.Name).ToList<Uesr>();
            userList.ForEach(r =>Update(r.Id));//更新

            //查询单个实体
            userList.FirstOrDefault<Uesr>(s => s.Age > 25);

            //查询投射Select
            userList.Where(x => x.Age > 25).Select(a => a.Name.Contains("b")).ToList();
            userList.Where(x => x.Age > 25).Select(a => new { a.Name,a.Id}).ToList();

            //集合连接Join（）
            //新建一个Student集合，并初始化数据
            List<Student> lstStudent = new List<Student>() { 
                    new Student{Id=1,UserId=1,ClassName="电信一班"},
                    new Student{Id=2,UserId=2,ClassName="电信二班"},
                    new Student{Id=3,UserId=3,ClassName="电信三班"}
            };
            
            var result = userList.Join(lstStudent, u => u.Id, p => p.UserId, (u, p) => new { UserId = u.Id, Name = u.Name, ClassName = p.ClassName });


        }

        private bool GetEvenNum(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }
        private void Update(int Id)
        {
 
        }
    }
}
