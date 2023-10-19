# 如何使用
把 ```Using SheepYhangCN.WindowCenter;``` 添加到你C#檔案的開頭

執行```WindowCenter.Set();```來直接居中視窗位置
執行```WindowCenter.Get(DisplayServer.ScreenGetUsableRect(),DisplayServer.WindowGetSize());```來獲取位置的Vector2I