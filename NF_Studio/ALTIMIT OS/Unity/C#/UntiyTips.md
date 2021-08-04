
partial
---
將一份文件 
如開影分身一樣
```csharp
public partial class CardUI : MonoBehaviour {
	//第一份文件腳本
}

public partial class CardUI {
	//第二份文件之後 跟第一份同名
	//檔名可以不一樣哦 只要掛載第一份文
}
```

this
---
Unity 本身有很多庫
不得對原庫動手腳
另外造出兵器庫的方法
```csharp
public static class CodeThis {
	public static void DoSomethis(this GameObject obj) {
		//額外的 全新 方法
	}
}
```

```csharp
public class Code {
	public GameObject obj;
	Start() {
		obj.DoSomethis();
		//這樣就可以使用靜態額外的方法
	}
}
```

###### tags: #wiki #Unity #Unity_SOP 