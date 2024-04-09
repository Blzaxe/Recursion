public class MainClass
{
    public static void Main()
    {
        //費氏數列
        //一列數的規則如下: 1、1、2、3、5、8、13、21、34......  求第30位數是多少，用遞迴演算法實現。
        Console.WriteLine(Foo(30));
    }
    /// <summary>
    /// 減法方式遞迴處理
    /// </summary>
    /// <param name="i"></param> 當前位數
    /// <returns></returns>
    public static int Foo(int i)
    {
        if (i == 0)
            return 0;
        if (i == 1)
            return 1;
        else return Foo(i - 1) + Foo(i - 2);
    }
}