# DataTypes數據類型

Value 值類型
int float double bool char 
Structs
	Vector3 / Quaternion

值類型變量其實包含 某個值
所有引用類型變量都包含
值存儲位置的存礎地址
因此如果值類型改變
則只會影響特定變量

但如果引用類型改變
所有包含特定存儲地址的變量
都會受到影響

Reference	引用類型
Class
	Transform / GameObject

類的構造函數
---
使用構造函數
始終是類的名

構造函數不會有返回類型
連void也不會有
一個類可能有多個不同的構造函數
但對象初始化時
只會調用其中一個構造函數


Array
---
儲存同類型數據
數組不是類型 而是
特定類型的變量集合

使用之前要確認使用長度
知道會儲存多少個元素

訪問數組需要變數名 跟索引

關於數組的使用注意
如果使用公開數組 
就能在介面看到 並可設置數值

函數
players = GameObject.FindGameObjectsWithTag("Player");
開始後 可以返回場景上 Tag: Player的所有對象構成數組
並可初始化新的公開數組

另外非常適合使用循環來紀錄

Enum
---
變數代表含意 要記住它是什麼很麻煩

我們可以創建一組Enum來表示指南針的不同方位
可以在類裡面或類外面創建

注意我們也可以創建 只含Enum的腳本
可以不聲明為Class 而是將它聲明為Enum

我們可以把它放在Class
前提必須是 這個Class需要訪問這個Enum

第一個元素給 1 後面則會接著 2 3 4

如果需要更改其常量
可以參考第二組 改變類型 為 short
更改的一個主要原因是為了優化
但通常不用理會這個擔心

列舉 (enum)：也有人稱作為 "狀態機"，因為列舉常常被人拿來當作狀態判斷的使用。
enum 所佔的記憶體為 32 位元 (bit)，這是在預設的情況底下。
因為 enum 可以更改型別，共有 byte、sbyte、short、ushort、int、uint、long、ulong。
所以佔據的記憶體容量必須看你是使用什麼型別而定，不過系統預設為 int。

###### tags: #wiki #Unity #Unity_Csharp 