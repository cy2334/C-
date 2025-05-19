namespace StudyList;

public class ListBaseKonwledge
{
    public void Base()
    {
        var numbers = new List<int>();
        var namse = new List<string>() {"Tom","Amy" };
        
        numbers.Add(1);//添加元素
        numbers.AddRange(new []{20,30});//添加多元素
        
        numbers.Remove(10);//移除值为10的元素
        numbers.RemoveAt(0);// 按索引移除
        numbers.Clear();// 清空列表
        
        bool exists = numbers.Contains(20); // 判断是否包含某值
        
        int count = numbers.Count;          // 获取数量
    }

    public void Advanced()
    {
        var numbers = new List<int>();
        // 1. 自动扩容
        // 内部是数组实现，但支持自动增长。
        // 可通过 Capacity 预设容量优化性能：
        var list = new List<int>(1000); // 预留容量，减少扩容次数
        //2. 索引访问
        var item = numbers[1]; // 获取第2个元素
        numbers[0] = 999;      // 修改第1个元素
        //3. 查找元素
        var found = numbers.Find(n => n > 10);      // 第一个匹配项
        var index = numbers.FindIndex(n => n == 20); // 第一个匹配索引
        //排序和反转
        numbers.Sort();              // 默认升序
        numbers.Sort((a, b) => b - a); // 自定义降序
        numbers.Reverse();           // 反转列表顺序
        //遍历
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }
        //转换为数组
        int[] array = numbers.ToArray();
        //LINQ 高级查询
        var evens = numbers.Where(n => n % 2 == 0).ToList();  // 筛选偶数
        var max = numbers.Max();
        var sum = numbers.Sum();

    }
}