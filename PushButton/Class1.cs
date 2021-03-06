﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Imaging;

using Autodesk.Revit.UI;
using Autodesk.Revit.DB;

namespace PushButton
{
    public class CsAddpanel:Autodesk.Revit.UI.IExternalApplication
    {public Autodesk.Revit.UI.Result Onstartup(UIControlledApplication application)
        {
            //添加一个新的Ribbon面板
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("NewRibbonPanel");
            //在新的Ribbon面板上添加一个按钮
            //点击这个按钮，前一个例子“HelloRevit”这个插件将被运行。
            PushButton pushButton = ribbonPanel.AddItem(new PushButtonData("HelloRevit", "HelloRevit", @"C:\Users\ji\Source\Repos\NewRepo\HelloRevit\bin\Debug\HelloRevit.dll", "HelloRevit.Class1")) as PushButton;

            //给按钮添加一个图片
            Uri uriImage = new Uri(@"C:\Users\ji\Source\Repos\NewRepo\PushButton\logo.png");
            BitmapImage largeImage = new BitmapImage(uriImage);
            pushButton.LargeImage = largeImage;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        { return Result.Succeeded;
        }
    }
}
