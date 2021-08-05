Invoke
將函數調用 安排在指定延遲後使用
Invoke("void 方法", 延遲);
只有void方法 跟不帶參數 才可使用Invoke

InvokeRepeating("void 方法", 2, 1);
//Invoke的重復使用版 方法 延遲 間隔

CancelInvoke("void 方法");
//只想指定可以傳 想暫停的方法