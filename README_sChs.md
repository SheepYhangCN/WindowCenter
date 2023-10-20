# 如何使用
把 ```using SheepYhangCN.WindowCenter;``` 添加到你C#文件的开头

执行```WindowCenter.Set();```来直接居中窗口位置<br>
执行```WindowCenter.Get(DisplayServer.ScreenGetUsableRect(),DisplayServer.WindowGetSize());```来获取位置的Vector2I