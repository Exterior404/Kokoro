# Data-Oriented Tech Stack 

Dots (面向數據科技棧)
Data oriented technology stack

[[ECS]]模式

C# [[Job System]]
Entity Component System 
Burst Compiler 

C# Job system
---
可以利用多核處理器
同時運行多個任務

Unity一直的主要問題就是主線程以單線程更新
多線程編寫 調試跟測試較難
Job則是優化此問題

Entity Component System 
---
其編寫時需要有一種不同的思維模式
要把 邏輯 和 數據 拆開

並不像 Monobehaviour中的 GameObject
該系統中有 Entity/ Component/ System 

```
Entites refer to Component instances
Components hold Data
Systems process Data
```

Entity 上的 Component 包含有數據
而 System會應用邏輯到數據上

Burst Compiler 
---
將上兩系統高度優化成機械碼
還可以配合不同平台來優化
只需要 括號加入屬性 Attribute

###### tags: #wiki #Unity 